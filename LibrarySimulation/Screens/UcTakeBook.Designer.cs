
namespace LibrarySimulation
{
    partial class UcTakeBook
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
            this.picGive = new System.Windows.Forms.PictureBox();
            this.picTake = new System.Windows.Forms.PictureBox();
            this.dgvBooksByUsers = new System.Windows.Forms.DataGridView();
            this.lbxUsers = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksByUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // picGive
            // 
            this.picGive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGive.Image = global::LibrarySimulation.Properties.Resources.give;
            this.picGive.Location = new System.Drawing.Point(437, 380);
            this.picGive.Name = "picGive";
            this.picGive.Size = new System.Drawing.Size(96, 96);
            this.picGive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGive.TabIndex = 22;
            this.picGive.TabStop = false;
            // 
            // picTake
            // 
            this.picTake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTake.Image = global::LibrarySimulation.Properties.Resources.take;
            this.picTake.Location = new System.Drawing.Point(314, 380);
            this.picTake.Name = "picTake";
            this.picTake.Size = new System.Drawing.Size(96, 96);
            this.picTake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTake.TabIndex = 21;
            this.picTake.TabStop = false;
            // 
            // dgvBooksByUsers
            // 
            this.dgvBooksByUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooksByUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBooksByUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooksByUsers.Location = new System.Drawing.Point(275, 31);
            this.dgvBooksByUsers.Name = "dgvBooksByUsers";
            this.dgvBooksByUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooksByUsers.Size = new System.Drawing.Size(532, 292);
            this.dgvBooksByUsers.TabIndex = 18;
            // 
            // lbxUsers
            // 
            this.lbxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxUsers.FormattingEnabled = true;
            this.lbxUsers.ItemHeight = 16;
            this.lbxUsers.Location = new System.Drawing.Point(27, 31);
            this.lbxUsers.Name = "lbxUsers";
            this.lbxUsers.Size = new System.Drawing.Size(201, 292);
            this.lbxUsers.TabIndex = 17;
            // 
            // UcTakeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.picGive);
            this.Controls.Add(this.picTake);
            this.Controls.Add(this.dgvBooksByUsers);
            this.Controls.Add(this.lbxUsers);
            this.Name = "UcTakeBook";
            this.Size = new System.Drawing.Size(845, 543);
            ((System.ComponentModel.ISupportInitialize)(this.picGive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksByUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picGive;
        public System.Windows.Forms.PictureBox picTake;
        public System.Windows.Forms.DataGridView dgvBooksByUsers;
        public System.Windows.Forms.ListBox lbxUsers;
    }
}
