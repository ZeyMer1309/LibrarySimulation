
namespace LibrarySimulation
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlViewer = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnTakeBook = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pnlSidebarLine = new System.Windows.Forms.Panel();
            this.pnlWinBar = new System.Windows.Forms.Panel();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.pnlWinBarLine = new System.Windows.Forms.Panel();
            this.ucInfo = new LibrarySimulation.UcInfo();
            this.ucUser = new LibrarySimulation.UcUser();
            this.ucTakeBook = new LibrarySimulation.UcTakeBook();
            this.ucCategory = new LibrarySimulation.UcCategory();
            this.ucBook = new LibrarySimulation.UcBook();
            this.ucAuthor = new LibrarySimulation.UcAuthor();
            this.pnlMain.SuspendLayout();
            this.pnlViewer.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlWinBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnlMain.Controls.Add(this.pnlViewer);
            this.pnlMain.Controls.Add(this.pnlSidebar);
            this.pnlMain.Controls.Add(this.pnlWinBar);
            this.pnlMain.Location = new System.Drawing.Point(1, 1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1086, 613);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlViewer
            // 
            this.pnlViewer.Controls.Add(this.ucInfo);
            this.pnlViewer.Controls.Add(this.ucAuthor);
            this.pnlViewer.Controls.Add(this.ucBook);
            this.pnlViewer.Controls.Add(this.ucCategory);
            this.pnlViewer.Controls.Add(this.ucTakeBook);
            this.pnlViewer.Controls.Add(this.ucUser);
            this.pnlViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewer.Location = new System.Drawing.Point(241, 70);
            this.pnlViewer.Name = "pnlViewer";
            this.pnlViewer.Size = new System.Drawing.Size(845, 543);
            this.pnlViewer.TabIndex = 4;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlSidebar.Controls.Add(this.btnTakeBook);
            this.pnlSidebar.Controls.Add(this.btnUser);
            this.pnlSidebar.Controls.Add(this.btnCategory);
            this.pnlSidebar.Controls.Add(this.btnAuthor);
            this.pnlSidebar.Controls.Add(this.btnBook);
            this.pnlSidebar.Controls.Add(this.btnInfo);
            this.pnlSidebar.Controls.Add(this.pnlSidebarLine);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 70);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(241, 543);
            this.pnlSidebar.TabIndex = 3;
            // 
            // btnTakeBook
            // 
            this.btnTakeBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTakeBook.FlatAppearance.BorderSize = 0;
            this.btnTakeBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTakeBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTakeBook.Image = global::LibrarySimulation.Properties.Resources.bookUser;
            this.btnTakeBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakeBook.Location = new System.Drawing.Point(0, 300);
            this.btnTakeBook.Name = "btnTakeBook";
            this.btnTakeBook.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnTakeBook.Size = new System.Drawing.Size(240, 60);
            this.btnTakeBook.TabIndex = 7;
            this.btnTakeBook.Text = "   Kitap Al / Ver";
            this.btnTakeBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakeBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTakeBook.UseVisualStyleBackColor = true;
            this.btnTakeBook.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUser.Image = global::LibrarySimulation.Properties.Resources.user;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 240);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(240, 60);
            this.btnUser.TabIndex = 6;
            this.btnUser.Text = "   Kullanıcılar";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnCategory
            // 
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCategory.Image = global::LibrarySimulation.Properties.Resources.category;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 180);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(240, 60);
            this.btnCategory.TabIndex = 5;
            this.btnCategory.Text = "   Kategoriler";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuthor.FlatAppearance.BorderSize = 0;
            this.btnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAuthor.Image = global::LibrarySimulation.Properties.Resources.author;
            this.btnAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthor.Location = new System.Drawing.Point(0, 120);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnAuthor.Size = new System.Drawing.Size(240, 60);
            this.btnAuthor.TabIndex = 4;
            this.btnAuthor.Text = "   Yazarlar";
            this.btnAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnBook
            // 
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBook.Image = global::LibrarySimulation.Properties.Resources.book;
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(0, 60);
            this.btnBook.Name = "btnBook";
            this.btnBook.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnBook.Size = new System.Drawing.Size(240, 60);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "   Kitaplar";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInfo.ForeColor = System.Drawing.Color.Gold;
            this.btnInfo.Image = global::LibrarySimulation.Properties.Resources.info;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(240, 60);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "    Giriş";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.ButtonClick);
            // 
            // pnlSidebarLine
            // 
            this.pnlSidebarLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(119)))), ((int)(((byte)(117)))));
            this.pnlSidebarLine.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSidebarLine.Location = new System.Drawing.Point(240, 0);
            this.pnlSidebarLine.Name = "pnlSidebarLine";
            this.pnlSidebarLine.Size = new System.Drawing.Size(1, 543);
            this.pnlSidebarLine.TabIndex = 1;
            // 
            // pnlWinBar
            // 
            this.pnlWinBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlWinBar.Controls.Add(this.picMinimize);
            this.pnlWinBar.Controls.Add(this.picExit);
            this.pnlWinBar.Controls.Add(this.lblTitle);
            this.pnlWinBar.Controls.Add(this.picIcon);
            this.pnlWinBar.Controls.Add(this.pnlWinBarLine);
            this.pnlWinBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWinBar.Location = new System.Drawing.Point(0, 0);
            this.pnlWinBar.Name = "pnlWinBar";
            this.pnlWinBar.Size = new System.Drawing.Size(1086, 70);
            this.pnlWinBar.TabIndex = 2;
            this.pnlWinBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            this.pnlWinBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseMove);
            this.pnlWinBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseUp);
            // 
            // picMinimize
            // 
            this.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMinimize.ErrorImage = global::LibrarySimulation.Properties.Resources.minimize;
            this.picMinimize.Image = global::LibrarySimulation.Properties.Resources.minimize;
            this.picMinimize.Location = new System.Drawing.Point(1017, 23);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(24, 24);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 40;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            this.picMinimize.MouseLeave += new System.EventHandler(this.pic_MouseLeave);
            this.picMinimize.MouseHover += new System.EventHandler(this.picMinimize_MouseHover);
            // 
            // picExit
            // 
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picExit.Image = global::LibrarySimulation.Properties.Resources.exit;
            this.picExit.Location = new System.Drawing.Point(1046, 23);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(24, 24);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 39;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseLeave += new System.EventHandler(this.pic_MouseLeave);
            this.picExit.MouseHover += new System.EventHandler(this.picExit_MouseHover);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.Location = new System.Drawing.Point(98, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Kütüphane Simülasyonu";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseUp);
            // 
            // picIcon
            // 
            this.picIcon.Image = global::LibrarySimulation.Properties.Resources.library_icon;
            this.picIcon.Location = new System.Drawing.Point(1, 4);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(94, 63);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            this.picIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            this.picIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseMove);
            this.picIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseUp);
            // 
            // pnlWinBarLine
            // 
            this.pnlWinBarLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(119)))), ((int)(((byte)(117)))));
            this.pnlWinBarLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlWinBarLine.Location = new System.Drawing.Point(0, 69);
            this.pnlWinBarLine.Name = "pnlWinBarLine";
            this.pnlWinBarLine.Size = new System.Drawing.Size(1086, 1);
            this.pnlWinBarLine.TabIndex = 0;
            // 
            // ucInfo
            // 
            this.ucInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ucInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInfo.Location = new System.Drawing.Point(0, 0);
            this.ucInfo.Name = "ucInfo";
            this.ucInfo.Size = new System.Drawing.Size(845, 543);
            this.ucInfo.TabIndex = 0;
            // 
            // ucUser
            // 
            this.ucUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUser.Location = new System.Drawing.Point(0, 0);
            this.ucUser.Name = "ucUser";
            this.ucUser.Size = new System.Drawing.Size(845, 543);
            this.ucUser.TabIndex = 1;
            // 
            // ucTakeBook
            // 
            this.ucTakeBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTakeBook.Location = new System.Drawing.Point(0, 0);
            this.ucTakeBook.Name = "ucTakeBook";
            this.ucTakeBook.Size = new System.Drawing.Size(845, 543);
            this.ucTakeBook.TabIndex = 2;
            // 
            // ucCategory
            // 
            this.ucCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCategory.Location = new System.Drawing.Point(0, 0);
            this.ucCategory.Name = "ucCategory";
            this.ucCategory.Size = new System.Drawing.Size(845, 543);
            this.ucCategory.TabIndex = 3;
            // 
            // ucBook
            // 
            this.ucBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBook.Location = new System.Drawing.Point(0, 0);
            this.ucBook.Name = "ucBook";
            this.ucBook.Size = new System.Drawing.Size(845, 543);
            this.ucBook.TabIndex = 4;
            // 
            // ucAuthor
            // 
            this.ucAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAuthor.Location = new System.Drawing.Point(0, 0);
            this.ucAuthor.Name = "ucAuthor";
            this.ucAuthor.Size = new System.Drawing.Size(845, 543);
            this.ucAuthor.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(119)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1088, 615);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Simulation";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlViewer.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlWinBar.ResumeLayout(false);
            this.pnlWinBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlWinBar;
        private System.Windows.Forms.Panel pnlWinBarLine;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSidebarLine;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnTakeBook;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Panel pnlViewer;
        private UcInfo ucInfo;
        private UcAuthor ucAuthor;
        private UcBook ucBook;
        private UcCategory ucCategory;
        private UcTakeBook ucTakeBook;
        private UcUser ucUser;
    }
}

