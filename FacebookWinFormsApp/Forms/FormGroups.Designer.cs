namespace FacebookWinFormsApp.Forms
{
     public partial class FormGroups
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
               System.Windows.Forms.Label nameLabel;
               System.Windows.Forms.Label descriptionLabel;
               this.listBoxGroups = new System.Windows.Forms.ListBox();
               this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
               this.nameTextBox = new System.Windows.Forms.TextBox();
               this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
               this.buttonClose = new System.Windows.Forms.Button();
               nameLabel = new System.Windows.Forms.Label();
               descriptionLabel = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
               this.SuspendLayout();
               // 
               // nameLabel
               // 
               nameLabel.AutoSize = true;
               nameLabel.Location = new System.Drawing.Point(46, 186);
               nameLabel.Name = "nameLabel";
               nameLabel.Size = new System.Drawing.Size(38, 13);
               nameLabel.TabIndex = 7;
               nameLabel.Text = "Name:";
               // 
               // descriptionLabel
               // 
               descriptionLabel.AutoSize = true;
               descriptionLabel.Location = new System.Drawing.Point(47, 223);
               descriptionLabel.Name = "descriptionLabel";
               descriptionLabel.Size = new System.Drawing.Size(63, 13);
               descriptionLabel.TabIndex = 8;
               descriptionLabel.Text = "Description:";
               // 
               // listBoxGroups
               // 
               this.listBoxGroups.DataSource = this.groupBindingSource;
               this.listBoxGroups.DisplayMember = "Name";
               this.listBoxGroups.FormattingEnabled = true;
               this.listBoxGroups.Location = new System.Drawing.Point(37, 12);
               this.listBoxGroups.Name = "listBoxGroups";
               this.listBoxGroups.Size = new System.Drawing.Size(420, 160);
               this.listBoxGroups.TabIndex = 0;
               // 
               // groupBindingSource
               // 
               this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
               // 
               // imageNormalPictureBox
               // 
               this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.groupBindingSource, "ImageNormal", true));
               this.imageNormalPictureBox.Location = new System.Drawing.Point(486, 12);
               this.imageNormalPictureBox.Name = "imageNormalPictureBox";
               this.imageNormalPictureBox.Size = new System.Drawing.Size(274, 160);
               this.imageNormalPictureBox.TabIndex = 6;
               this.imageNormalPictureBox.TabStop = false;
               // 
               // nameTextBox
               // 
               this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Name", true));
               this.nameTextBox.Location = new System.Drawing.Point(127, 183);
               this.nameTextBox.Name = "nameTextBox";
               this.nameTextBox.Size = new System.Drawing.Size(100, 20);
               this.nameTextBox.TabIndex = 8;
               // 
               // descriptionRichTextBox
               // 
               this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Description", true));
               this.descriptionRichTextBox.Location = new System.Drawing.Point(116, 220);
               this.descriptionRichTextBox.Name = "descriptionRichTextBox";
               this.descriptionRichTextBox.Size = new System.Drawing.Size(286, 125);
               this.descriptionRichTextBox.TabIndex = 9;
               this.descriptionRichTextBox.Text = string.Empty;
               // 
               // buttonClose
               // 
               this.buttonClose.Location = new System.Drawing.Point(694, 387);
               this.buttonClose.Name = "buttonClose";
               this.buttonClose.Size = new System.Drawing.Size(75, 23);
               this.buttonClose.TabIndex = 10;
               this.buttonClose.Text = "Close";
               this.buttonClose.UseVisualStyleBackColor = true;
               this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
               // 
               // FormGroups
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(247)))));
               this.ClientSize = new System.Drawing.Size(909, 450);
               this.Controls.Add(this.buttonClose);
               this.Controls.Add(descriptionLabel);
               this.Controls.Add(this.descriptionRichTextBox);
               this.Controls.Add(this.imageNormalPictureBox);
               this.Controls.Add(nameLabel);
               this.Controls.Add(this.nameTextBox);
               this.Controls.Add(this.listBoxGroups);
               this.Name = "FormGroups";
               this.Text = "Groups";
               ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ListBox listBoxGroups;
          private System.Windows.Forms.BindingSource groupBindingSource;
          private System.Windows.Forms.PictureBox imageNormalPictureBox;
          private System.Windows.Forms.TextBox nameTextBox;
          private System.Windows.Forms.RichTextBox descriptionRichTextBox;
          private System.Windows.Forms.Button buttonClose;
     }
}