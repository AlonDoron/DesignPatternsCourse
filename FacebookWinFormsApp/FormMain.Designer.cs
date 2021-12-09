namespace FacebookUI
{
     public partial class FormMain
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
               this.buttonLogin = new System.Windows.Forms.Button();
               this.buttonLogout = new System.Windows.Forms.Button();
               this.panelSidebar = new System.Windows.Forms.Panel();
               this.buttonGroups = new System.Windows.Forms.Button();
               this.buttonPersonality = new System.Windows.Forms.Button();
               this.buttonLikedPages = new System.Windows.Forms.Button();
               this.buttonEvents = new System.Windows.Forms.Button();
               this.buttonFriends = new System.Windows.Forms.Button();
               this.buttonGallery = new System.Windows.Forms.Button();
               this.buttonPosts = new System.Windows.Forms.Button();
               this.panel5 = new System.Windows.Forms.Panel();
               this.labelUsername = new System.Windows.Forms.Label();
               this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
               this.panelTitleBar = new System.Windows.Forms.Panel();
               this.labelTitle = new System.Windows.Forms.Label();
               this.panelForms = new System.Windows.Forms.Panel();
               this.panelSidebar.SuspendLayout();
               this.panel5.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
               this.panelTitleBar.SuspendLayout();
               this.panelForms.SuspendLayout();
               this.SuspendLayout();
               // 
               // buttonLogin
               // 
               this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(101)))), ((int)(((byte)(27)))));
               this.buttonLogin.Location = new System.Drawing.Point(382, 103);
               this.buttonLogin.Name = "buttonLogin";
               this.buttonLogin.Size = new System.Drawing.Size(223, 82);
               this.buttonLogin.TabIndex = 36;
               this.buttonLogin.Text = "Login";
               this.buttonLogin.UseVisualStyleBackColor = true;
               this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
               // 
               // buttonLogout
               // 
               this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
               this.buttonLogout.Location = new System.Drawing.Point(37, 134);
               this.buttonLogout.Name = "buttonLogout";
               this.buttonLogout.Size = new System.Drawing.Size(105, 25);
               this.buttonLogout.TabIndex = 52;
               this.buttonLogout.Text = "Logout";
               this.buttonLogout.UseVisualStyleBackColor = true;
               this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
               // 
               // panelSidebar
               // 
               this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(123)))), ((int)(((byte)(181)))));
               this.panelSidebar.Controls.Add(this.buttonGroups);
               this.panelSidebar.Controls.Add(this.buttonPersonality);
               this.panelSidebar.Controls.Add(this.buttonLikedPages);
               this.panelSidebar.Controls.Add(this.buttonEvents);
               this.panelSidebar.Controls.Add(this.buttonFriends);
               this.panelSidebar.Controls.Add(this.buttonGallery);
               this.panelSidebar.Controls.Add(this.buttonPosts);
               this.panelSidebar.Controls.Add(this.panel5);
               this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
               this.panelSidebar.Location = new System.Drawing.Point(0, 0);
               this.panelSidebar.Name = "panelSidebar";
               this.panelSidebar.Size = new System.Drawing.Size(186, 538);
               this.panelSidebar.TabIndex = 53;
               this.panelSidebar.Visible = false;
               // 
               // buttonGroups
               // 
               this.buttonGroups.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonGroups.FlatAppearance.BorderSize = 0;
               this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonGroups.Font = new System.Drawing.Font("Segoe UI", 14.25F);
               this.buttonGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(165)))), ((int)(((byte)(122)))));
               this.buttonGroups.Location = new System.Drawing.Point(0, 417);
               this.buttonGroups.Name = "buttonGroups";
               this.buttonGroups.Size = new System.Drawing.Size(186, 42);
               this.buttonGroups.TabIndex = 9;
               this.buttonGroups.Text = "Groups";
               this.buttonGroups.UseVisualStyleBackColor = true;
               this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
               // 
               // buttonPersonality
               // 
               this.buttonPersonality.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonPersonality.FlatAppearance.BorderSize = 0;
               this.buttonPersonality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonPersonality.Font = new System.Drawing.Font("Segoe UI", 14.25F);
               this.buttonPersonality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(165)))), ((int)(((byte)(122)))));
               this.buttonPersonality.Location = new System.Drawing.Point(0, 375);
               this.buttonPersonality.Name = "buttonPersonality";
               this.buttonPersonality.Size = new System.Drawing.Size(186, 42);
               this.buttonPersonality.TabIndex = 8;
               this.buttonPersonality.Text = "Personality";
               this.buttonPersonality.UseVisualStyleBackColor = true;
               this.buttonPersonality.Click += new System.EventHandler(this.buttonPersonality_Click);
               // 
               // buttonLikedPages
               // 
               this.buttonLikedPages.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonLikedPages.FlatAppearance.BorderSize = 0;
               this.buttonLikedPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonLikedPages.Font = new System.Drawing.Font("Segoe UI", 14.25F);
               this.buttonLikedPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(165)))), ((int)(((byte)(122)))));
               this.buttonLikedPages.Location = new System.Drawing.Point(0, 333);
               this.buttonLikedPages.Name = "buttonLikedPages";
               this.buttonLikedPages.Size = new System.Drawing.Size(186, 42);
               this.buttonLikedPages.TabIndex = 6;
               this.buttonLikedPages.Text = "Liked Pages";
               this.buttonLikedPages.UseVisualStyleBackColor = true;
               this.buttonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
               // 
               // buttonEvents
               // 
               this.buttonEvents.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonEvents.FlatAppearance.BorderSize = 0;
               this.buttonEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonEvents.Font = new System.Drawing.Font("Segoe UI", 14.25F);
               this.buttonEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(165)))), ((int)(((byte)(122)))));
               this.buttonEvents.Location = new System.Drawing.Point(0, 291);
               this.buttonEvents.Name = "buttonEvents";
               this.buttonEvents.Size = new System.Drawing.Size(186, 42);
               this.buttonEvents.TabIndex = 4;
               this.buttonEvents.Text = "Events";
               this.buttonEvents.UseVisualStyleBackColor = true;
               this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
               // 
               // buttonFriends
               // 
               this.buttonFriends.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonFriends.FlatAppearance.BorderSize = 0;
               this.buttonFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonFriends.Font = new System.Drawing.Font("Segoe UI", 14.25F);
               this.buttonFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(165)))), ((int)(((byte)(122)))));
               this.buttonFriends.Location = new System.Drawing.Point(0, 249);
               this.buttonFriends.Name = "buttonFriends";
               this.buttonFriends.Size = new System.Drawing.Size(186, 42);
               this.buttonFriends.TabIndex = 3;
               this.buttonFriends.Text = "Friends";
               this.buttonFriends.UseVisualStyleBackColor = true;
               this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
               // 
               // buttonGallery
               // 
               this.buttonGallery.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonGallery.FlatAppearance.BorderSize = 0;
               this.buttonGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonGallery.Font = new System.Drawing.Font("Segoe UI", 14.25F);
               this.buttonGallery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(165)))), ((int)(((byte)(122)))));
               this.buttonGallery.Location = new System.Drawing.Point(0, 207);
               this.buttonGallery.Name = "buttonGallery";
               this.buttonGallery.Size = new System.Drawing.Size(186, 42);
               this.buttonGallery.TabIndex = 2;
               this.buttonGallery.Text = "Gallery";
               this.buttonGallery.UseVisualStyleBackColor = true;
               this.buttonGallery.Click += new System.EventHandler(this.buttonGallery_Click);
               // 
               // buttonPosts
               // 
               this.buttonPosts.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonPosts.FlatAppearance.BorderSize = 0;
               this.buttonPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonPosts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonPosts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(165)))), ((int)(((byte)(122)))));
               this.buttonPosts.Location = new System.Drawing.Point(0, 165);
               this.buttonPosts.Name = "buttonPosts";
               this.buttonPosts.Size = new System.Drawing.Size(186, 42);
               this.buttonPosts.TabIndex = 1;
               this.buttonPosts.Text = "Posts";
               this.buttonPosts.UseVisualStyleBackColor = true;
               this.buttonPosts.Click += new System.EventHandler(this.buttonPosts_Click);
               // 
               // panel5
               // 
               this.panel5.Controls.Add(this.labelUsername);
               this.panel5.Controls.Add(this.buttonLogout);
               this.panel5.Controls.Add(this.pictureBoxProfile);
               this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel5.Location = new System.Drawing.Point(0, 0);
               this.panel5.Name = "panel5";
               this.panel5.Size = new System.Drawing.Size(186, 165);
               this.panel5.TabIndex = 0;
               // 
               // labelUsername
               // 
               this.labelUsername.AutoSize = true;
               this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(101)))), ((int)(((byte)(27)))));
               this.labelUsername.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
               this.labelUsername.Location = new System.Drawing.Point(32, 106);
               this.labelUsername.Name = "labelUsername";
               this.labelUsername.Size = new System.Drawing.Size(101, 25);
               this.labelUsername.TabIndex = 1;
               this.labelUsername.Text = "Username";
               this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // pictureBoxProfile
               // 
               this.pictureBoxProfile.Location = new System.Drawing.Point(37, 12);
               this.pictureBoxProfile.Name = "pictureBoxProfile";
               this.pictureBoxProfile.Size = new System.Drawing.Size(134, 99);
               this.pictureBoxProfile.TabIndex = 0;
               this.pictureBoxProfile.TabStop = false;
               // 
               // panelTitleBar
               // 
               this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
               this.panelTitleBar.Controls.Add(this.labelTitle);
               this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
               this.panelTitleBar.Location = new System.Drawing.Point(186, 0);
               this.panelTitleBar.Name = "panelTitleBar";
               this.panelTitleBar.Size = new System.Drawing.Size(749, 80);
               this.panelTitleBar.TabIndex = 54;
               // 
               // labelTitle
               // 
               this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
               this.labelTitle.AutoSize = true;
               this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(101)))), ((int)(((byte)(27)))));
               this.labelTitle.Location = new System.Drawing.Point(328, 33);
               this.labelTitle.Name = "labelTitle";
               this.labelTitle.Size = new System.Drawing.Size(139, 37);
               this.labelTitle.TabIndex = 0;
               this.labelTitle.Text = "Facebook";
               // 
               // panelForms
               // 
               this.panelForms.Controls.Add(this.buttonLogin);
               this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panelForms.Location = new System.Drawing.Point(186, 80);
               this.panelForms.Name = "panelForms";
               this.panelForms.Size = new System.Drawing.Size(749, 458);
               this.panelForms.TabIndex = 55;
               // 
               // FormMain
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(247)))));
               this.ClientSize = new System.Drawing.Size(935, 538);
               this.Controls.Add(this.panelForms);
               this.Controls.Add(this.panelTitleBar);
               this.Controls.Add(this.panelSidebar);
               this.Name = "FormMain";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form1";
               this.panelSidebar.ResumeLayout(false);
               this.panel5.ResumeLayout(false);
               this.panel5.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
               this.panelTitleBar.ResumeLayout(false);
               this.panelTitleBar.PerformLayout();
               this.panelForms.ResumeLayout(false);
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Button buttonLogin;
          private System.Windows.Forms.Button buttonLogout;
          private System.Windows.Forms.Panel panelSidebar;
          private System.Windows.Forms.Panel panel5;
          private System.Windows.Forms.PictureBox pictureBoxProfile;
          private System.Windows.Forms.Label labelUsername;
          private System.Windows.Forms.Button buttonPosts;
          private System.Windows.Forms.Button buttonFriends;
          private System.Windows.Forms.Button buttonGallery;
          private System.Windows.Forms.Button buttonLikedPages;
          private System.Windows.Forms.Button buttonEvents;
          private System.Windows.Forms.Panel panelTitleBar;
          private System.Windows.Forms.Label labelTitle;
          private System.Windows.Forms.Panel panelForms;
          private System.Windows.Forms.Button buttonGroups;
          private System.Windows.Forms.Button buttonPersonality;
     }
}