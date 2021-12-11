using System;
using System.Windows.Forms;
using FacebookWinFormsApp;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Forms
{
     public partial class FormEvents : Form
     {
          private FacebookApiFacade FacebookApi { get; } = FacebookApiFacade.Instance;

          public FormEvents()
          {
               InitializeComponent();
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
     }
}
