using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FacebookWinFormsApp.Iterators;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Forms
{
     public partial class FormPosts : Form
     {
          public List<PostObject> m_FavoritePosts;
          private Post m_CurrentSelectedPost;

          private FacebookApiFacade FacebookApi { get; } = FacebookApiFacade.Instance;

          public FormPosts()
          {
               loadFavoritesPosts();
               InitializeComponent();
               loadPostsList();

               Connection.LogoutDetected += resetContent;
          }

          private void resetContent()
          {
               m_CurrentSelectedPost = null;
               m_FavoritePosts = null;
               listBoxPosts.Items.Clear();
               pictureBoxPostImage.Image = null;
          }

          private void loadFavoritesPosts()
          {
               m_FavoritePosts = FilesHandler.GetFavoritePosts();
          }

          private void loadPostsList()
          {
               listBoxPosts.Items.Clear();
               IIterator postsIterator = FacebookApi.GetPostsIterator();

               while (postsIterator.MoveNext())
               {
                    insertPostToListBoxPosts(postsIterator.Current as Post);
               }

               if (listBoxPosts.Items.Count == 0)
               {
                    MessageBox.Show("No Posts to retrieve :(");
               }
          }

          private void insertPostToListBoxPosts(Post i_Post)
          {
               if (i_Post.Message != null)
               {
                    listBoxPosts.Items.Add(i_Post.Message);
               }
               else if (i_Post.Caption != null)
               {
                    listBoxPosts.Items.Add(i_Post.Caption);
               }
               else
               {
                    if (i_Post.Type == Post.eType.photo)
                    {
                         listBoxPosts.Items.Add(i_Post.PictureURL);
                    }
               }
          }

          private void buttonSetStatus_Click(object sender, EventArgs e)
          {
               try
               {
                    Status postedStatus = FacebookApi.PostStatus(textBoxStatus.Text);
                    MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString());
               }
          }

          private void listBoxPosts_MouseDown(object i_Sender, MouseEventArgs i_E)
          {
               handleMouseDown(i_Sender, i_E);
          }

          private void handleMouseDown(object i_Sender, MouseEventArgs i_E)
          {
               if (listBoxPosts.SelectedIndex >= 0)
               {
                    string selectedText = listBoxPosts.SelectedItem.ToString();
                    m_CurrentSelectedPost = FacebookApi.GetPostByText(selectedText);

                    if (i_E.Button == MouseButtons.Right && listBoxPosts.SelectedIndex >= 0)
                    {
                         MenuItem rightClickMenuItem;

                         if (isPostExistsInFavoritesList())
                         {
                              rightClickMenuItem = new MenuItem("Remove From Favorites");
                              rightClickMenuItem.Click += removePostFromFavoritesList;
                         }
                         else
                         {
                              rightClickMenuItem = new MenuItem("Add To Favorites");
                              rightClickMenuItem.Click += addPostToFavoritesList;
                         }

                         MenuItem[] mi = { rightClickMenuItem };
                         listBoxPosts.ContextMenu = new ContextMenu(mi);
                         listBoxPosts.ContextMenu.Show(listBoxPosts, new Point(i_E.X, i_E.Y));
                    }
               }
          }

          private bool isPostExistsInFavoritesList()
          {
               return m_FavoritePosts
                    .Any(favoritePost =>
                         favoritePost.m_CreatedTime == m_CurrentSelectedPost.CreatedTime);
          }

          private void removePostFromFavoritesList(object i_Sender, EventArgs i_E)
          {
               foreach (PostObject favoritePost in m_FavoritePosts
                    .Where(favoritePost =>
                         favoritePost.m_CreatedTime == m_CurrentSelectedPost.CreatedTime))
               {
                    m_FavoritePosts.Remove(favoritePost);
                    break;
               }

               FilesHandler.WritePostsListToFile(m_FavoritePosts);
               updateListBoxPosts();

               resetSelectedPost();
          }

          private void resetSelectedPost()
          {
               listBoxPosts.SelectedIndex = -1;
               m_CurrentSelectedPost = null;
               listBoxPosts.ContextMenu = new ContextMenu();
          }

          private void addPostToFavoritesList(object sender, EventArgs e)
          {
               string selectedText = listBoxPosts.SelectedItem.ToString();
               string postMessage = string.Empty;

               if (m_CurrentSelectedPost.Message != string.Empty)
               {
                    postMessage = m_CurrentSelectedPost.Message;
               }
               else if (m_CurrentSelectedPost.Description != string.Empty)
               {
                    postMessage = m_CurrentSelectedPost.Description;
               }

               PostObject p = new PostObject(
                    m_CurrentSelectedPost.CreatedTime,
                    selectedText,
                    postMessage,
                    m_CurrentSelectedPost.Link);

               m_FavoritePosts.Add(p);
               FilesHandler.WritePostsListToFile(m_FavoritePosts);
               resetSelectedPost();
          }

          private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
          {
               if (listBoxPosts.SelectedIndex >= 0)
               {
                    if (m_CurrentSelectedPost?.PictureURL != null)
                    {
                         pictureBoxPostImage.LoadAsync(m_CurrentSelectedPost.PictureURL);
                    }
                    else
                    {
                         pictureBoxPostImage.Image = null;
                    }
               }
          }

          private void checkBoxShowFavoritePosts_CheckedChanged(object sender, EventArgs e)
          {
               updateListBoxPosts();
          }

          private void updateListBoxPosts()
          {
               listBoxPosts.Items.Clear();
               pictureBoxPostImage.Image = null;

               // If we pressed "Show Favorite Posts"
               if (checkBoxShowFavoritePosts.Checked)
               {
                    foreach (PostObject favoritePost in m_FavoritePosts)
                    {
                         IIterator postsIterator = FacebookApi.GetPostsIterator();
                         while (postsIterator.MoveNext())
                         {
                              Post postFromUserData = postsIterator.Current as Post;

                              if (favoritePost.m_CreatedTime == postFromUserData.CreatedTime)
                              {
                                   listBoxPosts.Items.Add(favoritePost.m_Message);
                              }
                         }
                    }
               }
               else
               {
                    loadPostsList(); // If we de-selected "Show Favorite Posts"
               }
          }
     }
}
