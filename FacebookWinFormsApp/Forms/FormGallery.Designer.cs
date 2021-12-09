namespace BasicFacebookFeatures.Forms
{
     public partial class FormGallery
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
               this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
               this.listBoxPhotos = new System.Windows.Forms.ListBox();
               this.buttonAlbums = new System.Windows.Forms.Button();
               this.buttonShowAllPhotos = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
               this.SuspendLayout();
               // 
               // pictureBoxAlbum
               // 
               this.pictureBoxAlbum.Location = new System.Drawing.Point(220, 241);
               this.pictureBoxAlbum.Name = "pictureBoxAlbum";
               this.pictureBoxAlbum.Size = new System.Drawing.Size(327, 189);
               this.pictureBoxAlbum.TabIndex = 60;
               this.pictureBoxAlbum.TabStop = false;
               // 
               // listBoxPhotos
               // 
               this.listBoxPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(247)))));
               this.listBoxPhotos.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.listBoxPhotos.FormattingEnabled = true;
               this.listBoxPhotos.Location = new System.Drawing.Point(220, 75);
               this.listBoxPhotos.Name = "listBoxPhotos";
               this.listBoxPhotos.Size = new System.Drawing.Size(327, 143);
               this.listBoxPhotos.TabIndex = 59;
               this.listBoxPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotos_SelectedIndexChanged);
               // 
               // buttonAlbums
               // 
               this.buttonAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(123)))), ((int)(((byte)(181)))));
               this.buttonAlbums.FlatAppearance.BorderSize = 0;
               this.buttonAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonAlbums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(165)))), ((int)(((byte)(122)))));
               this.buttonAlbums.Location = new System.Drawing.Point(184, 33);
               this.buttonAlbums.Name = "buttonAlbums";
               this.buttonAlbums.Size = new System.Drawing.Size(177, 23);
               this.buttonAlbums.TabIndex = 61;
               this.buttonAlbums.Text = "Albums";
               this.buttonAlbums.UseVisualStyleBackColor = false;
               this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
               // 
               // buttonShowAllPhotos
               // 
               this.buttonShowAllPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(123)))), ((int)(((byte)(181)))));
               this.buttonShowAllPhotos.FlatAppearance.BorderSize = 0;
               this.buttonShowAllPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonShowAllPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonShowAllPhotos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(165)))), ((int)(((byte)(122)))));
               this.buttonShowAllPhotos.Location = new System.Drawing.Point(404, 33);
               this.buttonShowAllPhotos.Name = "buttonShowAllPhotos";
               this.buttonShowAllPhotos.Size = new System.Drawing.Size(170, 23);
               this.buttonShowAllPhotos.TabIndex = 62;
               this.buttonShowAllPhotos.Text = "Show All Photos";
               this.buttonShowAllPhotos.UseVisualStyleBackColor = false;
               this.buttonShowAllPhotos.Click += new System.EventHandler(this.buttonShowAllPhotos_Click);
               // 
               // FormGallery
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(221)))), ((int)(((byte)(247)))));
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.buttonShowAllPhotos);
               this.Controls.Add(this.buttonAlbums);
               this.Controls.Add(this.pictureBoxAlbum);
               this.Controls.Add(this.listBoxPhotos);
               this.Name = "FormGallery";
               this.Text = "Gallery";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion
          private System.Windows.Forms.PictureBox pictureBoxAlbum;
          private System.Windows.Forms.ListBox listBoxPhotos;
          private System.Windows.Forms.Button buttonAlbums;
          private System.Windows.Forms.Button buttonShowAllPhotos;
     }
}