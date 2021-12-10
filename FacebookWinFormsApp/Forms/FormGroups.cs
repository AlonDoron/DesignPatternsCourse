using System;
using System.Windows.Forms;
using FacebookLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookUI.Forms
{
     public partial class FormGroups : Form
     {
          private FacebookApiFacade FacebookApi { get; } = FacebookApiFacade.Instance;

          public FormGroups()
          {
               InitializeComponent();
               loadGroups();
          }

          private void loadGroups()
          {
               groupBindingSource.DataSource = FacebookApi.GetGroupsList();
          }
     }
}
