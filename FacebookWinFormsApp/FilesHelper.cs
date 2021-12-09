﻿using System.Collections.Generic;
using System.IO;
using BasicFacebookFeatures.Forms;
using Newtonsoft.Json;

namespace BasicFacebookFeatures
{
     public static class FilesHelper
     {
          private const string k_FavoritesFile = "C:/temp/favorites.json";

          public static List<PostObject> GetFavoritePosts()
          {
               List<PostObject> favoritePosts = new List<PostObject>();

               if (File.Exists(k_FavoritesFile))
               {
                    string json = File.ReadAllText(k_FavoritesFile);

                    if (json != string.Empty)
                    {
                         favoritePosts = JsonConvert.DeserializeObject<List<PostObject>>(json);
                    }
               }

               return favoritePosts;
          }

          public static void WritePostsListToFile(List<PostObject> i_FavoritePosts)
          {
               string json = JsonConvert.SerializeObject(i_FavoritePosts, Formatting.Indented);

               File.WriteAllText(k_FavoritesFile, json == "[]" ? string.Empty : json);
          }
     }
}