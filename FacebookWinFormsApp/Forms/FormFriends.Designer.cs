namespace FacebookWinFormsApp.Forms
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
               this.components = new System.ComponentModel.Container();
               System.Windows.Forms.Label birthdayLabel;
               System.Windows.Forms.Label lastNameLabel;
               System.Windows.Forms.Label firstNameLabel;
               this.listBoxFriends = new System.Windows.Forms.ListBox();
               this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.pictureBoxFriendPicture = new System.Windows.Forms.PictureBox();
               this.richTextBoxFriendDetails = new System.Windows.Forms.RichTextBox();
               this.listBoxCommonLikedPages = new System.Windows.Forms.ListBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.birthdayTextBox = new System.Windows.Forms.TextBox();
               this.lastNameTextBox = new System.Windows.Forms.TextBox();
               this.firstNameTextBox = new System.Windows.Forms.TextBox();
               birthdayLabel = new System.Windows.Forms.Label();
               lastNameLabel = new System.Windows.Forms.Label();
               firstNameLabel = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).BeginInit();
               this.SuspendLayout();
               // 
               // birthdayLabel
               // 
               birthdayLabel.AutoSize = true;
               birthdayLabel.Location = new System.Drawing.Point(505, 225);
               birthdayLabel.Name = "birthdayLabel";
               birthdayLabel.Size = new System.Drawing.Size(48, 13);
               birthdayLabel.TabIndex = 2;
               birthdayLabel.Text = "Birthday:";
               // 
               // lastNameLabel
               // 
               lastNameLabel.AutoSize = true;
               lastNameLabel.Location = new System.Drawing.Point(505, 199);
               lastNameLabel.Name = "lastNameLabel";
               lastNameLabel.Size = new System.Drawing.Size(61, 13);
               lastNameLabel.TabIndex = 10;
               lastNameLabel.Text = "Last Name:";
               // 
               // firstNameLabel
               // 
               firstNameLabel.AutoSize = true;
               firstNameLabel.Location = new System.Drawing.Point(505, 173);
               firstNameLabel.Name = "firstNameLabel";
               firstNameLabel.Size = new System.Drawing.Size(60, 13);
               firstNameLabel.TabIndex = 6;
               firstNameLabel.Text = "First Name:";
               // 
               // listBoxFriends
               // 
               this.listBoxFriends.DataSource = this.membersBindingSource;
               this.listBoxFriends.DisplayMember = "Name";
               this.listBoxFriends.FormattingEnabled = true;
               this.listBoxFriends.Location = new System.Drawing.Point(21, 23);
               this.listBoxFriends.Name = "listBoxFriends";
               this.listBoxFriends.Size = new System.Drawing.Size(468, 251);
               this.listBoxFriends.TabIndex = 0;
               this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
               // 
               // membersBindingSource
               // 
               this.membersBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
               // 
               // pictureBoxFriendPicture
               // 
               this.pictureBoxFriendPicture.Location = new System.Drawing.Point(508, 23);
               this.pictureBoxFriendPicture.Name = "pictureBoxFriendPicture";
               this.pictureBoxFriendPicture.Size = new System.Drawing.Size(261, 126);
               this.pictureBoxFriendPicture.TabIndex = 1;
               this.pictureBoxFriendPicture.TabStop = false;
               // 
               // richTextBoxFriendDetails
               // 
               this.richTextBoxFriendDetails.Enabled = false;
               this.richTextBoxFriendDetails.Location = new System.Drawing.Point(508, 279);
               this.richTextBoxFriendDetails.Name = "richTextBoxFriendDetails";
               this.richTextBoxFriendDetails.Size = new System.Drawing.Size(187, 139);
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
               this.label2.Location = new System.Drawing.Point(505, 253);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(63, 13);
               this.label2.TabIndex = 5;
               this.label2.Text = "Latest Post:";
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
               // birthdayTextBox
               // 
               this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Birthday", true));
               this.birthdayTextBox.Location = new System.Drawing.Point(586, 222);
               this.birthdayTextBox.Name = "birthdayTextBox";
               this.birthdayTextBox.Size = new System.Drawing.Size(100, 20);
               this.birthdayTextBox.TabIndex = 3;
               // 
               // lastNameTextBox
               // 
               this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "LastName", true));
               this.lastNameTextBox.Location = new System.Drawing.Point(586, 196);
               this.lastNameTextBox.Name = "lastNameTextBox";
               this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
               this.lastNameTextBox.TabIndex = 11;
               // 
               // firstNameTextBox
               // 
               this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "FirstName", true));
               this.firstNameTextBox.Location = new System.Drawing.Point(586, 170);
               this.firstNameTextBox.Name = "firstNameTextBox";
               this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
               this.firstNameTextBox.TabIndex = 7;
               // 
               // FormFriends
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(247)))));
               this.ClientSize = new System.Drawing.Size(888, 471);
               this.Controls.Add(birthdayLabel);
               this.Controls.Add(this.birthdayTextBox);
               this.Controls.Add(this.label3);
               this.Controls.Add(firstNameLabel);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.firstNameTextBox);
               this.Controls.Add(this.label1);
               this.Controls.Add(lastNameLabel);
               this.Controls.Add(this.listBoxCommonLikedPages);
               this.Controls.Add(this.lastNameTextBox);
               this.Controls.Add(this.richTextBoxFriendDetails);
               this.Controls.Add(this.pictureBoxFriendPicture);
               this.Controls.Add(this.listBoxFriends);
               this.Name = "FormFriends";
               this.Text = "Friends";
               ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
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
          private System.Windows.Forms.BindingSource membersBindingSource;
          private System.Windows.Forms.TextBox birthdayTextBox;
          private System.Windows.Forms.TextBox firstNameTextBox;
          private System.Windows.Forms.TextBox lastNameTextBox;
     }
}