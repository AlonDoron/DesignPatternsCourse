namespace FacebookUI.Forms
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
               this.listBoxGroups = new System.Windows.Forms.ListBox();
               this.pictureBoxGroup = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).BeginInit();
               this.SuspendLayout();
               // 
               // listBoxGroups
               // 
               this.listBoxGroups.FormattingEnabled = true;
               this.listBoxGroups.Location = new System.Drawing.Point(37, 12);
               this.listBoxGroups.Name = "listBoxGroups";
               this.listBoxGroups.Size = new System.Drawing.Size(420, 160);
               this.listBoxGroups.TabIndex = 0;
               this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
               // 
               // pictureBoxGroup
               // 
               this.pictureBoxGroup.Location = new System.Drawing.Point(515, 12);
               this.pictureBoxGroup.Name = "pictureBoxGroup";
               this.pictureBoxGroup.Size = new System.Drawing.Size(243, 160);
               this.pictureBoxGroup.TabIndex = 1;
               this.pictureBoxGroup.TabStop = false;
               // 
               // FormGroups
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(247)))));
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.pictureBoxGroup);
               this.Controls.Add(this.listBoxGroups);
               this.Name = "FormGroups";
               this.Text = "Groups";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.ListBox listBoxGroups;
          private System.Windows.Forms.PictureBox pictureBoxGroup;
     }
}