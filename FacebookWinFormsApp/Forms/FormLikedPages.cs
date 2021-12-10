using System;
using System.Windows.Forms;
using FacebookLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookUI.Forms
{
     public partial class FormLikedPages : Form
     {
          public FormLikedPages()
          {
               InitializeComponent();
               loadLikedPages();
          }

          private void loadLikedPages()
          {
               pageBindingSource.DataSource = FacebookApiFacade.GetLikedPagesList();
          }
     }
}
