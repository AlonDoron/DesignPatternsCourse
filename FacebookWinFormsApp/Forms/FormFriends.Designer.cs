namespace FacebookUI.Forms
{
     public partial class FormFriends
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
               this.listBoxFriends = new System.Windows.Forms.ListBox();
               this.pictureBoxFriendPicture = new System.Windows.Forms.PictureBox();
               this.richTextBoxFriendDetails = new System.Windows.Forms.RichTextBox();
               this.listBoxCommonLikedPages = new System.Windows.Forms.ListBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).BeginInit();
               this.SuspendLayout();
               // 
               // listBoxFriends
               // 
               this.listBoxFriends.FormattingEnabled = true;
               this.listBoxFriends.Location = new System.Drawing.Point(21, 23);
               this.listBoxFriends.Name = "listBoxFriends";
               this.listBoxFriends.Size = new System.Drawing.Size(468, 251);
               this.listBoxFriends.TabIndex = 0;
               this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
               // 
               // pictureBoxFriendPicture
               // 
               this.pictureBoxFriendPicture.Location = new System.Drawing.Point(527, 23);
               this.pictureBoxFriendPicture.Name = "pictureBoxFriendPicture";
               this.pictureBoxFriendPicture.Size = new System.Drawing.Size(261, 126);
               this.pictureBoxFriendPicture.TabIndex = 1;
               this.pictureBoxFriendPicture.TabStop = false;
               // 
               // richTextBoxFriendDetails
               // 
               this.richTextBoxFriendDetails.Enabled = false;
               this.richTextBoxFriendDetails.Location = new System.Drawing.Point(527, 182);
               this.richTextBoxFriendDetails.Name = "richTextBoxFriendDetails";
               this.richTextBoxFriendDetails.Size = new System.Drawing.Size(222, 196);
               this.richTextBoxFriendDetails.TabIndex = 2;
               this.richTextBoxFriendDetails.Text = string.Empty;
               // 
               // listBoxCommonLikedPages
               // 
               this.listBoxCommonLikedPages.FormattingEnabled = true;
               this.listBoxCommonLikedPages.Location = new System.Drawing.Point(21, 336);
               this.listBoxCommonLikedPages.Name = "listBoxCommonLikedPages";
               this.listBoxCommonLikedPages.Size = new System.Drawing.Size(468, 82);
               this.listBoxCommonLikedPages.TabIndex = 3;
               this.listBoxCommonLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxCommonLikedPages_SelectedIndexChanged);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(18, 300);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(113, 13);
               this.label1.TabIndex = 4;
               this.label1.Text = "Common Liked Pages:";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(524, 156);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(38, 13);
               this.label2.TabIndex = 5;
               this.label2.Text = "About:";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(18, 313);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(211, 13);
               this.label3.TabIndex = 6;
               this.label3.Text = "(Press on a page to open it in your browser)";
               // 
               // FormFriends
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(247)))));
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.listBoxCommonLikedPages);
               this.Controls.Add(this.richTextBoxFriendDetails);
               this.Controls.Add(this.pictureBoxFriendPicture);
               this.Controls.Add(this.listBoxFriends);
               this.Name = "FormFriends";
               this.Text = "Friends";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ListBox listBoxFriends;
          private System.Windows.Forms.PictureBox pictureBoxFriendPicture;
          private System.Windows.Forms.RichTextBox richTextBoxFriendDetails;
          private System.Windows.Forms.ListBox listBoxCommonLikedPages;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
     }
}