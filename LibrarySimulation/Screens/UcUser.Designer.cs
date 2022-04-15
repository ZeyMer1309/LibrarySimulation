
namespace LibrarySimulation
{
    partial class UcUser
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
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.dtpCreationDate = new System.Windows.Forms.DateTimePicker();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.picDiscard = new System.Windows.Forms.PictureBox();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiscard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserList
            // 
            this.dgvUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.GridColor = System.Drawing.Color.White;
            this.dgvUserList.Location = new System.Drawing.Point(49, 50);
            this.dgvUserList.MultiSelect = false;
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserList.Size = new System.Drawing.Size(750, 300);
            this.dgvUserList.TabIndex = 0;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserName.Location = new System.Drawing.Point(167, 405);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(273, 27);
            this.tbxUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(45, 409);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(107, 19);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Kullanıcı Adı";
            // 
            // dtpCreationDate
            // 
            this.dtpCreationDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCreationDate.Location = new System.Drawing.Point(167, 450);
            this.dtpCreationDate.Name = "dtpCreationDate";
            this.dtpCreationDate.Size = new System.Drawing.Size(273, 27);
            this.dtpCreationDate.TabIndex = 3;
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCreationDate.ForeColor = System.Drawing.Color.White;
            this.lblCreationDate.Location = new System.Drawing.Point(45, 456);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(92, 19);
            this.lblCreationDate.TabIndex = 4;
            this.lblCreationDate.Text = "Kayıt Tarihi";
            // 
            // picDiscard
            // 
            this.picDiscard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDiscard.Image = global::LibrarySimulation.Properties.Resources.discard;
            this.picDiscard.Location = new System.Drawing.Point(638, 393);
            this.picDiscard.Name = "picDiscard";
            this.picDiscard.Size = new System.Drawing.Size(48, 96);
            this.picDiscard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDiscard.TabIndex = 19;
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
            this.picSave.TabIndex = 18;
            this.picSave.TabStop = false;
            this.picSave.Visible = false;
            this.picSave.Click += new System.EventHandler(this.picSave_Click);
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
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
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
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // UcUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.picDiscard);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.picEdit);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.dtpCreationDate);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.dgvUserList);
            this.Name = "UcUser";
            this.Size = new System.Drawing.Size(845, 543);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiscard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvUserList;
        public System.Windows.Forms.TextBox tbxUserName;
        public System.Windows.Forms.Label lblUserName;
        public System.Windows.Forms.DateTimePicker dtpCreationDate;
        public System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox picEdit;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.PictureBox picDiscard;
    }
}
