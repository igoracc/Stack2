namespace Stack2.forms
{
    partial class frmCategories
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
            this.dgCategory = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCategories = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCategory
            // 
            this.dgCategory.AutoGenerateColumns = false;
            this.dgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Name});
            this.dgCategory.DataSource = this.bsCategories;
            this.dgCategory.Location = new System.Drawing.Point(12, 38);
            this.dgCategory.Name = "dgCategory";
            this.dgCategory.Size = new System.Drawing.Size(541, 206);
            this.dgCategory.TabIndex = 0;
            this.dgCategory.SelectionChanged += new System.EventHandler(this.dgCategory_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "name";
            this.Name.HeaderText = "Category name";
            this.Name.Name = "Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(113, 312);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 260);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(377, 20);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(113, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 20);
            this.txtSearch.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgCategory);
            this.MinimizeBox = false;
            ///this.Name = "frmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bsCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    }
}