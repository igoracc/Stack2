﻿namespace Stack2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.categories = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showImage = new System.Windows.Forms.ToolStripButton();
            this.tsBtnImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsClipBoard = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.Izvje = new System.Windows.Forms.ToolStripButton();
            this.Password = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.btnCLipBoard = new System.Windows.Forms.Button();
            this.cbLang = new System.Windows.Forms.ComboBox();
            this.chkAllWord = new System.Windows.Forms.CheckBox();
            this.chkDetails = new System.Windows.Forms.CheckBox();
            this.chkTags = new System.Windows.Forms.CheckBox();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.rbAsc = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDetails = new FastColoredTextBoxNS.FastColoredTextBox();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.dgCategory = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCategories = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(190)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton5,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.btnSave,
            this.toolStripButton6,
            this.categories,
            this.toolStripSeparator2,
            this.showImage,
            this.tsBtnImage,
            this.toolStripSeparator3,
            this.tsClipBoard,
            this.toolStripButton4,
            this.Izvje,
            this.Password,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1309, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(53, 24);
            this.toolStripButton3.Text = "Add";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(51, 24);
            this.toolStripButton2.Text = "Edit";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 24);
            this.toolStripButton1.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 24);
            this.btnSave.Text = "Update";
            this.btnSave.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(82, 24);
            this.toolStripButton6.Text = "Open link";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // categories
            // 
            this.categories.ForeColor = System.Drawing.SystemColors.Control;
            this.categories.Image = ((System.Drawing.Image)(resources.GetObject("categories.Image")));
            this.categories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(87, 24);
            this.categories.Text = "Categories";
            this.categories.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // showImage
            // 
            this.showImage.ForeColor = System.Drawing.SystemColors.Control;
            this.showImage.Image = ((System.Drawing.Image)(resources.GetObject("showImage.Image")));
            this.showImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showImage.Name = "showImage";
            this.showImage.Size = new System.Drawing.Size(92, 24);
            this.showImage.Text = "View Image";
            this.showImage.Click += new System.EventHandler(this.toolStripButton4_Click_1);
            // 
            // tsBtnImage
            // 
            this.tsBtnImage.ForeColor = System.Drawing.SystemColors.Control;
            this.tsBtnImage.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnImage.Image")));
            this.tsBtnImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnImage.Name = "tsBtnImage";
            this.tsBtnImage.Size = new System.Drawing.Size(96, 24);
            this.tsBtnImage.Text = "Insert Image";
            this.tsBtnImage.Click += new System.EventHandler(this.tsBtnImage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsClipBoard
            // 
            this.tsClipBoard.ForeColor = System.Drawing.SystemColors.Control;
            this.tsClipBoard.Image = ((System.Drawing.Image)(resources.GetObject("tsClipBoard.Image")));
            this.tsClipBoard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClipBoard.Name = "tsClipBoard";
            this.tsClipBoard.Size = new System.Drawing.Size(53, 24);
            this.tsClipBoard.Text = "CPB";
            this.tsClipBoard.Click += new System.EventHandler(this.tsClipBoard_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(80, 24);
            this.toolStripButton4.Text = "MailSend";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click_2);
            // 
            // Izvje
            // 
            this.Izvje.ForeColor = System.Drawing.SystemColors.Control;
            this.Izvje.Image = ((System.Drawing.Image)(resources.GetObject("Izvje.Image")));
            this.Izvje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Izvje.Name = "Izvje";
            this.Izvje.Size = new System.Drawing.Size(72, 24);
            this.Izvje.Text = "Izvještaj";
            this.Izvje.Click += new System.EventHandler(this.Izvje_Click);
            // 
            // Password
            // 
            this.Password.ForeColor = System.Drawing.SystemColors.Control;
            this.Password.Image = ((System.Drawing.Image)(resources.GetObject("Password.Image")));
            this.Password.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 24);
            this.Password.Text = "PSWGEN";
            this.Password.Click += new System.EventHandler(this.toolStripButton5_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(80, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(246, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 39);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.chkName);
            this.panel4.Controls.Add(this.btnCLipBoard);
            this.panel4.Controls.Add(this.cbLang);
            this.panel4.Controls.Add(this.chkAllWord);
            this.panel4.Controls.Add(this.chkDetails);
            this.panel4.Controls.Add(this.chkTags);
            this.panel4.Controls.Add(this.rbDate);
            this.panel4.Controls.Add(this.rbAsc);
            this.panel4.Location = new System.Drawing.Point(388, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(867, 31);
            this.panel4.TabIndex = 6;
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Checked = true;
            this.chkName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkName.Location = new System.Drawing.Point(13, 7);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(54, 17);
            this.chkName.TabIndex = 7;
            this.chkName.Text = "Name";
            this.chkName.UseVisualStyleBackColor = true;
            // 
            // btnCLipBoard
            // 
            this.btnCLipBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCLipBoard.Location = new System.Drawing.Point(653, 5);
            this.btnCLipBoard.Name = "btnCLipBoard";
            this.btnCLipBoard.Size = new System.Drawing.Size(70, 20);
            this.btnCLipBoard.TabIndex = 6;
            this.btnCLipBoard.Text = "CPB OFF";
            this.btnCLipBoard.UseVisualStyleBackColor = true;
            this.btnCLipBoard.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbLang
            // 
            this.cbLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLang.FormattingEnabled = true;
            this.cbLang.Location = new System.Drawing.Point(729, 5);
            this.cbLang.Name = "cbLang";
            this.cbLang.Size = new System.Drawing.Size(123, 21);
            this.cbLang.TabIndex = 3;
            this.cbLang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chkAllWord
            // 
            this.chkAllWord.AutoSize = true;
            this.chkAllWord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkAllWord.Location = new System.Drawing.Point(193, 7);
            this.chkAllWord.Name = "chkAllWord";
            this.chkAllWord.Size = new System.Drawing.Size(68, 17);
            this.chkAllWord.TabIndex = 5;
            this.chkAllWord.Text = "All words";
            this.chkAllWord.UseVisualStyleBackColor = true;
            // 
            // chkDetails
            // 
            this.chkDetails.AutoSize = true;
            this.chkDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkDetails.Location = new System.Drawing.Point(129, 7);
            this.chkDetails.Name = "chkDetails";
            this.chkDetails.Size = new System.Drawing.Size(58, 17);
            this.chkDetails.TabIndex = 4;
            this.chkDetails.Text = "Details";
            this.chkDetails.UseVisualStyleBackColor = true;
            // 
            // chkTags
            // 
            this.chkTags.AutoSize = true;
            this.chkTags.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkTags.Location = new System.Drawing.Point(73, 7);
            this.chkTags.Name = "chkTags";
            this.chkTags.Size = new System.Drawing.Size(50, 17);
            this.chkTags.TabIndex = 3;
            this.chkTags.Text = "Tags";
            this.chkTags.UseVisualStyleBackColor = true;
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.Checked = true;
            this.rbDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbDate.Location = new System.Drawing.Point(404, 7);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(48, 17);
            this.rbDate.TabIndex = 2;
            this.rbDate.TabStop = true;
            this.rbDate.Text = "Date";
            this.rbDate.UseVisualStyleBackColor = true;
            this.rbDate.CheckedChanged += new System.EventHandler(this.rbDate_CheckedChanged);
            // 
            // rbAsc
            // 
            this.rbAsc.AutoSize = true;
            this.rbAsc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbAsc.Location = new System.Drawing.Point(352, 7);
            this.rbAsc.Name = "rbAsc";
            this.rbAsc.Size = new System.Drawing.Size(46, 17);
            this.rbAsc.TabIndex = 1;
            this.rbAsc.Text = "ASC";
            this.rbAsc.UseVisualStyleBackColor = true;
            this.rbAsc.CheckedChanged += new System.EventHandler(this.rbAsc_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(332, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 20);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.txtDetails);
            this.panel2.Controls.Add(this.txtTags);
            this.panel2.Controls.Add(this.dgItems);
            this.panel2.Controls.Add(this.dgCategory);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1309, 578);
            this.panel2.TabIndex = 3;
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetails.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtDetails.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:" +
    "]*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.txtDetails.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtDetails.BackBrush = null;
            this.txtDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.txtDetails.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtDetails.CharHeight = 14;
            this.txtDetails.CharWidth = 8;
            this.txtDetails.CurrentLineColor = System.Drawing.Color.Gainsboro;
            this.txtDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetails.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtDetails.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtDetails.ForeColor = System.Drawing.Color.Yellow;
            this.txtDetails.IsReplaceMode = false;
            this.txtDetails.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txtDetails.LeftBracket = '(';
            this.txtDetails.LeftBracket2 = '{';
            this.txtDetails.Location = new System.Drawing.Point(361, 3);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Paddings = new System.Windows.Forms.Padding(0);
            this.txtDetails.RightBracket = ')';
            this.txtDetails.RightBracket2 = '}';
            this.txtDetails.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtDetails.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtDetails.ServiceColors")));
            this.txtDetails.Size = new System.Drawing.Size(945, 546);
            this.txtDetails.TabIndex = 4;
            this.txtDetails.Zoom = 100;
            this.txtDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDetails_KeyDown);
            // 
            // txtTags
            // 
            this.txtTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTags.Location = new System.Drawing.Point(361, 555);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(945, 20);
            this.txtTags.TabIndex = 3;
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgItems.AutoGenerateColumns = false;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID1,
            this.ItemName,
            this.img});
            this.dgItems.DataSource = this.bsItems;
            this.dgItems.Location = new System.Drawing.Point(182, 3);
            this.dgItems.Name = "dgItems";
            this.dgItems.ReadOnly = true;
            this.dgItems.RowHeadersWidth = 5;
            this.dgItems.Size = new System.Drawing.Size(173, 575);
            this.dgItems.TabIndex = 1;
            this.dgItems.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgItems_DataError);
            this.dgItems.SelectionChanged += new System.EventHandler(this.dgItems_SelectionChanged_1);
            // 
            // ID1
            // 
            this.ID1.DataPropertyName = "id";
            this.ID1.HeaderText = "ID";
            this.ID1.MinimumWidth = 6;
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Visible = false;
            this.ID1.Width = 125;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.DataPropertyName = "Name";
            this.ItemName.HeaderText = "Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // img
            // 
            this.img.DataPropertyName = "isImage";
            this.img.HeaderText = "IsImage";
            this.img.MinimumWidth = 6;
            this.img.Name = "img";
            this.img.ReadOnly = true;
            this.img.Visible = false;
            this.img.Width = 125;
            // 
            // bsItems
            // 
            this.bsItems.CurrentChanged += new System.EventHandler(this.bsItems_CurrentChanged);
            this.bsItems.PositionChanged += new System.EventHandler(this.bsItems_PositionChanged);
            // 
            // dgCategory
            // 
            this.dgCategory.AllowUserToAddRows = false;
            this.dgCategory.AllowUserToDeleteRows = false;
            this.dgCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgCategory.AutoGenerateColumns = false;
            this.dgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nam});
            this.dgCategory.DataSource = this.bsCategories;
            this.dgCategory.Location = new System.Drawing.Point(3, 3);
            this.dgCategory.Name = "dgCategory";
            this.dgCategory.ReadOnly = true;
            this.dgCategory.RowHeadersWidth = 10;
            this.dgCategory.Size = new System.Drawing.Size(173, 575);
            this.dgCategory.TabIndex = 0;
            this.dgCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategory_CellContentClick);
            this.dgCategory.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgCategory_DataError);
            this.dgCategory.SelectionChanged += new System.EventHandler(this.dgCategory_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // Nam
            // 
            this.Nam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nam.DataPropertyName = "Name";
            this.Nam.HeaderText = "Name";
            this.Nam.MinimumWidth = 6;
            this.Nam.Name = "Nam";
            this.Nam.ReadOnly = true;
            // 
            // bsCategories
            // 
            this.bsCategories.CurrentChanged += new System.EventHandler(this.bsCategories_CurrentChanged);
            this.bsCategories.PositionChanged += new System.EventHandler(this.bsCategories_PositionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(361, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(945, 546);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(78, 24);
            this.toolStripButton5.Text = "Add CPB";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click_3);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1309, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stack 2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.DataGridView dgCategory;
        private System.Windows.Forms.ComboBox cbLang;
        private System.Windows.Forms.TextBox txtTags;
        public System.Windows.Forms.BindingSource bsItems;
        public System.Windows.Forms.BindingSource bsCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton categories;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbDate;
        private System.Windows.Forms.RadioButton rbAsc;
        private System.Windows.Forms.CheckBox chkDetails;
        private System.Windows.Forms.CheckBox chkTags;
        private FastColoredTextBoxNS.FastColoredTextBox txtDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn img;
        private System.Windows.Forms.CheckBox chkAllWord;
        private System.Windows.Forms.Button btnCLipBoard;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton showImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsClipBoard;
        private System.Windows.Forms.CheckBox chkName;
        private System.Windows.Forms.ToolStripButton Password;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton Izvje;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}