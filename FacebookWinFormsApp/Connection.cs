using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
     public static class Connection
     {
          public static User User { get; private set; }

          public static event Action LoginDetected;

          public static event Action LogoutDetected;

          private const string k_FacebookAppId = "2016566511844897";

          public static void Login()
          {
               LoginResult loginResult = FacebookService.Login(
                    k_FacebookAppId,
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

               User = loginResult.LoggedInUser;

               LoginDetected?.Invoke();
          }

          public static void Logout()
          {
               FacebookService.Logout();
               User = null;
               LogoutDetected?.Invoke();
          }
     }
}
