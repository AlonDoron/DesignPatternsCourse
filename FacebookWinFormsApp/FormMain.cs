using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BasicFacebookFeatures.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
     public partial class FormMain : Form
     {
          private Form m_ActiveForm;

          public FormMain()
          {
               InitializeComponent();
               FacebookService.s_CollectionLimit = 100;
          }

          private void buttonLogin_Click(object sender, EventArgs e)
          {
               Clipboard.SetText("alon121211@gmail.com");

               LoginResult loginResult = FacebookService.Login(
                    "2016566511844897",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");

               if (!string.IsNullOrEmpty(loginResult.AccessToken))
               {
                    FacebookApiHelper.SetUser(loginResult.LoggedInUser);

                    setUserImage(FacebookApiHelper.GetUserImageURL());

                    labelUsername.Text = FacebookApiHelper.GetUsernameText();

                    panelSidebar.Show();
                    buttonLogin.Hide();
               }
               else
               {
                    MessageBox.Show(loginResult.ErrorMessage, "Login Failed");
               }
          }

          private void setUserImage(string i_PictureURL)
          {
               pictureBoxProfile.LoadAsync(i_PictureURL);
          }

          private void buttonLogout_Click(object sender, EventArgs e)
          {
               FacebookService.LogoutWithUI();
               this.Close();
          }

          private void openChildForm(Form i_childForm, object sender)
          {
               m_ActiveForm?.Close();

               m_ActiveForm = i_childForm;
               i_childForm.TopLevel = false;
               i_childForm.FormBorderStyle = FormBorderStyle.None;
               i_childForm.Dock = DockStyle.Fill;
               this.panelForms.Controls.Add(i_childForm);
               this.panelForms.Tag = i_childForm;
               i_childForm.BringToFront();
               i_childForm.Show();

               labelTitle.Text = i_childForm.Text;
          }

          private void buttonPosts_Click(object sender, EventArgs e)
          {
               openChildForm(new FormPosts(), sender);
          }

          private void buttonGallery_Click(object sender, EventArgs e)
          {
               openChildForm(new FormGallery(), sender);
          }

          private void buttonEvents_Click(object sender, EventArgs e)
          {
               openChildForm(new FormEvents(), sender);
          }

          private void buttonGroups_Click(object sender, EventArgs e)
          {
               openChildForm(new FormGroups(), sender);
          }

          private void buttonLikedPages_Click(object sender, EventArgs e)
          {
               openChildForm(new FormLikedPages(), sender);
          }

          private void buttonFriends_Click(object sender, EventArgs e)
          {
               openChildForm(new FormFriends(), sender);
          }

          private void buttonPersonality_Click(object sender, EventArgs e)
          {
               openChildForm(new FormPersonalityStatistics(), sender);
          }
     }
}