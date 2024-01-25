namespace XmlContentTranslator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listViewLanguageTags = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.translateViaGoogleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setValueFromMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleTranslateSelectedLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxCurrentText = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelTo = new System.Windows.Forms.Label();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.buttonGoToNextBlankLine = new System.Windows.Forms.Button();
            this.checkBox_transAttr = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewLanguageTags
            // 
            this.listViewLanguageTags.AllowDrop = true;
            this.listViewLanguageTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewLanguageTags.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewLanguageTags.FullRowSelect = true;
            this.listViewLanguageTags.HideSelection = false;
            this.listViewLanguageTags.Location = new System.Drawing.Point(340, 69);
            this.listViewLanguageTags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewLanguageTags.Name = "listViewLanguageTags";
            this.listViewLanguageTags.Size = new System.Drawing.Size(868, 485);
            this.listViewLanguageTags.TabIndex = 10;
            this.listViewLanguageTags.UseCompatibleStateImageBehavior = false;
            this.listViewLanguageTags.View = System.Windows.Forms.View.Details;
            this.listViewLanguageTags.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewLanguageTags_ColumnClick);
            this.listViewLanguageTags.SelectedIndexChanged += new System.EventHandler(this.ListViewLanguageTagsSelectedIndexChanged);
            this.listViewLanguageTags.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListViewLanguageTagsDragDrop);
            this.listViewLanguageTags.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListViewLanguageTagsDragEnter);
            this.listViewLanguageTags.DoubleClick += new System.EventHandler(this.listViewLanguageTags_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.translateViaGoogleToolStripMenuItem,
            this.setValueFromMasterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(273, 52);
            // 
            // translateViaGoogleToolStripMenuItem
            // 
            this.translateViaGoogleToolStripMenuItem.Name = "translateViaGoogleToolStripMenuItem";
            this.translateViaGoogleToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.translateViaGoogleToolStripMenuItem.Text = "Translate via google";
            this.translateViaGoogleToolStripMenuItem.Click += new System.EventHandler(this.translateViaGoogleToolStripMenuItem_Click);
            // 
            // setValueFromMasterToolStripMenuItem
            // 
            this.setValueFromMasterToolStripMenuItem.Name = "setValueFromMasterToolStripMenuItem";
            this.setValueFromMasterToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.setValueFromMasterToolStripMenuItem.Text = "Transfer value from master";
            this.setValueFromMasterToolStripMenuItem.Click += new System.EventHandler(this.setValueFromMasterToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1225, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(460, 26);
            this.toolStripMenuItem1.Text = "&New";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(460, 26);
            this.openToolStripMenuItem.Text = "打开";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(460, 26);
            this.toolStripMenuItem2.Text = "Open Subtitle Edit English translation base online...";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(460, 26);
            this.saveToolStripMenuItem.Text = "保存";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(460, 26);
            this.saveAsToolStripMenuItem.Text = "另存为";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(457, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(460, 26);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.editToolStripMenuItem.Text = "编辑";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.findToolStripMenuItem.Text = "查找";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleTranslateSelectedLinesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.toolsToolStripMenuItem.Text = "工具";
            // 
            // googleTranslateSelectedLinesToolStripMenuItem
            // 
            this.googleTranslateSelectedLinesToolStripMenuItem.Name = "googleTranslateSelectedLinesToolStripMenuItem";
            this.googleTranslateSelectedLinesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.googleTranslateSelectedLinesToolStripMenuItem.Text = "Google翻译选中行";
            this.googleTranslateSelectedLinesToolStripMenuItem.Click += new System.EventHandler(this.GoogleTranslateSelectedLinesToolStripMenuItemClick);
            // 
            // textBoxCurrentText
            // 
            this.textBoxCurrentText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentText.Location = new System.Drawing.Point(340, 562);
            this.textBoxCurrentText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCurrentText.Multiline = true;
            this.textBoxCurrentText.Name = "textBoxCurrentText";
            this.textBoxCurrentText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCurrentText.Size = new System.Drawing.Size(868, 92);
            this.textBoxCurrentText.TabIndex = 12;
            this.textBoxCurrentText.TextChanged += new System.EventHandler(this.TextBoxCurrentTextTextChanged);
            this.textBoxCurrentText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCurrentTextKeyDown);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(17, 69);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(313, 584);
            this.treeView1.TabIndex = 13;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1AfterSelect);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 657);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1225, 26);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(1038, 20);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(852, 42);
            this.labelTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(45, 15);
            this.labelTo.TabIndex = 19;
            this.labelTo.Text = "译文:";
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(905, 38);
            this.comboBoxTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(160, 23);
            this.comboBoxTo.TabIndex = 18;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(600, 42);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(45, 15);
            this.labelFrom.TabIndex = 17;
            this.labelFrom.Text = "原文:";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(648, 38);
            this.comboBoxFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(160, 23);
            this.comboBoxFrom.TabIndex = 16;
            // 
            // buttonGoToNextBlankLine
            // 
            this.buttonGoToNextBlankLine.Location = new System.Drawing.Point(341, 36);
            this.buttonGoToNextBlankLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGoToNextBlankLine.Name = "buttonGoToNextBlankLine";
            this.buttonGoToNextBlankLine.Size = new System.Drawing.Size(208, 27);
            this.buttonGoToNextBlankLine.TabIndex = 20;
            this.buttonGoToNextBlankLine.Text = "到下一个未翻译的 (F6)";
            this.buttonGoToNextBlankLine.UseVisualStyleBackColor = true;
            this.buttonGoToNextBlankLine.Click += new System.EventHandler(this.ButtonGoToNextBlankLineClick);
            // 
            // checkBox_transAttr
            // 
            this.checkBox_transAttr.AutoSize = true;
            this.checkBox_transAttr.Location = new System.Drawing.Point(216, 37);
            this.checkBox_transAttr.Name = "checkBox_transAttr";
            this.checkBox_transAttr.Size = new System.Drawing.Size(89, 19);
            this.checkBox_transAttr.TabIndex = 21;
            this.checkBox_transAttr.Text = "翻译属性";
            this.checkBox_transAttr.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 683);
            this.Controls.Add(this.checkBox_transAttr);
            this.Controls.Add(this.buttonGoToNextBlankLine);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBoxCurrentText);
            this.Controls.Add(this.listViewLanguageTags);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1087, 397);
            this.Name = "Main";
            this.Text = "XML Content Translator 1.12";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1FormClosing);
            this.Load += new System.EventHandler(this.Form1Load);
            this.ResizeEnd += new System.EventHandler(this.Main_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1KeyDown);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewLanguageTags;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxCurrentText;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleTranslateSelectedLinesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setValueFromMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translateViaGoogleToolStripMenuItem;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.Button buttonGoToNextBlankLine;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_transAttr;
    }
}

