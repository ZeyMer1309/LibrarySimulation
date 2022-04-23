
namespace LibrarySimulation.Screens
{
    partial class UcBookCategory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxCategoryTypes = new System.Windows.Forms.ListBox();
            this.dgvBooksByCategories = new System.Windows.Forms.DataGridView();
            this.lbxBooks = new System.Windows.Forms.ListBox();
            this.lbxCategories = new System.Windows.Forms.ListBox();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksByCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxCategoryTypes
            // 
            this.lbxCategoryTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxCategoryTypes.FormattingEnabled = true;
            this.lbxCategoryTypes.ItemHeight = 16;
            this.lbxCategoryTypes.Location = new System.Drawing.Point(27, 31);
            this.lbxCategoryTypes.Name = "lbxCategoryTypes";
            this.lbxCategoryTypes.Size = new System.Drawing.Size(201, 228);
            this.lbxCategoryTypes.TabIndex = 0;
            // 
            // dgvBooksByCategories
            // 
            this.dgvBooksByCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBooksByCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooksByCategories.Location = new System.Drawing.Point(275, 31);
            this.dgvBooksByCategories.Name = "dgvBooksByCategories";
            this.dgvBooksByCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooksByCategories.Size = new System.Drawing.Size(532, 228);
            this.dgvBooksByCategories.TabIndex = 1;
            // 
            // lbxBooks
            // 
            this.lbxBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxBooks.FormattingEnabled = true;
            this.lbxBooks.ItemHeight = 16;
            this.lbxBooks.Location = new System.Drawing.Point(27, 314);
            this.lbxBooks.Name = "lbxBooks";
            this.lbxBooks.Size = new System.Drawing.Size(201, 196);
            this.lbxBooks.TabIndex = 2;
            // 
            // lbxCategories
            // 
            this.lbxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxCategories.FormattingEnabled = true;
            this.lbxCategories.ItemHeight = 16;
            this.lbxCategories.Location = new System.Drawing.Point(275, 314);
            this.lbxCategories.Name = "lbxCategories";
            this.lbxCategories.Size = new System.Drawing.Size(201, 196);
            this.lbxCategories.TabIndex = 3;
            // 
            // picBack
            // 
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBack.Image = global::LibrarySimulation.Properties.Resources.back;
            this.picBack.Location = new System.Drawing.Point(663, 359);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(96, 96);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 16;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // picEdit
            // 
            this.picEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEdit.Image = global::LibrarySimulation.Properties.Resources.edit;
            this.picEdit.Location = new System.Drawing.Point(540, 359);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(96, 96);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEdit.TabIndex = 15;
            this.picEdit.TabStop = false;
            // 
            // UcBookCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.picEdit);
            this.Controls.Add(this.lbxCategories);
            this.Controls.Add(this.lbxBooks);
            this.Controls.Add(this.dgvBooksByCategories);
            this.Controls.Add(this.lbxCategoryTypes);
            this.Name = "UcBookCategory";
            this.Size = new System.Drawing.Size(845, 543);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksByCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbxCategoryTypes;
        public System.Windows.Forms.DataGridView dgvBooksByCategories;
        public System.Windows.Forms.ListBox lbxBooks;
        public System.Windows.Forms.ListBox lbxCategories;
        public System.Windows.Forms.PictureBox picBack;
        public System.Windows.Forms.PictureBox picEdit;
    }
}
