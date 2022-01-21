using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWinFormsApp.Iterators;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
     public sealed class FacebookApiFacade
     {
          private const string k_PictureUrlStartString = "https://";
          private static readonly object sr_FacadeCreateLock = new object();

          private static FacebookApiFacade s_Instance;

          #region Caching Proxy Data

          private Dictionary<string, int> m_LikesByCategory;
          private string m_UsernameText;
          private string m_UserImageURL;
          private PostsList m_PostsList;
          private FacebookObjectCollection<Album> m_AlbumsList;
          private FacebookObjectCollection<Event> m_EventsList;
          private FacebookObjectCollection<Group> m_GroupsList;
          private FacebookObjectCollection<Page> m_LikedPagesList;
          private FacebookObjectCollection<User> m_FriendsList;

          #endregion

          public static FacebookApiFacade Instance
          {
               get
               {
                    if (s_Instance == null)
                    {
                         lock (sr_FacadeCreateLock)
                         {
                              if (s_Instance == null)
                              {
                                   s_Instance = new FacebookApiFacade();
                              }
                         }
                    }

                    return s_Instance;
               }
          }

          private FacebookApiFacade()
          {
               m_LikesByCategory = new Dictionary<string, int>();
               Connection.LogoutDetected += resetFacade;
          }

          private void resetFacade()
          {
               m_UsernameText = string.Empty;
               m_UserImageURL = string.Empty;
               m_LikesByCategory = null;
               m_PostsList = null;
               m_AlbumsList = null;
               m_EventsList = null;
               m_GroupsList = null;
               m_LikedPagesList = null;
               m_FriendsList = null;
          }

          public string GetUsernameText()
          {
               if (Connection.IsLoggedIn() && m_UsernameText == string.Empty)
               {
                    m_UsernameText = Connection.User.Name;
               }

               return m_UsernameText;
          }

          public string GetUserImageURL()
          {
               if (Connection.IsLoggedIn() && string.IsNullOrEmpty(m_UserImageURL))
               {
                    m_UserImageURL = Connection.User.PictureNormalURL;
               }

               return m_UserImageURL;
          }

          private void setPostsListFromApi()
          {
               List<Post> tempPostsList = Connection.User.Posts.ToList();

               m_PostsList = new PostsList(tempPostsList);
          }

          public IIterator GetPostsIterator()
          {
               if (Connection.IsLoggedIn())
               {
                    if (m_PostsList == null)
                    {
                         setPostsListFromApi();
                    }

                    return m_PostsList.CreateIterator();
               }

               return null;
          }

          public FacebookObjectCollection<Album> GetAlbumsList()
          {
               if (Connection.IsLoggedIn())
               {
                    return m_AlbumsList ?? (m_AlbumsList = Connection.User.Albums);
               }

               return null;
          }

          public FacebookObjectCollection<Event> GetEventsList()
          {
               if (Connection.IsLoggedIn())
               {
                    return m_EventsList ?? (m_EventsList = Connection.User.Events);
               }

               return null;
          }

          public FacebookObjectCollection<Group> GetGroupsList()
          {
               if (Connection.IsLoggedIn())
               {
                    return m_GroupsList ?? (m_GroupsList = Connection.User.Groups);
               }

               return null;
          }

          public FacebookObjectCollection<Page> GetLikedPagesList()
          {
               if (Connection.IsLoggedIn())
               {
                    return m_LikedPagesList ?? (m_LikedPagesList = Connection.User.LikedPages);
               }

               return null;
          }

          public FacebookObjectCollection<User> GetFriendsList()
          {
               if (Connection.IsLoggedIn())
               {
                    return m_FriendsList ?? (m_FriendsList = Connection.User.Friends);
               }

               return null;
          }

          public FacebookObjectCollection<Page> GetSameLikedPagesList(FacebookObjectCollection<Page> i_SelectedFriendLikedPages)
          {
               FacebookObjectCollection<Page> commonLikedPages = new FacebookObjectCollection<Page>();

               if (!Connection.IsLoggedIn())
               {
                    return null;
               }

               foreach (Page userLikedPage in Connection.User.LikedPages)
               {
                    foreach (Page selectedFriendLikedPage in i_SelectedFriendLikedPages)
                    {
                         if (userLikedPage.Name == selectedFriendLikedPage.Name)
                         {
                              commonLikedPages.Add(selectedFriendLikedPage);
                         }
                    }
               }

               return commonLikedPages;
          }

          public Dictionary<string, int> GetLikesByCategory()
          {
               if (m_LikesByCategory.Count != 0)
               {
                    return m_LikesByCategory;
               }

               foreach (Page likedPage in GetLikedPagesList())
               {
                    if (likedPage.Category == null)
                    {
                         throw new Exception($"We can't show you you {likedPage.Name}'s category type right now.");
                    }

                    if (!m_LikesByCategory.ContainsKey(likedPage.Category))
                    {
                         m_LikesByCategory.Add(likedPage.Category, 0);
                    }

                    m_LikesByCategory[likedPage.Category]++;
               }

               return m_LikesByCategory;
          }

          public Status PostStatus(string i_Text)
          {
               return Connection.User.PostStatus(i_Text);
          }

          public Post GetPostByText(string i_SelectedText)
          {
               return i_SelectedText.Contains(k_PictureUrlStartString)
                    ? Connection.User.Posts
                         .FirstOrDefault(post => post.PictureURL == i_SelectedText)
                    : Connection.User.Posts
                         .FirstOrDefault(post => post.Message == i_SelectedText);
          }
     }
}
