using System;
using System.Windows.Forms;
using FacebookLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookUI.Forms
{
     public partial class FormGallery : Form
     {
          public FormGallery()
          {
               InitializeComponent();
          }

          private void loadAlbumsList()
          {
               listBoxPhotos.Items.Clear();

               foreach (Album album in FacebookApiHelper.GetAlbumsList())
               {
                    listBoxPhotos.Items.Add(album);
               }

               if (listBoxPhotos.Items.Count == 0)
               {
                    listBoxPhotos.Items.Add("No albums :(");
               }
          }

          private void loadImagesList()
          {
               listBoxPhotos.Items.Clear();

               foreach (Album album in FacebookApiHelper.GetAlbumsList())
               {
                    foreach (Photo albumPhoto in album.Photos)
                    {
                         listBoxPhotos.Items.Add(albumPhoto);
                    }
               }

               if (listBoxPhotos.Items.Count == 0)
               {
                    listBoxPhotos.Items.Add("No tagged photos :(");
               }
          }

          private void listBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
          {
               displayPhotos();
          }

          private void displayPhotos()
          {
               if (listBoxPhotos.SelectedItems.Count == 1)
               {
                    if (listBoxPhotos.SelectedItem.GetType().Name == "Album")
                    {
                         Album selectedAlbum = listBoxPhotos.SelectedItem as Album;
                         pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                    }
                    else
                    {
                         Photo selectedPhoto = listBoxPhotos.SelectedItem as Photo;

                         if (selectedPhoto.PictureAlbumURL != null)
                         {
                              pictureBoxAlbum.LoadAsync(selectedPhoto.PictureAlbumURL);
                         }
                         else
                         {
                              pictureBoxAlbum.Image = pictureBoxAlbum.ErrorImage;
                         }
                    }
               }
          }

          private void buttonAlbums_Click(object sender, EventArgs e)
          {
               loadAlbumsList();
          }

          private void buttonShowAllPhotos_Click(object sender, EventArgs e)
          {
               loadImagesList();
          }
     }
}