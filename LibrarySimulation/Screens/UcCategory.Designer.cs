
namespace LibrarySimulation
{
    partial class UcCategory
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbxCategory = new System.Windows.Forms.TextBox();
            this.dgvCategoryList = new System.Windows.Forms.DataGridView();
            this.picDiscard = new System.Windows.Forms.PictureBox();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiscard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(45, 431);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(74, 19);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Kategori";
            // 
            // tbxCategory
            // 
            this.tbxCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCategory.Location = new System.Drawing.Point(130, 427);
            this.tbxCategory.Name = "tbxCategory";
            this.tbxCategory.Size = new System.Drawing.Size(273, 27);
            this.tbxCategory.TabIndex = 6;
            // 
            // dgvCategoryList
            // 
            this.dgvCategoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryList.GridColor = System.Drawing.Color.White;
            this.dgvCategoryList.Location = new System.Drawing.Point(49, 50);
            this.dgvCategoryList.Name = "dgvCategoryList";
            this.dgvCategoryList.ReadOnly = true;
            this.dgvCategoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoryList.Size = new System.Drawing.Size(750, 300);
            this.dgvCategoryList.TabIndex = 5;
            // 
            // picDiscard
            // 
            this.picDiscard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDiscard.Image = global::LibrarySimulation.Properties.Resources.discard;
            this.picDiscard.Location = new System.Drawing.Point(638, 393);
            this.picDiscard.Name = "picDiscard";
            this.picDiscard.Size = new System.Drawing.Size(48, 96);
            this.picDiscard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDiscard.TabIndex = 21;
            this.picDiscard.TabStop = false;
            this.picDiscard.Visible = false;
            this.picDiscard.Click += new System.EventHandler(this.picDiscard_Click);
            // 
            // picSave
            // 
            this.picSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSave.Image = global::LibrarySimulation.Properties.Resources.save;
            this.picSave.Location = new System.Drawing.Point(590, 393);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(48, 96);
            this.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSave.TabIndex = 20;
            this.picSave.TabStop = false;
            this.picSave.Visible = false;
            // 
            // picDelete
            // 
            this.picDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDelete.Image = global::LibrarySimulation.Properties.Resources.delete;
            this.picDelete.Location = new System.Drawing.Point(703, 393);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(96, 96);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 17;
            this.picDelete.TabStop = false;
            // 
            // picEdit
            // 
            this.picEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEdit.Image = global::LibrarySimulation.Properties.Resources.edit;
            this.picEdit.Location = new System.Drawing.Point(590, 393);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(96, 96);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEdit.TabIndex = 16;
            this.picEdit.TabStop = false;
            this.picEdit.Click += new System.EventHandler(this.picEdit_Click);
            // 
            // picAdd
            // 
            this.picAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdd.Image = global::LibrarySimulation.Properties.Resources.add;
            this.picAdd.Location = new System.Drawing.Point(477, 393);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(96, 96);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdd.TabIndex = 15;
            this.picAdd.TabStop = false;
            // 
            // UcCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.picDiscard);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.picEdit);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.tbxCategory);
            this.Controls.Add(this.dgvCategoryList);
            this.Name = "UcCategory";
            this.Size = new System.Drawing.Size(845, 543);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiscard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.TextBox tbxCategory;
        public System.Windows.Forms.DataGridView dgvCategoryList;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.PictureBox picDiscard;
    }
}
