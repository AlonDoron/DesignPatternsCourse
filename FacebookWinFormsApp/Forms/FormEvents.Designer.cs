namespace FacebookWinFormsApp.Forms
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
               this.components = new System.ComponentModel.Container();
               System.Windows.Forms.Label descriptionLabel;
               System.Windows.Forms.Label endTimeLabel;
               System.Windows.Forms.Label nameLabel;
               System.Windows.Forms.Label startTimeLabel;
               this.listBoxEvents = new System.Windows.Forms.ListBox();
               this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.pictureBoxEvents = new System.Windows.Forms.PictureBox();
               this.panel1 = new System.Windows.Forms.Panel();
               this.descriptionTextBox = new System.Windows.Forms.TextBox();
               this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
               this.nameTextBox = new System.Windows.Forms.TextBox();
               this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
               this.buttonClose = new System.Windows.Forms.Button();
               descriptionLabel = new System.Windows.Forms.Label();
               endTimeLabel = new System.Windows.Forms.Label();
               nameLabel = new System.Windows.Forms.Label();
               startTimeLabel = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).BeginInit();
               this.panel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // descriptionLabel
               // 
               descriptionLabel.AutoSize = true;
               descriptionLabel.Location = new System.Drawing.Point(40, 91);
               descriptionLabel.Name = "descriptionLabel";
               descriptionLabel.Size = new System.Drawing.Size(63, 13);
               descriptionLabel.TabIndex = 0;
               descriptionLabel.Text = "Description:";
               // 
               // endTimeLabel
               // 
               endTimeLabel.AutoSize = true;
               endTimeLabel.Location = new System.Drawing.Point(40, 118);
               endTimeLabel.Name = "endTimeLabel";
               endTimeLabel.Size = new System.Drawing.Size(55, 13);
               endTimeLabel.TabIndex = 2;
               endTimeLabel.Text = "End Time:";
               // 
               // nameLabel
               // 
               nameLabel.AutoSize = true;
               nameLabel.Location = new System.Drawing.Point(40, 39);
               nameLabel.Name = "nameLabel";
               nameLabel.Size = new System.Drawing.Size(38, 13);
               nameLabel.TabIndex = 6;
               nameLabel.Text = "Name:";
               // 
               // startTimeLabel
               // 
               startTimeLabel.AutoSize = true;
               startTimeLabel.Location = new System.Drawing.Point(40, 66);
               startTimeLabel.Name = "startTimeLabel";
               startTimeLabel.Size = new System.Drawing.Size(58, 13);
               startTimeLabel.TabIndex = 8;
               startTimeLabel.Text = "Start Time:";
               // 
               // listBoxEvents
               // 
               this.listBoxEvents.DataSource = this.eventBindingSource;
               this.listBoxEvents.DisplayMember = "Name";
               this.listBoxEvents.FormattingEnabled = true;
               this.listBoxEvents.Location = new System.Drawing.Point(63, 70);
               this.listBoxEvents.Name = "listBoxEvents";
               this.listBoxEvents.Size = new System.Drawing.Size(367, 160);
               this.listBoxEvents.TabIndex = 0;
               this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
               // 
               // eventBindingSource
               // 
               this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
               // 
               // pictureBoxEvents
               // 
               this.pictureBoxEvents.Location = new System.Drawing.Point(476, 71);
               this.pictureBoxEvents.Name = "pictureBoxEvents";
               this.pictureBoxEvents.Size = new System.Drawing.Size(227, 159);
               this.pictureBoxEvents.TabIndex = 1;
               this.pictureBoxEvents.TabStop = false;
               // 
               // panel1
               // 
               this.panel1.Controls.Add(descriptionLabel);
               this.panel1.Controls.Add(this.descriptionTextBox);
               this.panel1.Controls.Add(endTimeLabel);
               this.panel1.Controls.Add(this.endTimeDateTimePicker);
               this.panel1.Controls.Add(nameLabel);
               this.panel1.Controls.Add(this.nameTextBox);
               this.panel1.Controls.Add(startTimeLabel);
               this.panel1.Controls.Add(this.startTimeDateTimePicker);
               this.panel1.Location = new System.Drawing.Point(63, 236);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(367, 185);
               this.panel1.TabIndex = 3;
               // 
               // descriptionTextBox
               // 
               this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
               this.descriptionTextBox.Location = new System.Drawing.Point(121, 88);
               this.descriptionTextBox.Name = "descriptionTextBox";
               this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
               this.descriptionTextBox.TabIndex = 1;
               // 
               // endTimeDateTimePicker
               // 
               this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
               this.endTimeDateTimePicker.Location = new System.Drawing.Point(121, 114);
               this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
               this.endTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
               this.endTimeDateTimePicker.TabIndex = 3;
               // 
               // nameTextBox
               // 
               this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
               this.nameTextBox.Location = new System.Drawing.Point(121, 36);
               this.nameTextBox.Name = "nameTextBox";
               this.nameTextBox.Size = new System.Drawing.Size(200, 20);
               this.nameTextBox.TabIndex = 7;
               // 
               // startTimeDateTimePicker
               // 
               this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
               this.startTimeDateTimePicker.Location = new System.Drawing.Point(121, 62);
               this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
               this.startTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
               this.startTimeDateTimePicker.TabIndex = 9;
               // 
               // buttonClose
               // 
               this.buttonClose.Location = new System.Drawing.Point(668, 27);
               this.buttonClose.Name = "buttonClose";
               this.buttonClose.Size = new System.Drawing.Size(75, 23);
               this.buttonClose.TabIndex = 4;
               this.buttonClose.Text = "Close";
               this.buttonClose.UseVisualStyleBackColor = true;
               this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
               // 
               // FormEvents
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(247)))));
               this.ClientSize = new System.Drawing.Size(800, 728);
               this.Controls.Add(this.buttonClose);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.pictureBoxEvents);
               this.Controls.Add(this.listBoxEvents);
               this.Name = "FormEvents";
               this.Text = "Events";
               ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).EndInit();
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.ListBox listBoxEvents;
          private System.Windows.Forms.PictureBox pictureBoxEvents;
          private System.Windows.Forms.BindingSource eventBindingSource;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.TextBox descriptionTextBox;
          private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
          private System.Windows.Forms.TextBox nameTextBox;
          private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
          private System.Windows.Forms.Button buttonClose;
     }
}