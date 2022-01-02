using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Forms
{
     public partial class FormFriends : Form
     {
          private FacebookApiFacade FacebookApi { get; } = FacebookApiFacade.Instance;

          public FormFriends()
          {
               InitializeComponent();
               Connection.LogoutDetected += InitializeComponent;
          }

          public void ShowFriendsList()
          {
               try
               {
                    this.Invoke(new Action(() => membersBindingSource.DataSource = FacebookApi.GetFriendsList()));
               }
               catch (Exception e)
               {
                    MessageBox.Show(e.Message);
                    throw;
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

               foreach (Page page in FacebookApi.GetSameLikedPagesList(i_SelectedFriend.LikedPages))
               {
                    listBoxCommonLikedPages.Items.Add(page);
               }
          }

          private void displayFriendData(User i_SelectedFriend)
          {
               pictureBoxFriendPicture.Image = i_SelectedFriend.ImageNormal;
               richTextBoxFriendDetails.Text = i_SelectedFriend.Posts[0].Description;
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
