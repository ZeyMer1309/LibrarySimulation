
namespace LibrarySimulation
{
    partial class UcBook
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
            this.lblYear = new System.Windows.Forms.Label();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.lblBookName = new System.Windows.Forms.Label();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.picDiscard = new System.Windows.Forms.PictureBox();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.nupPageCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiscard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPageCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.Location = new System.Drawing.Point(45, 478);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(89, 19);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "Çıkış Tarihi";
            // 
            // dtpYear
            // 
            this.dtpYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpYear.Location = new System.Drawing.Point(167, 478);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(273, 27);
            this.dtpYear.TabIndex = 8;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookName.ForeColor = System.Drawing.Color.White;
            this.lblBookName.Location = new System.Drawing.Point(45, 386);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(80, 19);
            this.lblBookName.TabIndex = 7;
            this.lblBookName.Text = "Kitap Adı";
            // 
            // tbxBookName
            // 
            this.tbxBookName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookName.Location = new System.Drawing.Point(167, 382);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(273, 27);
            this.tbxBookName.TabIndex = 6;
            // 
            // dgvBookList
            // 
            this.dgvBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.GridColor = System.Drawing.Color.White;
            this.dgvBookList.Location = new System.Drawing.Point(49, 50);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookList.Size = new System.Drawing.Size(750, 300);
            this.dgvBookList.TabIndex = 5;
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageCount.ForeColor = System.Drawing.Color.White;
            this.lblPageCount.Location = new System.Drawing.Point(45, 432);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(98, 19);
            this.lblPageCount.TabIndex = 11;
            this.lblPageCount.Text = "Sayfa Sayısı";
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
            this.picDelete.TabIndex = 14;
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
            this.picEdit.TabIndex = 13;
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
            this.picAdd.TabIndex = 12;
            this.picAdd.TabStop = false;
            // 
            // nupPageCount
            // 
            this.nupPageCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nupPageCount.Location = new System.Drawing.Point(167, 428);
            this.nupPageCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupPageCount.Name = "nupPageCount";
            this.nupPageCount.Size = new System.Drawing.Size(273, 27);
            this.nupPageCount.TabIndex = 22;
            // 
            // UcBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.nupPageCount);
            this.Controls.Add(this.picDiscard);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.picEdit);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.dtpYear);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.tbxBookName);
            this.Controls.Add(this.dgvBookList);
            this.Name = "UcBook";
            this.Size = new System.Drawing.Size(845, 543);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiscard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPageCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.DateTimePicker dtpYear;
        public System.Windows.Forms.Label lblBookName;
        public System.Windows.Forms.TextBox tbxBookName;
        public System.Windows.Forms.DataGridView dgvBookList;
        public System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.PictureBox picDiscard;
        private System.Windows.Forms.NumericUpDown nupPageCount;
    }
}
