using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
     public sealed class FacebookApiFacade
     {
          private const string k_PictureUrlStartString = "https://";
          private static readonly object sr_FacadeCreateLock = new object();
          private static User s_User;

          private static FacebookApiFacade s_Instance;

          #region Caching Proxy Data

          private readonly Dictionary<string, int> m_LikesByCategory;
          private string m_UsernameText;
          private string m_UserImageURL;
          private FacebookObjectCollection<Post> m_PostsList;
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
          }

          public LoginResult Login()
          {
               return FacebookService.Login(
                    "2016566511844897",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");
          }

          public void SetUser(User i_User)
          {
               s_User = i_User;
          }

          public string GetUsernameText()
          {
               if (m_UsernameText == string.Empty)
               {
                    m_UsernameText = s_User.Name;
               }

               return m_UsernameText;
          }

          public string GetUserImageURL()
          {
               if (string.IsNullOrEmpty(m_UserImageURL))
               {
                    m_UserImageURL = s_User.PictureNormalURL;
               }

               return m_UserImageURL;
          }

          public FacebookObjectCollection<Post> GetPostsList()
          {
               return m_PostsList ?? (m_PostsList = s_User.Posts);
          }

          public FacebookObjectCollection<Album> GetAlbumsList()
          {
               return m_AlbumsList ?? (m_AlbumsList = s_User.Albums);
          }

          public FacebookObjectCollection<Event> GetEventsList()
          {
               return m_EventsList ?? (m_EventsList = s_User.Events);
          }

          public FacebookObjectCollection<Group> GetGroupsList()
          {
               return m_GroupsList ?? (m_GroupsList = s_User.Groups);
          }

          public FacebookObjectCollection<Page> GetLikedPagesList()
          {
               return m_LikedPagesList ?? (m_LikedPagesList = s_User.LikedPages);
          }

          public FacebookObjectCollection<User> GetFriendsList()
          {
               return m_FriendsList ?? (m_FriendsList = s_User.Friends);
          }

          public FacebookObjectCollection<Page> GetSameLikedPagesList(FacebookObjectCollection<Page> i_SelectedFriendLikedPages)
          {
               FacebookObjectCollection<Page> commonLikedPages = new FacebookObjectCollection<Page>();

               foreach (Page userLikedPage in s_User.LikedPages)
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
               return s_User.PostStatus(i_Text);
          }

          public Post GetPostByText(string i_SelectedText)
          {
               return i_SelectedText.Contains(k_PictureUrlStartString)
                    ? s_User.Posts
                         .FirstOrDefault(post => post.PictureURL == i_SelectedText)
                    : s_User.Posts
                         .FirstOrDefault(post => post.Message == i_SelectedText);
          }
     }
}
