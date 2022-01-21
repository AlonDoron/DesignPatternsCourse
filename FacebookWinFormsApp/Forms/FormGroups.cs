using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
     public partial class FormGroups : Form
     {
          private FacebookApiFacade FacebookApi { get; } = FacebookApiFacade.Instance;

          private readonly InitPageVisitor r_InitPageVisitor;

          public FormGroups()
          {
               InitializeComponent();
               Connection.LogoutDetected += resetContent;
               r_InitPageVisitor = new InitPageVisitor();
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

          private void buttonClose_Click(object sender, EventArgs e)
          {
               r_InitPageVisitor.ShowEffectAndGoToInitPage(this);
          }
     }
}
