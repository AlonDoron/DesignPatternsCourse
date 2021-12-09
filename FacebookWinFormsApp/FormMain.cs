using System;
using System.Windows.Forms;
using FacebookUI.Forms;
using FacebookLogic;
using FacebookWrapper;

namespace FacebookUI
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

               LoginResult loginResult = FacebookApiHelper.Login();

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