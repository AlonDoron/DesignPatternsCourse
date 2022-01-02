using System;

namespace FacebookWinFormsApp.Forms
{
     public partial class FormLikedPages
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
               System.Windows.Forms.Label imageNormalLabel;
               System.Windows.Forms.Label nameLabel;
               this.label2 = new System.Windows.Forms.Label();
               this.listBoxLikedPages = new System.Windows.Forms.ListBox();
               this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
               this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
               this.nameTextBox = new System.Windows.Forms.TextBox();
               imageNormalLabel = new System.Windows.Forms.Label();
               nameLabel = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
               this.SuspendLayout();
               // 
               // imageNormalLabel
               // 
               imageNormalLabel.AutoSize = true;
               imageNormalLabel.Location = new System.Drawing.Point(33, 354);
               imageNormalLabel.Name = "imageNormalLabel";
               imageNormalLabel.Size = new System.Drawing.Size(96, 13);
               imageNormalLabel.TabIndex = 11;
               imageNormalLabel.Text = "Liked Page Image:";
               // 
               // nameLabel
               // 
               nameLabel.AutoSize = true;
               nameLabel.Location = new System.Drawing.Point(36, 318);
               nameLabel.Name = "nameLabel";
               nameLabel.Size = new System.Drawing.Size(38, 13);
               nameLabel.TabIndex = 13;
               nameLabel.Text = "Name:";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(418, 29);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(38, 13);
               this.label2.TabIndex = 8;
               this.label2.Text = "About:";
               // 
               // listBoxLikedPages
               // 
               this.listBoxLikedPages.DataSource = this.pageBindingSource;
               this.listBoxLikedPages.FormattingEnabled = true;
               this.listBoxLikedPages.Location = new System.Drawing.Point(36, 48);
               this.listBoxLikedPages.Name = "listBoxLikedPages";
               this.listBoxLikedPages.Size = new System.Drawing.Size(346, 251);
               this.listBoxLikedPages.TabIndex = 6;
               // 
               // pageBindingSource
               // 
               this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
               // 
               // descriptionRichTextBox
               // 
               this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
               this.descriptionRichTextBox.Location = new System.Drawing.Point(462, 29);
               this.descriptionRichTextBox.Name = "descriptionRichTextBox";
               this.descriptionRichTextBox.Size = new System.Drawing.Size(289, 365);
               this.descriptionRichTextBox.TabIndex = 10;
               this.descriptionRichTextBox.Text = string.Empty;
               // 
               // imageNormalPictureBox
               // 
               this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
               this.imageNormalPictureBox.Location = new System.Drawing.Point(135, 354);
               this.imageNormalPictureBox.Name = "imageNormalPictureBox";
               this.imageNormalPictureBox.Size = new System.Drawing.Size(247, 103);
               this.imageNormalPictureBox.TabIndex = 12;
               this.imageNormalPictureBox.TabStop = false;
               // 
               // nameTextBox
               // 
               this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
               this.nameTextBox.Location = new System.Drawing.Point(117, 315);
               this.nameTextBox.Name = "nameTextBox";
               this.nameTextBox.Size = new System.Drawing.Size(100, 20);
               this.nameTextBox.TabIndex = 14;
               // 
               // FormLikedPages
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(247)))));
               this.ClientSize = new System.Drawing.Size(800, 519);
               this.Controls.Add(this.descriptionRichTextBox);
               this.Controls.Add(imageNormalLabel);
               this.Controls.Add(this.imageNormalPictureBox);
               this.Controls.Add(nameLabel);
               this.Controls.Add(this.nameTextBox);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.listBoxLikedPages);
               this.Name = "FormLikedPages";
               this.Text = "Liked Pages";
               ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.ListBox listBoxLikedPages;
          private System.Windows.Forms.BindingSource pageBindingSource;
          private System.Windows.Forms.RichTextBox descriptionRichTextBox;
          private System.Windows.Forms.PictureBox imageNormalPictureBox;
          private System.Windows.Forms.TextBox nameTextBox;
     }
}