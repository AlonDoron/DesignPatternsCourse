using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
     public partial class FormGroups : Form
     {
          private FacebookApiFacade FacebookApi { get; } = FacebookApiFacade.Instance;

          public FormGroups()
          {
               InitializeComponent();
               Connection.LogoutDetected += resetContent;
          }

          private void resetContent()
          {
               listBoxGroups = new ListBox();
               descriptionRichTextBox.Text = string.Empty;
               nameTextBox.Text = string.Empty;
               imageNormalPictureBox.Image = null;
          }

          public void LoadGroups()
          {
               try
               {
                    this.Invoke(new Action(() => groupBindingSource.DataSource = FacebookApi.GetGroupsList()));
               }
               catch (Exception e)
               {
                    MessageBox.Show(e.Message);
                    throw;
               }
          }
     }
}
