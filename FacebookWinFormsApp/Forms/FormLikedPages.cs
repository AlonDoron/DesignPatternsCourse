using System;
using System.Windows.Forms;
using FacebookLogic;

namespace FacebookUI.Forms
{
     public partial class FormLikedPages : Form
     {
          private FacebookApiFacade FacebookApi { get; } = FacebookApiFacade.Instance;

          public FormLikedPages()
          {
               InitializeComponent();
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
