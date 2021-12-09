using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
     public class FacebookApiHelper
     {
          private const string k_PictureUrlStartString = "https://";
          private static User s_User;

          public static void SetUser(User i_User)
          {
               s_User = i_User;
          }

          public static string GetUsernameText()
          {
               return s_User.Name;
          }

          public static string GetUserImageURL()
          {
               return s_User.PictureNormalURL;
          }

          public static FacebookObjectCollection<Post> GetPostsList()
          {
               return s_User.Posts;
          }

          public static FacebookObjectCollection<Album> GetAlbumsList()
          {
               return s_User.Albums;
          }

          public static FacebookObjectCollection<Event> GetEventsList()
          {
               return s_User.Events;
          }

          public static FacebookObjectCollection<Group> GetGroupsList()
          {
               return s_User.Groups;
          }

          public static FacebookObjectCollection<Page> GetLikedPagesList()
          {
               return s_User.LikedPages;
          }

          public static FacebookObjectCollection<User> GetFriendsList()
          {
               return s_User.Friends;
          }

          public static FacebookObjectCollection<Page> GetSameLikedPagesList(FacebookObjectCollection<Page> i_SelectedFriendLikedPages)
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

          public static Dictionary<string, int> GetLikesByCategory()
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

          public static Status PostStatus(string i_Text)
          {
               return s_User.PostStatus(i_Text);
          }

          public static Post GetPostByText(string i_SelectedText)
          {
               return i_SelectedText.Contains(k_PictureUrlStartString)
                    ? s_User.Posts
                         .FirstOrDefault(post => post.PictureURL == i_SelectedText)
                    : s_User.Posts
                         .FirstOrDefault(post => post.Message == i_SelectedText);
          }
     }
}
