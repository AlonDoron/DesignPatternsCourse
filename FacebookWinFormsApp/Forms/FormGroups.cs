﻿using System;
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
               foreach (Group group in FacebookApiHandler.GetGroupsList())
               {
                    listBoxGroups.Items.Add(group);
               }

               if (listBoxGroups.Items.Count == 0)
               {
                    listBoxGroups.Items.Add("You have no groups :(");
                    this.listBoxGroups.SelectedIndexChanged -= listBoxGroups_SelectedIndexChanged;
               }
          }

          private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
          {
               Group selectedGroup = listBoxGroups.SelectedItem as Group;
               pictureBoxGroup.Image = selectedGroup.ImageNormal;
          }
     }
}
