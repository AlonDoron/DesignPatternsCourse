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
               loadLikedPages();
          }

          private void loadLikedPages()
          {
               pageBindingSource.DataSource = FacebookApi.GetLikedPagesList();
          }
     }
}
