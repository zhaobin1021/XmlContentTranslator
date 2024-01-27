﻿namespace XmlContentTranslator
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
            this.comboBox_transForm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.listViewLanguageTags.Location = new System.Drawing.Point(255, 55);
            this.listViewLanguageTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewLanguageTags.Name = "listViewLanguageTags";
            this.listViewLanguageTags.Size = new System.Drawing.Size(652, 389);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 48);
            // 
            // translateViaGoogleToolStripMenuItem
            // 
            this.translateViaGoogleToolStripMenuItem.Name = "translateViaGoogleToolStripMenuItem";
            this.translateViaGoogleToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.translateViaGoogleToolStripMenuItem.Text = "翻译选中行";
            this.translateViaGoogleToolStripMenuItem.Click += new System.EventHandler(this.translateViaGoogleToolStripMenuItem_Click);
            // 
            // setValueFromMasterToolStripMenuItem
            // 
            this.setValueFromMasterToolStripMenuItem.Name = "setValueFromMasterToolStripMenuItem";
            this.setValueFromMasterToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.setValueFromMasterToolStripMenuItem.Text = "从原文复制内容";
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(919, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "&New";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "打开";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "保存";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "另存为";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.editToolStripMenuItem.Text = "编辑";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findToolStripMenuItem.Text = "查找";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleTranslateSelectedLinesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.toolsToolStripMenuItem.Text = "工具";
            // 
            // googleTranslateSelectedLinesToolStripMenuItem
            // 
            this.googleTranslateSelectedLinesToolStripMenuItem.Name = "googleTranslateSelectedLinesToolStripMenuItem";
            this.googleTranslateSelectedLinesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.googleTranslateSelectedLinesToolStripMenuItem.Text = "Google翻译选中行";
            this.googleTranslateSelectedLinesToolStripMenuItem.Click += new System.EventHandler(this.GoogleTranslateSelectedLinesToolStripMenuItemClick);
            // 
            // textBoxCurrentText
            // 
            this.textBoxCurrentText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentText.Location = new System.Drawing.Point(255, 450);
            this.textBoxCurrentText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCurrentText.Multiline = true;
            this.textBoxCurrentText.Name = "textBoxCurrentText";
            this.textBoxCurrentText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCurrentText.Size = new System.Drawing.Size(652, 74);
            this.textBoxCurrentText.TabIndex = 12;
            this.textBoxCurrentText.TextChanged += new System.EventHandler(this.TextBoxCurrentTextTextChanged);
            this.textBoxCurrentText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCurrentTextKeyDown);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(13, 55);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(236, 468);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(919, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(773, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(540, 31);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(35, 12);
            this.labelTo.TabIndex = 19;
            this.labelTo.Text = "译文:";
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(581, 27);
            this.comboBoxTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(121, 20);
            this.comboBoxTo.TabIndex = 18;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(360, 31);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(35, 12);
            this.labelFrom.TabIndex = 17;
            this.labelFrom.Text = "原文:";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(396, 27);
            this.comboBoxFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFrom.TabIndex = 16;
            // 
            // buttonGoToNextBlankLine
            // 
            this.buttonGoToNextBlankLine.Location = new System.Drawing.Point(197, 28);
            this.buttonGoToNextBlankLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGoToNextBlankLine.Name = "buttonGoToNextBlankLine";
            this.buttonGoToNextBlankLine.Size = new System.Drawing.Size(156, 22);
            this.buttonGoToNextBlankLine.TabIndex = 20;
            this.buttonGoToNextBlankLine.Text = "到下一个未翻译的 (F6)";
            this.buttonGoToNextBlankLine.UseVisualStyleBackColor = true;
            this.buttonGoToNextBlankLine.Click += new System.EventHandler(this.ButtonGoToNextBlankLineClick);
            // 
            // checkBox_transAttr
            // 
            this.checkBox_transAttr.AutoSize = true;
            this.checkBox_transAttr.Location = new System.Drawing.Point(120, 31);
            this.checkBox_transAttr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_transAttr.Name = "checkBox_transAttr";
            this.checkBox_transAttr.Size = new System.Drawing.Size(72, 16);
            this.checkBox_transAttr.TabIndex = 21;
            this.checkBox_transAttr.Text = "翻译属性";
            this.checkBox_transAttr.UseVisualStyleBackColor = true;
            this.checkBox_transAttr.Visible = false;
            // 
            // comboBox_transForm
            // 
            this.comboBox_transForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_transForm.FormattingEnabled = true;
            this.comboBox_transForm.Items.AddRange(new object[] {
            "Google",
            "Baidu"});
            this.comboBox_transForm.Location = new System.Drawing.Point(786, 28);
            this.comboBox_transForm.Name = "comboBox_transForm";
            this.comboBox_transForm.Size = new System.Drawing.Size(121, 20);
            this.comboBox_transForm.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "翻译来源:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_transForm);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(819, 325);
            this.Name = "Main";
            this.Text = "XML内容翻译";
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
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_transAttr;
        private System.Windows.Forms.ComboBox comboBox_transForm;
        private System.Windows.Forms.Label label1;
    }
}

