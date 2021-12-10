using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookLogic;

namespace FacebookUI.Forms
{
     public partial class FormPersonalityStatistics : Form
     {
          private Dictionary<string, string> m_UserStatistics;

          private FacebookApiFacade FacebookApi { get; } = FacebookApiFacade.Instance;

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
                         "posts", FacebookApi.GetPostsList().Count.ToString()
                         },
                         {
                         "friends", FacebookApi.GetFriendsList().Count.ToString()
                         },
                         {
                         "events", FacebookApi.GetEventsList().Count.ToString()
                         },
                         {
                         "groups", FacebookApi.GetGroupsList().Count.ToString()
                         },
                         {
                         "likedPages", FacebookApi.GetLikedPagesList().Count.ToString()
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
                    Dictionary<string, int> likesByCategory = FacebookApi.GetLikesByCategory();
                    setStatisticsText(likesByCategory, FacebookApi.GetLikedPagesList().Count);
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