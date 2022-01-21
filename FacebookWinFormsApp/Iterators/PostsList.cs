using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Iterators
{
     public interface IAggregate
     {
          IIterator CreateIterator();
     }

     public interface IIterator
     {
          bool MoveNext();

          object Current { get; }

          void Reset();
     }

     public class PostsList : IAggregate
     {
          private readonly List<Post> m_Posts;

          public PostsList(List<Post> i_ListOfPosts)
          {
               m_Posts = i_ListOfPosts;
          }

          public IIterator CreateIterator()
          {
               return new PostsIterator(this);
          }

          private class PostsIterator : IIterator
          {
               private readonly PostsList r_Aggregate;
               private readonly int r_Count;
               private int m_CurrentIdx = -1;

               public PostsIterator(PostsList i_Collection)
               {
                    r_Aggregate = i_Collection;
                    r_Count = r_Aggregate.m_Posts.Count;
               }

               public void Reset()
               {
                    m_CurrentIdx = -1;
               }

               public bool MoveNext()
               {
                    if (r_Count != r_Aggregate.m_Posts.Count)
                    {
                         throw new Exception("Posts Collection can not be changed during iteration!");
                    }

                    if (m_CurrentIdx >= r_Count)
                    {
                         throw new Exception("Already reached the end of the posts collection");
                    }

                    return ++m_CurrentIdx < r_Aggregate.m_Posts.Count;
               }

               public object Current
               {
                    get { return r_Aggregate.m_Posts[m_CurrentIdx]; }
               }
          }
     }
}
