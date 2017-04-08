namespace BitmapFontGenerator
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
            this.exportEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelFontSettings = new System.Windows.Forms.Panel();
            this.groupBoxCodeArea = new System.Windows.Forms.GroupBox();
            this.checkBoxDrawJIS2Kanji = new System.Windows.Forms.CheckBox();
            this.checkBoxDrawJIS1Kanji = new System.Windows.Forms.CheckBox();
            this.checkBoxDrawPlatformDependent = new System.Windows.Forms.CheckBox();
            this.checkBoxDrawZenkaku = new System.Windows.Forms.CheckBox();
            this.checkBoxDrawHankaku = new System.Windows.Forms.CheckBox();
            this.groupBoxFontSize = new System.Windows.Forms.GroupBox();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.groupBoxFont = new System.Windows.Forms.GroupBox();
            this.comboBoxInstalledFont = new System.Windows.Forms.ComboBox();
            this.textBoxUserFont = new System.Windows.Forms.TextBox();
            this.buttonSelectFont = new System.Windows.Forms.Button();
            this.openFileDialogSelectFont = new System.Windows.Forms.OpenFileDialog();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.panelPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelFontSettings.SuspendLayout();
            this.groupBoxCodeArea.SuspendLayout();
            this.groupBoxFontSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            this.groupBoxFont.SuspendLayout();
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
            this.exportEToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            resources.ApplyResources(this.fileFToolStripMenuItem, "fileFToolStripMenuItem");
            // 
            // exportEToolStripMenuItem
            // 
            this.exportEToolStripMenuItem.Name = "exportEToolStripMenuItem";
            resources.ApplyResources(this.exportEToolStripMenuItem, "exportEToolStripMenuItem");
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
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBoxPreview, "pictureBoxPreview");
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.TabStop = false;
            // 
            // panelPreview
            // 
            resources.ApplyResources(this.panelPreview, "panelPreview");
            this.panelPreview.Controls.Add(this.pictureBoxPreview);
            this.panelPreview.Name = "panelPreview";
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
            this.panelFontSettings.Controls.Add(this.groupBoxCodeArea);
            this.panelFontSettings.Controls.Add(this.groupBoxFontSize);
            this.panelFontSettings.Controls.Add(this.groupBoxFont);
            resources.ApplyResources(this.panelFontSettings, "panelFontSettings");
            this.panelFontSettings.Name = "panelFontSettings";
            // 
            // groupBoxCodeArea
            // 
            this.groupBoxCodeArea.Controls.Add(this.checkBoxDrawJIS2Kanji);
            this.groupBoxCodeArea.Controls.Add(this.checkBoxDrawJIS1Kanji);
            this.groupBoxCodeArea.Controls.Add(this.checkBoxDrawPlatformDependent);
            this.groupBoxCodeArea.Controls.Add(this.checkBoxDrawZenkaku);
            this.groupBoxCodeArea.Controls.Add(this.checkBoxDrawHankaku);
            resources.ApplyResources(this.groupBoxCodeArea, "groupBoxCodeArea");
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
            // groupBoxFontSize
            // 
            this.groupBoxFontSize.Controls.Add(this.numericUpDownFontSize);
            resources.ApplyResources(this.groupBoxFontSize, "groupBoxFontSize");
            this.groupBoxFontSize.Name = "groupBoxFontSize";
            this.groupBoxFontSize.TabStop = false;
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
            // groupBoxFont
            // 
            this.groupBoxFont.Controls.Add(this.comboBoxInstalledFont);
            this.groupBoxFont.Controls.Add(this.textBoxUserFont);
            this.groupBoxFont.Controls.Add(this.buttonSelectFont);
            resources.ApplyResources(this.groupBoxFont, "groupBoxFont");
            this.groupBoxFont.Name = "groupBoxFont";
            this.groupBoxFont.TabStop = false;
            // 
            // comboBoxInstalledFont
            // 
            this.comboBoxInstalledFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstalledFont.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxInstalledFont, "comboBoxInstalledFont");
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
            this.buttonSelectFont.Name = "buttonSelectFont";
            this.buttonSelectFont.UseVisualStyleBackColor = true;
            this.buttonSelectFont.Click += new System.EventHandler(this.buttonSelectFont_Click);
            // 
            // openFileDialogSelectFont
            // 
            resources.ApplyResources(this.openFileDialogSelectFont, "openFileDialogSelectFont");
            this.openFileDialogSelectFont.RestoreDirectory = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.panelPreview.ResumeLayout(false);
            this.panelPreview.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelFontSettings.ResumeLayout(false);
            this.groupBoxCodeArea.ResumeLayout(false);
            this.groupBoxCodeArea.PerformLayout();
            this.groupBoxFontSize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            this.groupBoxFont.ResumeLayout(false);
            this.groupBoxFont.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem exportEToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelFontSettings;
        private System.Windows.Forms.GroupBox groupBoxFont;
        private System.Windows.Forms.ComboBox comboBoxInstalledFont;
        private System.Windows.Forms.TextBox textBoxUserFont;
        private System.Windows.Forms.Button buttonSelectFont;
        private System.Windows.Forms.OpenFileDialog openFileDialogSelectFont;
        private System.Windows.Forms.GroupBox groupBoxFontSize;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.GroupBox groupBoxCodeArea;
        private System.Windows.Forms.CheckBox checkBoxDrawHankaku;
        private System.Windows.Forms.CheckBox checkBoxDrawPlatformDependent;
        private System.Windows.Forms.CheckBox checkBoxDrawZenkaku;
        private System.Windows.Forms.CheckBox checkBoxDrawJIS2Kanji;
        private System.Windows.Forms.CheckBox checkBoxDrawJIS1Kanji;
    }
}

