using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookLogic;

namespace FacebookUI.Forms
{
     public partial class FormPersonalityStatistics : Form
     {
          private Dictionary<string, string> m_UserStatistics;

          public FormPersonalityStatistics()
          {
               InitializeComponent();
               initializeStatistics();
          }

          private void initializeStatistics()
          {
               m_UserStatistics = new Dictionary<string, string>
                    {
                         {
                         "posts", FacebookApiHandler.GetPostsList().Count.ToString()
                         },
                         {
                         "friends", FacebookApiHandler.GetFriendsList().Count.ToString()
                         },
                         {
                         "events", FacebookApiHandler.GetEventsList().Count.ToString()
                         },
                         {
                         "groups", FacebookApiHandler.GetGroupsList().Count.ToString()
                         },
                         {
                         "likedPages", FacebookApiHandler.GetLikedPagesList().Count.ToString()
                    }
                    };

               textBoxNumberOfPosts.Text = m_UserStatistics["posts"];
               textBoxNumberOfFriends.Text = m_UserStatistics["friends"];
               textBoxNumberOfEvents.Text = m_UserStatistics["events"];
               textBoxNumberOfGroups.Text = m_UserStatistics["groups"];
               textBoxNumberOfLikedPages.Text = m_UserStatistics["likedPages"];
               showCategoriesStatistics();
          }

          private void showCategoriesStatistics()
          {
               try
               {
                    Dictionary<string, int> likesByCategory = FacebookApiHandler.GetLikesByCategory();
                    setStatisticsText(likesByCategory, FacebookApiHandler.GetLikedPagesList().Count);
               }
               catch (Exception e)
               {
                    richTextBoxStatistics.Text = e.Message;
               }
          }

          private void setStatisticsText(Dictionary<string, int> i_PercentageOfLikesPerCategory, int i_LikedPagesCount)
          {
               foreach (KeyValuePair<string, int> pair in i_PercentageOfLikesPerCategory)
               {
                    richTextBoxStatistics.Text += $"You liked { pair.Value } pages in the category: { pair.Key } \n";
               }
          }
     }
}