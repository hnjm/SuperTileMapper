﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTileMapper
{
    public partial class OBJEditor : Form
    {
        bool updatingDetails = false;

        int pickerZoom = 1;
        int pickerTile = 0;
        bool pickerFlipH = false;
        bool pickerFlipV = false;
        bool pickerSize = false;
        int pickerPriority = 0;
        int pickerPalette = 0;

        int viewerZoom = 1;
        int viewerAcross = 0x20;
        int viewerTransparency = 0;

        public OBJEditor()
        {
            InitializeComponent();
            pictureSelTile.Image = new Bitmap(64, 64);
            UpdateDetails();
            RedrawAll();
            UpdateScrollbars();
        }

        private void UpdateScrollbars()
        {
            bool extendTilemap = pictureBox1.Width > 512 || pictureBox1.Height > 512;
            if (!extendTilemap) panel1.AutoScroll = extendTilemap;
            panel1.HorizontalScroll.Visible = !extendTilemap;
            panel1.VerticalScroll.Visible = !extendTilemap;
            panel1.HorizontalScroll.Enabled = extendTilemap;
            panel1.VerticalScroll.Enabled = extendTilemap;
            if (extendTilemap) panel1.AutoScroll = extendTilemap;

            bool extendPicker = pictureBox2.Width > 256 || pictureBox2.Height > 256;
            if (!extendPicker) panel2.AutoScroll = extendPicker;
            panel2.HorizontalScroll.Visible = !extendPicker;
            panel2.VerticalScroll.Visible = !extendPicker;
            panel2.HorizontalScroll.Enabled = extendPicker;
            panel2.VerticalScroll.Enabled = extendPicker;
            if (extendPicker) panel2.AutoScroll = extendPicker;
        }

        public void RedrawAll()
        {
            RedrawPicker();
            RedrawViewer();
            UpdateScrollbars();
        }

        private void RedrawPicker()
        {
            if (pictureBox2.Image != null) pictureBox2.Image.Dispose();

            Bitmap img = new Bitmap(pickerZoom * 8 * 0x10, pickerZoom * 8 * 0x20);

            for (int ty = 0; ty < 0x20; ty++)
            {
                for (int tx = 0; tx < 0x10; tx++)
                {
                    DrawTile(ty * 0x10 + tx, false, false, pickerPalette, img, 8 * tx, 8 * ty, pickerZoom, 0);
                }
            }

            pictureBox2.Image = img;
            pictureBox2.Width = img.Width;
            pictureBox2.Height = img.Height;
        }

        private void RedrawViewer()
        {
            int objsize = (Data.GetPPUReg(0x01) & 0xE0) >> 5;
            int objw = Util.OBJsizes[objsize, 1, 0], objh = Util.OBJsizes[objsize, 1, 1];

            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            Bitmap img = new Bitmap(viewerZoom * objw * viewerAcross, viewerZoom * objh * 0x80 / viewerAcross);
            pictureBox1.Image = img;

            for (int i = 0; i < 0x80; i++) Redraw(i);

            pictureBox1.Width = img.Width;
            pictureBox1.Height = img.Height;
        }

        public void Redraw(int obj)
        {
            Bitmap img = (Bitmap)pictureBox1.Image;

            int objsize = (Data.GetPPUReg(0x01) & 0xE0) >> 5;
            int objw = Util.OBJsizes[objsize, 1, 0], objh = Util.OBJsizes[objsize, 1, 1];

            int objWord = Data.GetOAMWord(2 * obj + 1);
            int objBits = (Data.GetOAMByte(0x200 + obj / 4) >> (2 * (obj % 4))) & 0x3;

            int t = objWord & 0x1FF;
            bool v = (objWord & 0x8000) != 0;
            bool h = (objWord & 0x4000) != 0;
            int c = (objWord & 0x0E00) >> 9;
            bool s = (objBits & 0x02) != 0;

            DrawOBJ(t, h, v, s, c, img, objw * (obj % viewerAcross), objh * (obj / viewerAcross), viewerZoom);

            pictureBox1.Image = img;
        }

        private void DrawTile(int tile, bool h, bool v, int c, Bitmap img, int x, int y, int zoom, int t)
        {
            int nameBase = 0xE000 & ((Data.GetPPUReg(0x01) & 0x7) << 14);
            int nameOffset = 0x6000 & ((Data.GetPPUReg(0x01) & 0x18) << 10);
            int tileOffset = tile * 0x20;

            int vram = 0xFFFF & (nameBase + (tile >= 0x100 ? nameOffset : 0) + tileOffset);
            int cgram = 0x80 + 0x10 * c;
            SNESGraphics.Draw8x8Tile(vram, 1, h, v, cgram, img, x, y, zoom, t);
        }

        private void DrawOBJ(int tile, bool h, bool v, bool s, int c, Bitmap img, int x, int y, int zoom)
        {
            int objsize = (Data.GetPPUReg(0x01) & 0xE0) >> 5;
            int nameBase = 0xE000 & ((Data.GetPPUReg(0x01) & 0x7) << 14);
            int nameOffset = 0x6000 & ((Data.GetPPUReg(0x01) & 0x18) << 10);
            int vram = 0xFFFF & (nameBase + (tile >= 0x100 ? nameOffset : 0) + tile * 0x20);
            int cgram = 0x80 + SNESGraphics.colorsPerPalette[1] * c;
            int bw = Util.OBJsizes[objsize, (s ? 1 : 0), 0] / 8, bh = Util.OBJsizes[objsize, (s ? 1 : 0), 1] / 8;

            for (int ty = 0; ty < bh; ty++)
            {
                for (int tx = 0; tx < bw; tx++)
                {
                    SNESGraphics.Clear8x8Tile(cgram, img, x + 8 * tx, y + 8 * ty, zoom, viewerTransparency);
                }
            }
            SNESGraphics.DrawObject(vram, h, v, bw, bh, cgram, img, x, y, zoom);
        }

        private void RedrawSelectedTile()
        {
            pictureSelTile.Image.Dispose();
            Bitmap img = new Bitmap(64, 64);

            int objsize = (Data.GetPPUReg(0x01) & 0xE0) >> 5;
            int objh = Util.OBJsizes[objsize, (pickerSize ? 1 : 0), 1];
            int zoom = 0x40 / objh;

            DrawOBJ(pickerTile, pickerFlipH, pickerFlipV, pickerSize, pickerPalette, img, 0, 0, zoom);

            pictureSelTile.Image = img;
        }

        private void updateCheckboxes()
        {
            pickerZoom100.Checked = (pickerZoom == 1);
            pickerZoom200.Checked = (pickerZoom == 2);
            pickerZoom300.Checked = (pickerZoom == 3);
            pickerZoom400.Checked = (pickerZoom == 4);
            viewerZoom100.Checked = (viewerZoom == 1);
            viewerZoom200.Checked = (viewerZoom == 2);
            viewerZoom300.Checked = (viewerZoom == 3);
            viewerZoom400.Checked = (viewerZoom == 4);
            viewerTransLocal0.Checked = (viewerTransparency == 0);
            viewerTransColor00.Checked = (viewerTransparency == 1);
            viewerTransBlack.Checked = (viewerTransparency == 2);
            viewerTransWhite.Checked = (viewerTransparency == 3);
            viewerWidth32.Checked = (viewerAcross == 0x20);
            viewerWidth16.Checked = (viewerAcross == 0x10);
            viewerWidth8.Checked = (viewerAcross == 0x08);
            viewerWidth4.Checked = (viewerAcross == 0x04);
            RedrawAll();
        }

        private void pickerZoom100_Click(object sender, EventArgs e)
        {
            pickerZoom = 1;
            updateCheckboxes();
        }

        private void pickerZoom200_Click(object sender, EventArgs e)
        {
            pickerZoom = 2;
            updateCheckboxes();
        }

        private void pickerZoom300_Click(object sender, EventArgs e)
        {
            pickerZoom = 3;
            updateCheckboxes();
        }

        private void pickerZoom400_Click(object sender, EventArgs e)
        {
            pickerZoom = 4;
            updateCheckboxes();
        }

        private void viewerZoom100_Click(object sender, EventArgs e)
        {
            viewerZoom = 1;
            updateCheckboxes();
        }

        private void viewerZoom200_Click(object sender, EventArgs e)
        {
            viewerZoom = 2;
            updateCheckboxes();
        }

        private void viewerZoom300_Click(object sender, EventArgs e)
        {
            viewerZoom = 3;
            updateCheckboxes();
        }

        private void viewerZoom400_Click(object sender, EventArgs e)
        {
            viewerZoom = 4;
            updateCheckboxes();
        }

        private void viewerWidth32_Click(object sender, EventArgs e)
        {
            viewerAcross = 0x20;
            updateCheckboxes();
        }

        private void viewerWidth16_Click(object sender, EventArgs e)
        {
            viewerAcross = 0x10;
            updateCheckboxes();
        }

        private void viewerWidth8_Click(object sender, EventArgs e)
        {
            viewerAcross = 0x08;
            updateCheckboxes();
        }

        private void viewerWidth4_Click(object sender, EventArgs e)
        {
            viewerAcross = 0x04;
            updateCheckboxes();
        }

        private void viewerTransLocal0_Click(object sender, EventArgs e)
        {
            viewerTransparency = 0;
            updateCheckboxes();
        }

        private void viewerTransColor00_Click(object sender, EventArgs e)
        {
            viewerTransparency = 1;
            updateCheckboxes();
        }

        private void viewerTransBlack_Click(object sender, EventArgs e)
        {
            viewerTransparency = 2;
            updateCheckboxes();
        }

        private void viewerTransWhite_Click(object sender, EventArgs e)
        {
            viewerTransparency = 3;
            updateCheckboxes();
        }

        private void UpdateDetails()
        {
            updatingDetails = true;

            labelTileNo.Text = "Tile $" + Util.DecToHex(pickerTile, 3);
            textPalette.Text = "$" + Util.DecToHex(pickerPalette, 2);
            checkFlipH.Checked = pickerFlipH;
            checkFlipV.Checked = pickerFlipV;
            checkSize.Checked = pickerSize;
            textPriority.Text = "$" + Util.DecToHex(pickerPriority, 2);

            RedrawSelectedTile();

            updatingDetails = false;
        }

        private void checkFlipH_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingDetails)
            {
                pickerFlipH = checkFlipH.Checked;
                UpdateDetails();
                RedrawPicker();
            }
        }

        private void checkFlipV_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingDetails)
            {
                pickerFlipV = checkFlipV.Checked;
                UpdateDetails();
                RedrawPicker();
            }
        }

        private void checkSize_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingDetails)
            {
                pickerSize = checkSize.Checked;
                UpdateDetails();
                RedrawPicker();
            }
        }

        private void textPriority_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (Util.TryHexOrDecToDec(textPriority.Text, out val))
            {
                if (val >= 0 && val < 8)
                {
                    pickerPriority = val;
                    RedrawSelectedTile();
                    RedrawPicker();
                }
            }
        }

        private void textPalette_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (Util.TryHexOrDecToDec(textPalette.Text, out val))
            {
                if (val >= 0 && val < 8)
                {
                    pickerPalette = val;
                    RedrawSelectedTile();
                    RedrawPicker();
                }
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            int tx = e.X / (8 * pickerZoom);
            int ty = e.Y / (8 * pickerZoom);
            pickerTile = tx + 0x10 * ty;
            UpdateDetails();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int objsize = (Data.GetPPUReg(0x01) & 0xE0) >> 5;
            int objw = Util.OBJsizes[objsize, 1, 0], objh = Util.OBJsizes[objsize, 1, 1];

            int ox = e.X / (objw * viewerZoom);
            int oy = e.Y / (objh * viewerZoom);
            int objI = oy * viewerAcross + ox;

            int objWord = Data.GetOAMWord(2 * objI + 1);
            int objBits = (Data.GetOAMByte(0x200 + objI / 4) >> (2 * (objI % 4))) & 0x3;

            pickerTile = objWord & 0x1FF;
            pickerFlipV = (objWord & 0x8000) != 0;
            pickerFlipH = (objWord & 0x4000) != 0;
            pickerSize = (objBits & 0x02) != 0;
            pickerPriority = (objWord & 0x3000) >> 4;
            pickerPalette = (objWord & 0x0E00) >> 9;

            UpdateDetails();
        }
    }
}
