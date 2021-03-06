﻿namespace SuperTileMapper
{
    partial class SuperTileMapper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertUnsavedChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vRAMEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cGRAMEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAMEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pPURegistersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tilemapEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oBJEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.importEmulatorStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.noneToolStripMenuItem.Text = "(none)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(512, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.importEmulatorStateToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.saveProjectAsToolStripMenuItem,
            this.revertUnsavedChangesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.newToolStripMenuItem.Text = "New Project...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.openToolStripMenuItem.Text = "Open Project...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Enabled = false;
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.saveProjectToolStripMenuItem_Click);
            // 
            // saveProjectAsToolStripMenuItem
            // 
            this.saveProjectAsToolStripMenuItem.Name = "saveProjectAsToolStripMenuItem";
            this.saveProjectAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveProjectAsToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.saveProjectAsToolStripMenuItem.Text = "Save Project As...";
            this.saveProjectAsToolStripMenuItem.Click += new System.EventHandler(this.saveProjectAsToolStripMenuItem_Click);
            // 
            // revertUnsavedChangesToolStripMenuItem
            // 
            this.revertUnsavedChangesToolStripMenuItem.Name = "revertUnsavedChangesToolStripMenuItem";
            this.revertUnsavedChangesToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.revertUnsavedChangesToolStripMenuItem.Text = "Revert Unsaved Changes";
            this.revertUnsavedChangesToolStripMenuItem.Click += new System.EventHandler(this.revertUnsavedChangesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vRAMEditorToolStripMenuItem,
            this.cGRAMEditorToolStripMenuItem,
            this.oAMEditorToolStripMenuItem,
            this.pPURegistersToolStripMenuItem,
            this.toolStripSeparator2,
            this.tilemapEditorToolStripMenuItem,
            this.oBJEditorToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.ShowShortcutKeys = false;
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // vRAMEditorToolStripMenuItem
            // 
            this.vRAMEditorToolStripMenuItem.Name = "vRAMEditorToolStripMenuItem";
            this.vRAMEditorToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.vRAMEditorToolStripMenuItem.Text = "VRAM";
            this.vRAMEditorToolStripMenuItem.Click += new System.EventHandler(this.vRAMEditorToolStripMenuItem_Click);
            // 
            // cGRAMEditorToolStripMenuItem
            // 
            this.cGRAMEditorToolStripMenuItem.Name = "cGRAMEditorToolStripMenuItem";
            this.cGRAMEditorToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cGRAMEditorToolStripMenuItem.Text = "CGRAM";
            this.cGRAMEditorToolStripMenuItem.Click += new System.EventHandler(this.cGRAMEditorToolStripMenuItem_Click);
            // 
            // oAMEditorToolStripMenuItem
            // 
            this.oAMEditorToolStripMenuItem.Name = "oAMEditorToolStripMenuItem";
            this.oAMEditorToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.oAMEditorToolStripMenuItem.Text = "OAM";
            this.oAMEditorToolStripMenuItem.Click += new System.EventHandler(this.oAMEditorToolStripMenuItem_Click);
            // 
            // pPURegistersToolStripMenuItem
            // 
            this.pPURegistersToolStripMenuItem.Name = "pPURegistersToolStripMenuItem";
            this.pPURegistersToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.pPURegistersToolStripMenuItem.Text = "PPU Registers";
            this.pPURegistersToolStripMenuItem.Click += new System.EventHandler(this.pPURegistersToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // tilemapEditorToolStripMenuItem
            // 
            this.tilemapEditorToolStripMenuItem.Name = "tilemapEditorToolStripMenuItem";
            this.tilemapEditorToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tilemapEditorToolStripMenuItem.Text = "Tilemap Editor";
            this.tilemapEditorToolStripMenuItem.Click += new System.EventHandler(this.tilemapEditorToolStripMenuItem_Click);
            // 
            // oBJEditorToolStripMenuItem
            // 
            this.oBJEditorToolStripMenuItem.Name = "oBJEditorToolStripMenuItem";
            this.oBJEditorToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.oBJEditorToolStripMenuItem.Text = "OBJ Editor";
            this.oBJEditorToolStripMenuItem.Click += new System.EventHandler(this.oBJEditorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShowShortcutKeys = false;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 478);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "SuperTileMapper Projects|*.stm";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "SuperTileMapper Project|*.stm";
            // 
            // importEmulatorStateToolStripMenuItem
            // 
            this.importEmulatorStateToolStripMenuItem.Name = "importEmulatorStateToolStripMenuItem";
            this.importEmulatorStateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importEmulatorStateToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.importEmulatorStateToolStripMenuItem.Text = "Import Emulator State...";
            this.importEmulatorStateToolStripMenuItem.Click += new System.EventHandler(this.importEmulatorStateToolStripMenuItem_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "ZSNES Save States|*.z*|SNES9x Save States|*.0*|BSNES Save States|*.bst|LSNES Save" +
    " States|*.lsmv|Bizhawk Save States|*.State";
            // 
            // SuperTileMapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(528, 541);
            this.MinimumSize = new System.Drawing.Size(528, 541);
            this.Name = "SuperTileMapper";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Super Tile Mapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.SuperTileMapper_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem vRAMEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cGRAMEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAMEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pPURegistersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tilemapEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oBJEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertUnsavedChangesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem importEmulatorStateToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

