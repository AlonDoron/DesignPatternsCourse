using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
     public partial class FormPosts
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
               this.buttonSetStatus = new System.Windows.Forms.Button();
               this.textBoxStatus = new System.Windows.Forms.TextBox();
               this.label3 = new System.Windows.Forms.Label();
               this.listBoxPosts = new System.Windows.Forms.ListBox();
               this.pictureBoxPostImage = new System.Windows.Forms.PictureBox();
               this.checkBoxShowFavoritePosts = new System.Windows.Forms.CheckBox();
               this.label1 = new System.Windows.Forms.Label();
               this.button1 = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostImage)).BeginInit();
               this.SuspendLayout();
               // 
               // buttonSetStatus
               // 
               this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.buttonSetStatus.Location = new System.Drawing.Point(377, 46);
               this.buttonSetStatus.Name = "buttonSetStatus";
               this.buttonSetStatus.Size = new System.Drawing.Size(75, 23);
               this.buttonSetStatus.TabIndex = 49;
               this.buttonSetStatus.Text = "Post";
               this.buttonSetStatus.UseVisualStyleBackColor = true;
               this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
               // 
               // textBoxStatus
               // 
               this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.textBoxStatus.Location = new System.Drawing.Point(150, 48);
               this.textBoxStatus.Name = "textBoxStatus";
               this.textBoxStatus.Size = new System.Drawing.Size(221, 20);
               this.textBoxStatus.TabIndex = 48;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(80, 51);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(64, 13);
               this.label3.TabIndex = 47;
               this.label3.Text = "Post Status:";
               // 
               // listBoxPosts
               // 
               this.listBoxPosts.FormattingEnabled = true;
               this.listBoxPosts.Location = new System.Drawing.Point(68, 147);
               this.listBoxPosts.Name = "listBoxPosts";
               this.listBoxPosts.Size = new System.Drawing.Size(487, 199);
               this.listBoxPosts.TabIndex = 53;
               this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
               this.listBoxPosts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxPosts_MouseDown);
               // 
               // pictureBoxPostImage
               // 
               this.pictureBoxPostImage.Location = new System.Drawing.Point(593, 147);
               this.pictureBoxPostImage.Name = "pictureBoxPostImage";
               this.pictureBoxPostImage.Size = new System.Drawing.Size(165, 199);
               this.pictureBoxPostImage.TabIndex = 54;
               this.pictureBoxPostImage.TabStop = false;
               // 
               // checkBoxShowFavoritePosts
               // 
               this.checkBoxShowFavoritePosts.AutoSize = true;
               this.checkBoxShowFavoritePosts.Location = new System.Drawing.Point(68, 103);
               this.checkBoxShowFavoritePosts.Name = "checkBoxShowFavoritePosts";
               this.checkBoxShowFavoritePosts.Size = new System.Drawing.Size(123, 17);
               this.checkBoxShowFavoritePosts.TabIndex = 55;
               this.checkBoxShowFavoritePosts.Text = "Show Favorite Posts";
               this.checkBoxShowFavoritePosts.UseVisualStyleBackColor = true;
               this.checkBoxShowFavoritePosts.CheckedChanged += new System.EventHandler(this.checkBoxShowFavoritePosts_CheckedChanged);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(89, 123);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(297, 13);
               this.label1.TabIndex = 56;
               this.label1.Text = "(Select a post, then right click on a post to show post options)";
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(631, 48);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(75, 23);
               this.button1.TabIndex = 57;
               this.button1.Text = "Close";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // FormPosts
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(247)))));
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.checkBoxShowFavoritePosts);
               this.Controls.Add(this.pictureBoxPostImage);
               this.Controls.Add(this.listBoxPosts);
               this.Controls.Add(this.buttonSetStatus);
               this.Controls.Add(this.textBoxStatus);
               this.Controls.Add(this.label3);
               this.Name = "FormPosts";
               this.Text = "Posts";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostImage)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.Button buttonSetStatus;
          private System.Windows.Forms.TextBox textBoxStatus;
          private System.Windows.Forms.Label label3;
          private ListBox listBoxPosts;
          private PictureBox pictureBoxPostImage;
          private CheckBox checkBoxShowFavoritePosts;
          private Label label1;
          private Button button1;
     }
}