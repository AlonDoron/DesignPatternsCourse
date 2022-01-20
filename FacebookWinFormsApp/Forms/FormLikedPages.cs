using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
     public partial class FormLikedPages : Form
     {
          private FacebookApiFacade FacebookApi { get; } = FacebookApiFacade.Instance;

          private readonly InitPageVisitor r_InitPageVisitor;

          public FormLikedPages()
          {
               InitializeComponent();
               Connection.LogoutDetected += resetContent;
               r_InitPageVisitor = new InitPageVisitor();
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

          private void button1_Click(object sender, EventArgs e)
          {
               r_InitPageVisitor.ShowEffectAndGoToInitPage(this);
          }
     }
}
