using System;
using System.Windows.Forms;
using FacebookLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookUI.Forms
{
     public partial class FormGroups : Form
     {
          public FormGroups()
          {
               InitializeComponent();
               loadGroups();
          }

          private void loadGroups()
          {
               groupBindingSource.DataSource = FacebookApiFacade.GetGroupsList();
          }
     }
}
