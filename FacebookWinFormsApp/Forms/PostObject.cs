using System;

namespace FacebookWinFormsApp
{
     public class PostObject
     {
          public DateTime? m_CreatedTime;
          public string m_Message;
          public string m_Description;
          public string m_PictureUrl;

          public PostObject(DateTime? i_CreatedTime, string i_Message, string i_Description, string i_PictureUrl)
          {
               m_CreatedTime = i_CreatedTime;
               m_Message = i_Message;
               m_Description = i_Description;
               m_PictureUrl = i_PictureUrl;
          }

          public override string ToString()
          {
               return m_Message;
          }
     }
}