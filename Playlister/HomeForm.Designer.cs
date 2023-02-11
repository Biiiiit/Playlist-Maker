namespace Playlister
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSongSubMenu = new System.Windows.Forms.Panel();
            this.btnSearchSong = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnSong = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnSideMenu = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelSongSubMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.panelSongSubMenu);
            this.panelMenu.Controls.Add(this.btnSong);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 125);
            this.panelMenu.MaximumSize = new System.Drawing.Size(209, 692);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(209, 567);
            this.panelMenu.TabIndex = 0;
            // 
            // panelSongSubMenu
            // 
            this.panelSongSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelSongSubMenu.Controls.Add(this.btnSearchSong);
            this.panelSongSubMenu.Controls.Add(this.btnAddSong);
            this.panelSongSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSongSubMenu.Location = new System.Drawing.Point(0, 58);
            this.panelSongSubMenu.Name = "panelSongSubMenu";
            this.panelSongSubMenu.Size = new System.Drawing.Size(209, 89);
            this.panelSongSubMenu.TabIndex = 2;
            // 
            // btnSearchSong
            // 
            this.btnSearchSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearchSong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchSong.FlatAppearance.BorderSize = 0;
            this.btnSearchSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSong.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchSong.ForeColor = System.Drawing.Color.Red;
            this.btnSearchSong.Location = new System.Drawing.Point(0, 43);
            this.btnSearchSong.Name = "btnSearchSong";
            this.btnSearchSong.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSearchSong.Size = new System.Drawing.Size(209, 43);
            this.btnSearchSong.TabIndex = 1;
            this.btnSearchSong.Text = "Search Song";
            this.btnSearchSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchSong.UseVisualStyleBackColor = false;
            // 
            // btnAddSong
            // 
            this.btnAddSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAddSong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddSong.FlatAppearance.BorderSize = 0;
            this.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSong.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSong.ForeColor = System.Drawing.Color.Red;
            this.btnAddSong.Location = new System.Drawing.Point(0, 0);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAddSong.Size = new System.Drawing.Size(209, 43);
            this.btnAddSong.TabIndex = 0;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSong.UseVisualStyleBackColor = false;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnSong
            // 
            this.btnSong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSong.FlatAppearance.BorderSize = 0;
            this.btnSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSong.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSong.ForeColor = System.Drawing.Color.Red;
            this.btnSong.Image = ((System.Drawing.Image)(resources.GetObject("btnSong.Image")));
            this.btnSong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSong.Location = new System.Drawing.Point(0, 0);
            this.btnSong.Name = "btnSong";
            this.btnSong.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnSong.Size = new System.Drawing.Size(209, 58);
            this.btnSong.TabIndex = 1;
            this.btnSong.Text = "Song";
            this.btnSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSong.UseVisualStyleBackColor = true;
            this.btnSong.Click += new System.EventHandler(this.btnSong_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Black;
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelTop.Controls.Add(this.lblTop);
            this.panelTop.Controls.Add(this.panelLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1274, 125);
            this.panelTop.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnSideMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(209, 125);
            this.panelLogo.TabIndex = 1;
            // 
            // btnSideMenu
            // 
            this.btnSideMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSideMenu.BackgroundImage")));
            this.btnSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSideMenu.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSideMenu.FlatAppearance.BorderSize = 0;
            this.btnSideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideMenu.ForeColor = System.Drawing.Color.White;
            this.btnSideMenu.Location = new System.Drawing.Point(0, 0);
            this.btnSideMenu.Name = "btnSideMenu";
            this.btnSideMenu.Size = new System.Drawing.Size(209, 125);
            this.btnSideMenu.TabIndex = 0;
            this.btnSideMenu.UseVisualStyleBackColor = true;
            this.btnSideMenu.Click += new System.EventHandler(this.btnSideMenu_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Maroon;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(209, 125);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1065, 567);
            this.panelChildForm.TabIndex = 1;
            // 
            // lblTop
            // 
            this.lblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTop.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTop.ForeColor = System.Drawing.Color.Red;
            this.lblTop.Location = new System.Drawing.Point(209, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTop.Size = new System.Drawing.Size(1065, 125);
            this.lblTop.TabIndex = 2;
            this.lblTop.Text = "Playlister";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1274, 692);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.panelMenu.ResumeLayout(false);
            this.panelSongSubMenu.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btnSong;
        private Panel panelTop;
        private Panel panelSongSubMenu;
        private Button btnSearchSong;
        private Button btnAddSong;
        private Button btnSideMenu;
        private Panel panelLogo;
        private Panel panelChildForm;
        private Label lblTop;
    }
}