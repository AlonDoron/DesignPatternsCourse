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
               foreach (Page likedPage in FacebookApiHelper.GetLikedPagesList())
               {
                    listBoxLikedPages.Items.Add(likedPage);
               }
          }

          private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
          {
               if (listBoxLikedPages.SelectedItem is Page selectedPage)
               {
                    displayPageAbout(selectedPage);
               }
          }

          private void displayPageAbout(Page i_SelectedPage)
          {
               richTextBoxPageDetails.Text = i_SelectedPage.Description;
          }
     }
}
