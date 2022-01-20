using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Forms
{
     public partial class FormEvents : Form
     {
          private FacebookApiFacade FacebookApi { get; } = FacebookApiFacade.Instance;

          private readonly InitPageVisitor r_InitPageVisitor;

          public FormEvents()
          {
               InitializeComponent();
               Connection.LogoutDetected += resetContent;
               r_InitPageVisitor = new InitPageVisitor();
          }

          private void resetContent()
          {
               listBoxEvents = new ListBox();
               pictureBoxEvents = new PictureBox();
          }

          public void FetchEvents()
          {
               try
               {
                    this.Invoke(new Action(() => eventBindingSource.DataSource = FacebookApi.GetEventsList()));
               }
               catch (Exception e)
               {
                    MessageBox.Show(e.Message);
                    throw;
               }
          }

          private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
          {
               if (listBoxEvents.SelectedItem is Event selectedEvent)
               {
                    loadEventImage(selectedEvent);
               }
          }

          private void loadEventImage(Event i_SelectedEvent)
          {
               if (listBoxEvents.SelectedItems.Count == 1)
               {
                    pictureBoxEvents.LoadAsync(i_SelectedEvent.Cover.SourceURL);
               }
          }

          private void button1_Click(object sender, EventArgs e)
          {
               r_InitPageVisitor.ShowEffectAndGoToInitPage(this);
          }
     }
}
