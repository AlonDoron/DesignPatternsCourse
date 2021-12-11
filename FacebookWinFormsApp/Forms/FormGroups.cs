using System;
using System.Windows.Forms;
using FacebookWinFormsApp;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Forms
{
     public partial class FormGroups : Form
     {
          private FacebookApiFacade FacebookApi { get; } = FacebookApiFacade.Instance;

          public FormGroups()
          {
               InitializeComponent();
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
