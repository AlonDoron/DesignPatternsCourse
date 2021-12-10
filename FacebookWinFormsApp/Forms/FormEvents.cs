﻿using System;
using System.Windows.Forms;
using FacebookLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookUI.Forms
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
               eventBindingSource.DataSource = FacebookApiFacade.GetEventsList();
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
