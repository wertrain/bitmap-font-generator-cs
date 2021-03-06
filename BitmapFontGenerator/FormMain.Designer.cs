﻿namespace BitmapFontGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExportFile = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelFontSettings = new System.Windows.Forms.Panel();
            this.groupBoxOption = new System.Windows.Forms.GroupBox();
            this.checkBoxShowGrid = new System.Windows.Forms.CheckBox();
            this.groupBoxCodeArea = new System.Windows.Forms.GroupBox();
            this.checkBoxDrawJIS2Kanji = new System.Windows.Forms.CheckBox();
            this.checkBoxDrawJIS1Kanji = new System.Windows.Forms.CheckBox();
            this.checkBoxDrawPlatformDependent = new System.Windows.Forms.CheckBox();
            this.checkBoxDrawZenkaku = new System.Windows.Forms.CheckBox();
            this.checkBoxDrawHankaku = new System.Windows.Forms.CheckBox();
            this.buttonExportFile = new System.Windows.Forms.Button();
            this.groupBoxFontDetails = new System.Windows.Forms.GroupBox();
            this.radioButtonAlignRight = new System.Windows.Forms.RadioButton();
            this.radioButtonAlignCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonAlignLeft = new System.Windows.Forms.RadioButton();
            this.checkBoxStrikeout = new System.Windows.Forms.CheckBox();
            this.checkBoxTextUnderline = new System.Windows.Forms.CheckBox();
            this.checkBoxTextItalic = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableBackgroundTransparent = new System.Windows.Forms.CheckBox();
            this.checkBoxTextBold = new System.Windows.Forms.CheckBox();
            this.pictureBoxBackgroundColorPreview = new System.Windows.Forms.PictureBox();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxTextColorPreview = new System.Windows.Forms.PictureBox();
            this.comboBoxInstalledFont = new System.Windows.Forms.ComboBox();
            this.textBoxUserFont = new System.Windows.Forms.TextBox();
            this.buttonSelectFont = new System.Windows.Forms.Button();
            this.openFileDialogSelectFontFile = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorkerGenerateFontBitmap = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialogSelectExportFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStripMain.SuspendLayout();
            this.panelPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelFontSettings.SuspendLayout();
            this.groupBoxOption.SuspendLayout();
            this.groupBoxCodeArea.SuspendLayout();
            this.groupBoxFontDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundColorPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextColorPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.helpHToolStripMenuItem});
            resources.ApplyResources(this.menuStripMain, "menuStripMain");
            this.menuStripMain.Name = "menuStripMain";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExportFile});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            resources.ApplyResources(this.fileFToolStripMenuItem, "fileFToolStripMenuItem");
            // 
            // toolStripMenuItemExportFile
            // 
            this.toolStripMenuItemExportFile.Image = global::BitmapFontGenerator.Properties.Resources.application_put;
            this.toolStripMenuItemExportFile.Name = "toolStripMenuItemExportFile";
            resources.ApplyResources(this.toolStripMenuItemExportFile, "toolStripMenuItemExportFile");
            this.toolStripMenuItemExportFile.Click += new System.EventHandler(this.toolStripMenuItemExportFile_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            resources.ApplyResources(this.helpHToolStripMenuItem, "helpHToolStripMenuItem");
            // 
            // statusStripMain
            // 
            resources.ApplyResources(this.statusStripMain, "statusStripMain");
            this.statusStripMain.Name = "statusStripMain";
            // 
            // panelPreview
            // 
            resources.ApplyResources(this.panelPreview, "panelPreview");
            this.panelPreview.Controls.Add(this.pictureBoxPreview);
            this.panelPreview.Name = "panelPreview";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBoxPreview, "pictureBoxPreview");
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.TabStop = false;
            this.pictureBoxPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPreview_Paint);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.splitContainerMain, "splitContainerMain");
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.panelPreview);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.panelFontSettings);
            this.splitContainerMain.TabStop = false;
            // 
            // panelFontSettings
            // 
            this.panelFontSettings.Controls.Add(this.groupBoxOption);
            this.panelFontSettings.Controls.Add(this.groupBoxCodeArea);
            this.panelFontSettings.Controls.Add(this.buttonExportFile);
            this.panelFontSettings.Controls.Add(this.groupBoxFontDetails);
            resources.ApplyResources(this.panelFontSettings, "panelFontSettings");
            this.panelFontSettings.Name = "panelFontSettings";
            // 
            // groupBoxOption
            // 
            resources.ApplyResources(this.groupBoxOption, "groupBoxOption");
            this.groupBoxOption.Controls.Add(this.checkBoxShowGrid);
            this.groupBoxOption.Name = "groupBoxOption";
            this.groupBoxOption.TabStop = false;
            // 
            // checkBoxShowGrid
            // 
            resources.ApplyResources(this.checkBoxShowGrid, "checkBoxShowGrid");
            this.checkBoxShowGrid.Name = "checkBoxShowGrid";
            this.checkBoxShowGrid.UseVisualStyleBackColor = true;
            this.checkBoxShowGrid.CheckedChanged += new System.EventHandler(this.checkBoxShowGrid_CheckedChanged);
            // 
            // groupBoxCodeArea
            // 
            resources.ApplyResources(this.groupBoxCodeArea, "groupBoxCodeArea");
            this.groupBoxCodeArea.Controls.Add(this.checkBoxDrawJIS2Kanji);
            this.groupBoxCodeArea.Controls.Add(this.checkBoxDrawJIS1Kanji);
            this.groupBoxCodeArea.Controls.Add(this.checkBoxDrawPlatformDependent);
            this.groupBoxCodeArea.Controls.Add(this.checkBoxDrawZenkaku);
            this.groupBoxCodeArea.Controls.Add(this.checkBoxDrawHankaku);
            this.groupBoxCodeArea.Name = "groupBoxCodeArea";
            this.groupBoxCodeArea.TabStop = false;
            // 
            // checkBoxDrawJIS2Kanji
            // 
            resources.ApplyResources(this.checkBoxDrawJIS2Kanji, "checkBoxDrawJIS2Kanji");
            this.checkBoxDrawJIS2Kanji.Name = "checkBoxDrawJIS2Kanji";
            this.checkBoxDrawJIS2Kanji.UseVisualStyleBackColor = true;
            this.checkBoxDrawJIS2Kanji.CheckedChanged += new System.EventHandler(this.checkBoxDrawFlag_CheckedChanged);
            // 
            // checkBoxDrawJIS1Kanji
            // 
            resources.ApplyResources(this.checkBoxDrawJIS1Kanji, "checkBoxDrawJIS1Kanji");
            this.checkBoxDrawJIS1Kanji.Name = "checkBoxDrawJIS1Kanji";
            this.checkBoxDrawJIS1Kanji.UseVisualStyleBackColor = true;
            this.checkBoxDrawJIS1Kanji.CheckedChanged += new System.EventHandler(this.checkBoxDrawFlag_CheckedChanged);
            // 
            // checkBoxDrawPlatformDependent
            // 
            resources.ApplyResources(this.checkBoxDrawPlatformDependent, "checkBoxDrawPlatformDependent");
            this.checkBoxDrawPlatformDependent.Name = "checkBoxDrawPlatformDependent";
            this.checkBoxDrawPlatformDependent.UseVisualStyleBackColor = true;
            this.checkBoxDrawPlatformDependent.CheckedChanged += new System.EventHandler(this.checkBoxDrawFlag_CheckedChanged);
            // 
            // checkBoxDrawZenkaku
            // 
            resources.ApplyResources(this.checkBoxDrawZenkaku, "checkBoxDrawZenkaku");
            this.checkBoxDrawZenkaku.Name = "checkBoxDrawZenkaku";
            this.checkBoxDrawZenkaku.UseVisualStyleBackColor = true;
            this.checkBoxDrawZenkaku.CheckedChanged += new System.EventHandler(this.checkBoxDrawFlag_CheckedChanged);
            // 
            // checkBoxDrawHankaku
            // 
            resources.ApplyResources(this.checkBoxDrawHankaku, "checkBoxDrawHankaku");
            this.checkBoxDrawHankaku.Name = "checkBoxDrawHankaku";
            this.checkBoxDrawHankaku.UseVisualStyleBackColor = true;
            this.checkBoxDrawHankaku.CheckedChanged += new System.EventHandler(this.checkBoxDrawFlag_CheckedChanged);
            // 
            // buttonExportFile
            // 
            resources.ApplyResources(this.buttonExportFile, "buttonExportFile");
            this.buttonExportFile.Image = global::BitmapFontGenerator.Properties.Resources.application_put;
            this.buttonExportFile.Name = "buttonExportFile";
            this.buttonExportFile.UseVisualStyleBackColor = true;
            this.buttonExportFile.Click += new System.EventHandler(this.buttonExportFile_Click);
            // 
            // groupBoxFontDetails
            // 
            resources.ApplyResources(this.groupBoxFontDetails, "groupBoxFontDetails");
            this.groupBoxFontDetails.Controls.Add(this.radioButtonAlignRight);
            this.groupBoxFontDetails.Controls.Add(this.radioButtonAlignCenter);
            this.groupBoxFontDetails.Controls.Add(this.radioButtonAlignLeft);
            this.groupBoxFontDetails.Controls.Add(this.checkBoxStrikeout);
            this.groupBoxFontDetails.Controls.Add(this.checkBoxTextUnderline);
            this.groupBoxFontDetails.Controls.Add(this.checkBoxTextItalic);
            this.groupBoxFontDetails.Controls.Add(this.checkBoxEnableBackgroundTransparent);
            this.groupBoxFontDetails.Controls.Add(this.checkBoxTextBold);
            this.groupBoxFontDetails.Controls.Add(this.pictureBoxBackgroundColorPreview);
            this.groupBoxFontDetails.Controls.Add(this.numericUpDownFontSize);
            this.groupBoxFontDetails.Controls.Add(this.pictureBoxTextColorPreview);
            this.groupBoxFontDetails.Controls.Add(this.comboBoxInstalledFont);
            this.groupBoxFontDetails.Controls.Add(this.textBoxUserFont);
            this.groupBoxFontDetails.Controls.Add(this.buttonSelectFont);
            this.groupBoxFontDetails.Name = "groupBoxFontDetails";
            this.groupBoxFontDetails.TabStop = false;
            // 
            // radioButtonAlignRight
            // 
            resources.ApplyResources(this.radioButtonAlignRight, "radioButtonAlignRight");
            this.radioButtonAlignRight.Image = global::BitmapFontGenerator.Properties.Resources.text_align_right;
            this.radioButtonAlignRight.Name = "radioButtonAlignRight";
            this.radioButtonAlignRight.TabStop = true;
            this.radioButtonAlignRight.UseVisualStyleBackColor = true;
            this.radioButtonAlignRight.CheckedChanged += new System.EventHandler(this.radioButtonAlign_CheckedChanged);
            // 
            // radioButtonAlignCenter
            // 
            resources.ApplyResources(this.radioButtonAlignCenter, "radioButtonAlignCenter");
            this.radioButtonAlignCenter.Image = global::BitmapFontGenerator.Properties.Resources.text_align_center;
            this.radioButtonAlignCenter.Name = "radioButtonAlignCenter";
            this.radioButtonAlignCenter.TabStop = true;
            this.radioButtonAlignCenter.UseVisualStyleBackColor = true;
            this.radioButtonAlignCenter.CheckedChanged += new System.EventHandler(this.radioButtonAlign_CheckedChanged);
            // 
            // radioButtonAlignLeft
            // 
            resources.ApplyResources(this.radioButtonAlignLeft, "radioButtonAlignLeft");
            this.radioButtonAlignLeft.Image = global::BitmapFontGenerator.Properties.Resources.text_align_left;
            this.radioButtonAlignLeft.Name = "radioButtonAlignLeft";
            this.radioButtonAlignLeft.TabStop = true;
            this.radioButtonAlignLeft.UseVisualStyleBackColor = true;
            this.radioButtonAlignLeft.CheckedChanged += new System.EventHandler(this.radioButtonAlign_CheckedChanged);
            // 
            // checkBoxStrikeout
            // 
            resources.ApplyResources(this.checkBoxStrikeout, "checkBoxStrikeout");
            this.checkBoxStrikeout.Image = global::BitmapFontGenerator.Properties.Resources.text_strikethrough;
            this.checkBoxStrikeout.Name = "checkBoxStrikeout";
            this.checkBoxStrikeout.UseVisualStyleBackColor = true;
            this.checkBoxStrikeout.CheckedChanged += new System.EventHandler(this.checkBoxTextStyle_CheckedChanged);
            // 
            // checkBoxTextUnderline
            // 
            resources.ApplyResources(this.checkBoxTextUnderline, "checkBoxTextUnderline");
            this.checkBoxTextUnderline.Image = global::BitmapFontGenerator.Properties.Resources.text_underline;
            this.checkBoxTextUnderline.Name = "checkBoxTextUnderline";
            this.checkBoxTextUnderline.UseVisualStyleBackColor = true;
            this.checkBoxTextUnderline.CheckedChanged += new System.EventHandler(this.checkBoxTextStyle_CheckedChanged);
            // 
            // checkBoxTextItalic
            // 
            resources.ApplyResources(this.checkBoxTextItalic, "checkBoxTextItalic");
            this.checkBoxTextItalic.Image = global::BitmapFontGenerator.Properties.Resources.text_italic;
            this.checkBoxTextItalic.Name = "checkBoxTextItalic";
            this.checkBoxTextItalic.UseVisualStyleBackColor = true;
            this.checkBoxTextItalic.CheckedChanged += new System.EventHandler(this.checkBoxTextStyle_CheckedChanged);
            // 
            // checkBoxEnableBackgroundTransparent
            // 
            resources.ApplyResources(this.checkBoxEnableBackgroundTransparent, "checkBoxEnableBackgroundTransparent");
            this.checkBoxEnableBackgroundTransparent.Name = "checkBoxEnableBackgroundTransparent";
            this.checkBoxEnableBackgroundTransparent.UseVisualStyleBackColor = true;
            this.checkBoxEnableBackgroundTransparent.CheckedChanged += new System.EventHandler(this.checkBoxEnableBackgroundTransparent_CheckedChanged);
            // 
            // checkBoxTextBold
            // 
            resources.ApplyResources(this.checkBoxTextBold, "checkBoxTextBold");
            this.checkBoxTextBold.Image = global::BitmapFontGenerator.Properties.Resources.text_bold;
            this.checkBoxTextBold.Name = "checkBoxTextBold";
            this.checkBoxTextBold.UseVisualStyleBackColor = true;
            this.checkBoxTextBold.CheckedChanged += new System.EventHandler(this.checkBoxTextStyle_CheckedChanged);
            // 
            // pictureBoxBackgroundColorPreview
            // 
            this.pictureBoxBackgroundColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBoxBackgroundColorPreview, "pictureBoxBackgroundColorPreview");
            this.pictureBoxBackgroundColorPreview.Name = "pictureBoxBackgroundColorPreview";
            this.pictureBoxBackgroundColorPreview.TabStop = false;
            this.pictureBoxBackgroundColorPreview.Click += new System.EventHandler(this.pictureBoxBackgroundColorPreview_Click);
            // 
            // numericUpDownFontSize
            // 
            resources.ApplyResources(this.numericUpDownFontSize, "numericUpDownFontSize");
            this.numericUpDownFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownFontSize.ValueChanged += new System.EventHandler(this.numericUpDownFontSize_ValueChanged);
            // 
            // pictureBoxTextColorPreview
            // 
            this.pictureBoxTextColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBoxTextColorPreview, "pictureBoxTextColorPreview");
            this.pictureBoxTextColorPreview.Name = "pictureBoxTextColorPreview";
            this.pictureBoxTextColorPreview.TabStop = false;
            this.pictureBoxTextColorPreview.Click += new System.EventHandler(this.pictureBoxTextColorPreview_Click);
            // 
            // comboBoxInstalledFont
            // 
            resources.ApplyResources(this.comboBoxInstalledFont, "comboBoxInstalledFont");
            this.comboBoxInstalledFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstalledFont.FormattingEnabled = true;
            this.comboBoxInstalledFont.Name = "comboBoxInstalledFont";
            this.comboBoxInstalledFont.TextChanged += new System.EventHandler(this.comboBoxInstalledFont_TextChanged);
            // 
            // textBoxUserFont
            // 
            resources.ApplyResources(this.textBoxUserFont, "textBoxUserFont");
            this.textBoxUserFont.Name = "textBoxUserFont";
            // 
            // buttonSelectFont
            // 
            resources.ApplyResources(this.buttonSelectFont, "buttonSelectFont");
            this.buttonSelectFont.Image = global::BitmapFontGenerator.Properties.Resources.folder;
            this.buttonSelectFont.Name = "buttonSelectFont";
            this.buttonSelectFont.UseVisualStyleBackColor = true;
            this.buttonSelectFont.Click += new System.EventHandler(this.buttonSelectFont_Click);
            // 
            // openFileDialogSelectFontFile
            // 
            resources.ApplyResources(this.openFileDialogSelectFontFile, "openFileDialogSelectFontFile");
            this.openFileDialogSelectFontFile.RestoreDirectory = true;
            // 
            // backgroundWorkerGenerateFontBitmap
            // 
            this.backgroundWorkerGenerateFontBitmap.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerGenerateFontBitmap_DoWork);
            this.backgroundWorkerGenerateFontBitmap.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerGenerateFontBitmap_RunWorkerCompleted);
            // 
            // saveFileDialogSelectExportFile
            // 
            this.saveFileDialogSelectExportFile.FileName = "export";
            resources.ApplyResources(this.saveFileDialogSelectExportFile, "saveFileDialogSelectExportFile");
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panelPreview.ResumeLayout(false);
            this.panelPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelFontSettings.ResumeLayout(false);
            this.groupBoxOption.ResumeLayout(false);
            this.groupBoxOption.PerformLayout();
            this.groupBoxCodeArea.ResumeLayout(false);
            this.groupBoxCodeArea.PerformLayout();
            this.groupBoxFontDetails.ResumeLayout(false);
            this.groupBoxFontDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundColorPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextColorPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportFile;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelFontSettings;
        private System.Windows.Forms.GroupBox groupBoxFontDetails;
        private System.Windows.Forms.ComboBox comboBoxInstalledFont;
        private System.Windows.Forms.TextBox textBoxUserFont;
        private System.Windows.Forms.Button buttonSelectFont;
        private System.Windows.Forms.OpenFileDialog openFileDialogSelectFontFile;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.GroupBox groupBoxCodeArea;
        private System.Windows.Forms.CheckBox checkBoxDrawHankaku;
        private System.Windows.Forms.CheckBox checkBoxDrawPlatformDependent;
        private System.Windows.Forms.CheckBox checkBoxDrawZenkaku;
        private System.Windows.Forms.CheckBox checkBoxDrawJIS2Kanji;
        private System.Windows.Forms.CheckBox checkBoxDrawJIS1Kanji;
        private System.ComponentModel.BackgroundWorker backgroundWorkerGenerateFontBitmap;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSelectExportFile;
        private System.Windows.Forms.Button buttonExportFile;
        private System.Windows.Forms.GroupBox groupBoxOption;
        private System.Windows.Forms.PictureBox pictureBoxBackgroundColorPreview;
        private System.Windows.Forms.PictureBox pictureBoxTextColorPreview;
        private System.Windows.Forms.CheckBox checkBoxEnableBackgroundTransparent;
        private System.Windows.Forms.CheckBox checkBoxTextUnderline;
        private System.Windows.Forms.CheckBox checkBoxTextItalic;
        private System.Windows.Forms.CheckBox checkBoxTextBold;
        private System.Windows.Forms.CheckBox checkBoxStrikeout;
        private System.Windows.Forms.CheckBox checkBoxShowGrid;
        private System.Windows.Forms.RadioButton radioButtonAlignRight;
        private System.Windows.Forms.RadioButton radioButtonAlignCenter;
        private System.Windows.Forms.RadioButton radioButtonAlignLeft;
    }
}

