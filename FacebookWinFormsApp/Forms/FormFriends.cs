﻿using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
     public partial class FormFriends : Form
     {
          public FormFriends()
          {
               InitializeComponent();
               showFriendsList();
          }

          private void showFriendsList()
          {
               foreach (User friend in FacebookApiHelper.GetFriendsList())
               {
                    listBoxFriends.Items.Add(friend);
               }
          }

          private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
          {
               handleFriendPressed();
          }

          private void handleFriendPressed()
          {
               if (listBoxFriends.SelectedItem is User selectedFriend)
               {
                    displayFriendData(selectedFriend);
                    displayCommonLikedPages(selectedFriend);
               }
          }

          private void displayCommonLikedPages(User i_SelectedFriend)
          {
               listBoxCommonLikedPages.Items.Clear();

               foreach (Page page in FacebookApiHelper.GetSameLikedPagesList(i_SelectedFriend.LikedPages))
               {
                    listBoxCommonLikedPages.Items.Add(page);
               }
          }

          private void displayFriendData(User i_SelectedFriend)
          {
               pictureBoxFriendPicture.Image = i_SelectedFriend.ImageNormal;
               richTextBoxFriendDetails.Text = $@"Name: {i_SelectedFriend.Name}
Birth Day: {i_SelectedFriend.Birthday}
Gender: {i_SelectedFriend.Gender}
Latest Post: 
{i_SelectedFriend.Posts[0].Description}";
          }

          private void listBoxCommonLikedPages_SelectedIndexChanged(object sender, EventArgs e)
          {
               openLikedPageInBrowser();
          }

          private void openLikedPageInBrowser()
          {
               Page selectedPage = listBoxCommonLikedPages.SelectedItem as Page;
               string messageBoxText = "Would you like to open the selected page in your browser?";
               string messageBoxTitle = "Open Page";
               DialogResult result =
                    MessageBox.Show(messageBoxText, messageBoxTitle, MessageBoxButtons.YesNo);

               if (result == DialogResult.Yes)
               {
                    if (selectedPage != null)
                    {
                         System.Diagnostics.Process.Start(selectedPage.URL);
                    }
               }
          }
     }
}
