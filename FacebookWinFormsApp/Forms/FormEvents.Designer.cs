namespace BasicFacebookFeatures.Forms
{
     public partial class FormEvents
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
               this.listBoxEvents = new System.Windows.Forms.ListBox();
               this.pictureBoxEvents = new System.Windows.Forms.PictureBox();
               this.monthCalendarEvents = new System.Windows.Forms.MonthCalendar();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).BeginInit();
               this.SuspendLayout();
               // 
               // listBoxEvents
               // 
               this.listBoxEvents.FormattingEnabled = true;
               this.listBoxEvents.Location = new System.Drawing.Point(63, 70);
               this.listBoxEvents.Name = "listBoxEvents";
               this.listBoxEvents.Size = new System.Drawing.Size(367, 160);
               this.listBoxEvents.TabIndex = 0;
               this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
               // 
               // pictureBoxEvents
               // 
               this.pictureBoxEvents.Location = new System.Drawing.Point(476, 71);
               this.pictureBoxEvents.Name = "pictureBoxEvents";
               this.pictureBoxEvents.Size = new System.Drawing.Size(227, 159);
               this.pictureBoxEvents.TabIndex = 1;
               this.pictureBoxEvents.TabStop = false;
               // 
               // monthCalendarEvents
               // 
               this.monthCalendarEvents.Enabled = false;
               this.monthCalendarEvents.Location = new System.Drawing.Point(476, 270);
               this.monthCalendarEvents.Name = "monthCalendarEvents";
               this.monthCalendarEvents.TabIndex = 2;
               // 
               // FormEvents
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(247)))));
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.monthCalendarEvents);
               this.Controls.Add(this.pictureBoxEvents);
               this.Controls.Add(this.listBoxEvents);
               this.Name = "FormEvents";
               this.Text = "Events";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.ListBox listBoxEvents;
          private System.Windows.Forms.PictureBox pictureBoxEvents;
          private System.Windows.Forms.MonthCalendar monthCalendarEvents;
     }
}