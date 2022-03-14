
namespace LibrarySimulation
{
    partial class UcInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcInfo));
            this.picDeveloper = new System.Windows.Forms.PictureBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picProgramInfo = new System.Windows.Forms.PictureBox();
            this.lblProgramInfo = new System.Windows.Forms.Label();
            this.picGitHub = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDeveloper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProgramInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).BeginInit();
            this.SuspendLayout();
            // 
            // picDeveloper
            // 
            this.picDeveloper.Image = global::LibrarySimulation.Properties.Resources.development;
            this.picDeveloper.Location = new System.Drawing.Point(50, 86);
            this.picDeveloper.Name = "picDeveloper";
            this.picDeveloper.Size = new System.Drawing.Size(144, 140);
            this.picDeveloper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDeveloper.TabIndex = 0;
            this.picDeveloper.TabStop = false;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeveloper.ForeColor = System.Drawing.Color.White;
            this.lblDeveloper.Location = new System.Drawing.Point(200, 160);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(337, 46);
            this.lblDeveloper.TabIndex = 1;
            this.lblDeveloper.Text = "Ömer Gürbüz\r\nTurkcell Geleceği Yazanlar Ödevi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hakkında";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::LibrarySimulation.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(581, 86);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 140);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // picProgramInfo
            // 
            this.picProgramInfo.Image = global::LibrarySimulation.Properties.Resources.art_and_design;
            this.picProgramInfo.Location = new System.Drawing.Point(50, 308);
            this.picProgramInfo.Name = "picProgramInfo";
            this.picProgramInfo.Size = new System.Drawing.Size(144, 140);
            this.picProgramInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProgramInfo.TabIndex = 4;
            this.picProgramInfo.TabStop = false;
            // 
            // lblProgramInfo
            // 
            this.lblProgramInfo.AutoSize = true;
            this.lblProgramInfo.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProgramInfo.ForeColor = System.Drawing.Color.White;
            this.lblProgramInfo.Location = new System.Drawing.Point(200, 309);
            this.lblProgramInfo.Name = "lblProgramInfo";
            this.lblProgramInfo.Size = new System.Drawing.Size(469, 138);
            this.lblProgramInfo.TabIndex = 5;
            this.lblProgramInfo.Text = resources.GetString("lblProgramInfo.Text");
            // 
            // picGitHub
            // 
            this.picGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGitHub.Image = global::LibrarySimulation.Properties.Resources.github;
            this.picGitHub.Location = new System.Drawing.Point(692, 364);
            this.picGitHub.Name = "picGitHub";
            this.picGitHub.Size = new System.Drawing.Size(89, 84);
            this.picGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGitHub.TabIndex = 6;
            this.picGitHub.TabStop = false;
            this.picGitHub.Click += new System.EventHandler(this.picGitHub_Click);
            // 
            // UcInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.picGitHub);
            this.Controls.Add(this.lblProgramInfo);
            this.Controls.Add(this.picProgramInfo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.picDeveloper);
            this.Name = "UcInfo";
            this.Size = new System.Drawing.Size(845, 543);
            ((System.ComponentModel.ISupportInitialize)(this.picDeveloper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProgramInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDeveloper;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picProgramInfo;
        private System.Windows.Forms.Label lblProgramInfo;
        private System.Windows.Forms.PictureBox picGitHub;
    }
}
