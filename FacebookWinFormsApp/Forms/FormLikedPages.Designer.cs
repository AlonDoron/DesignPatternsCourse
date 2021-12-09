namespace BasicFacebookFeatures.Forms
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
               this.label2 = new System.Windows.Forms.Label();
               this.richTextBoxPageDetails = new System.Windows.Forms.RichTextBox();
               this.listBoxLikedPages = new System.Windows.Forms.ListBox();
               this.SuspendLayout();
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
               // richTextBoxPageDetails
               // 
               this.richTextBoxPageDetails.Enabled = false;
               this.richTextBoxPageDetails.Location = new System.Drawing.Point(421, 48);
               this.richTextBoxPageDetails.Name = "richTextBoxPageDetails";
               this.richTextBoxPageDetails.Size = new System.Drawing.Size(286, 251);
               this.richTextBoxPageDetails.TabIndex = 7;
               this.richTextBoxPageDetails.Text = string.Empty;
               // 
               // listBoxLikedPages
               // 
               this.listBoxLikedPages.FormattingEnabled = true;
               this.listBoxLikedPages.Location = new System.Drawing.Point(36, 48);
               this.listBoxLikedPages.Name = "listBoxLikedPages";
               this.listBoxLikedPages.Size = new System.Drawing.Size(346, 251);
               this.listBoxLikedPages.TabIndex = 6;
               this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
               // 
               // FormLikedPages
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(247)))));
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.richTextBoxPageDetails);
               this.Controls.Add(this.listBoxLikedPages);
               this.Name = "FormLikedPages";
               this.Text = "Liked Pages";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.RichTextBox richTextBoxPageDetails;
          private System.Windows.Forms.ListBox listBoxLikedPages;
     }
}