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
          private static readonly object sr_InstanceCreate = new object();
          private static User s_User;

          private static FacebookApiFacade s_Instance;

          public static FacebookApiFacade Instance
          {
               get
               {
                    if (s_Instance == null)
                    {
                         lock (sr_InstanceCreate)
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
               return s_User.Name;
          }

          public string GetUserImageURL()
          {
               return s_User.PictureNormalURL;
          }

          public FacebookObjectCollection<Post> GetPostsList()
          {
               return s_User.Posts;
          }

          public FacebookObjectCollection<Album> GetAlbumsList()
          {
               return s_User.Albums;
          }

          public FacebookObjectCollection<Event> GetEventsList()
          {
               return s_User.Events;
          }

          public FacebookObjectCollection<Group> GetGroupsList()
          {
               return s_User.Groups;
          }

          public FacebookObjectCollection<Page> GetLikedPagesList()
          {
               return s_User.LikedPages;
          }

          public FacebookObjectCollection<User> GetFriendsList()
          {
               return s_User.Friends;
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
               Dictionary<string, int> results = new Dictionary<string, int>();

               foreach (Page likedPage in GetLikedPagesList())
               {
                    if (likedPage.Category == null)
                    {
                         throw new Exception($"We can't show you you {likedPage.Name}'s category type right now.");
                    }

                    if (!results.ContainsKey(likedPage.Category))
                    {
                         results.Add(likedPage.Category, 0);
                    }

                    results[likedPage.Category]++;
               }

               return results;
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
