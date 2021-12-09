using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Forms
{
     public partial class FormEvents : Form
     {
          public FormEvents()
          {
               InitializeComponent();
               fetchEvents();
          }

          private void fetchEvents()
          {
               listBoxEvents.Items.Clear();
               listBoxEvents.DisplayMember = "Name";
               
               foreach (Event fbEvent in FacebookApiHelper.GetEventsList())
               {
                    listBoxEvents.Items.Add(fbEvent);
               }

               if (listBoxEvents.Items.Count == 0)
               {
                    MessageBox.Show("No Events to retrieve :(");
               }
          }

          private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
          {
               Event selectedEvent = listBoxEvents.SelectedItem as Event;
               loadEventImage(selectedEvent);
               markDate(selectedEvent);
               monthCalendarEvents.Show();
          }

          private void loadEventImage(Event i_SelectedEvent)
          {
               if (listBoxEvents.SelectedItems.Count == 1)
               {
                    pictureBoxEvents.LoadAsync(i_SelectedEvent.Cover.SourceURL);
               }
          }

          private void markDate(Event i_SelectedEvent)
          {
               if (i_SelectedEvent.StartTime != null)
               {
                    monthCalendarEvents.BoldedDates = new DateTime[]
                    {
                         (DateTime)i_SelectedEvent.StartTime
                    };
               }
          }
     }
}
