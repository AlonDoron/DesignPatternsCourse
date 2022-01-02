using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
     public partial class FormLikedPages : Form
     {
          private FacebookApiFacade FacebookApi { get; } = FacebookApiFacade.Instance;

          public FormLikedPages()
          {
               InitializeComponent();
               Connection.LogoutDetected += resetContent;
          }

          private void resetContent()
          {
               listBoxLikedPages.Text = string.Empty;
               nameTextBox.Text = string.Empty;
               descriptionRichTextBox.Text = string.Empty;
               imageNormalPictureBox.Image = null;
          }

          public void LoadLikedPages()
          {
               try
               {
                    this.Invoke(new Action(() => pageBindingSource.DataSource = FacebookApi.GetLikedPagesList()));
               }
               catch (Exception e)
               {
                    MessageBox.Show(e.Message);
                    throw;
               }
          }
     }
}
