using System;
using System.Windows.Forms;
using FacebookLogic;
using FacebookWrapper;

namespace FacebookUI
{
     public partial class FormMain : Form
     {
          private Form m_ActiveForm;

          private FacebookApiFacade FacebookApi { get; } = FacebookApiFacade.Instance;

          public FormMain()
          {
               InitializeComponent();
               FacebookService.s_CollectionLimit = 100;
          }

          private void buttonLogin_Click(object sender, EventArgs e)
          {
               Clipboard.SetText("alon121211@gmail.com");

               LoginResult loginResult = FacebookApi.Login();

               if (!string.IsNullOrEmpty(loginResult.AccessToken))
               {
                    FacebookApi.SetUser(loginResult.LoggedInUser);

                    setUserImage(FacebookApi.GetUserImageURL());

                    labelUsername.Text = FacebookApi.GetUsernameText();

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

          private void openChildForm(Form i_childForm)
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
               Form formPosts = FormFactory.CreateFormByType(FormFactory.eFormType.FormPosts);
               openChildForm(formPosts);
          }

          private void buttonGallery_Click(object sender, EventArgs e)
          {
               Form formGallery = FormFactory.CreateFormByType(FormFactory.eFormType.FormGallery);
               openChildForm(formGallery);
          }

          private void buttonEvents_Click(object sender, EventArgs e)
          {
               Form formEvents = FormFactory.CreateFormByType(FormFactory.eFormType.FormEvents);
               openChildForm(formEvents);
          }

          private void buttonGroups_Click(object sender, EventArgs e)
          {
               Form formGroups = FormFactory.CreateFormByType(FormFactory.eFormType.FormGroups);
               openChildForm(formGroups);
          }

          private void buttonLikedPages_Click(object sender, EventArgs e)
          {
               Form formLikedPages = FormFactory.CreateFormByType(FormFactory.eFormType.FormLikedPages);
               openChildForm(formLikedPages);
          }

          private void buttonFriends_Click(object sender, EventArgs e)
          {
               Form formFriends = FormFactory.CreateFormByType(FormFactory.eFormType.FormFriends);
               openChildForm(formFriends);
          }

          private void buttonPersonality_Click(object sender, EventArgs e)
          {
               Form formPersonalityStatistics = FormFactory.CreateFormByType(FormFactory.eFormType.FormPersonalityStatistics);
               openChildForm(formPersonalityStatistics);
          }
     }
}