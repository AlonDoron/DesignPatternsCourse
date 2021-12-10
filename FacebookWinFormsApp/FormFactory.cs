using System;
using System.Windows.Forms;
using FacebookUI.Forms;

namespace FacebookUI
{
     public class FormFactory
     {
          public enum eFormType
          {
               FormMain,
               FormEvents,
               FormFriends,
               FormGallery,
               FormGroups,
               FormLikedPages,
               FormPersonalityStatistics,
               FormPosts
          }

          public static Form CreateFormByType(eFormType i_FormType)
          {
               Form selectedForm;

               switch (i_FormType)
               {
                    case eFormType.FormMain:
                         selectedForm = new FormMain();
                         break;
                    case eFormType.FormEvents:
                         selectedForm = new FormEvents();
                         break;
                    case eFormType.FormFriends:
                         selectedForm = new FormFriends();
                         break;
                    case eFormType.FormGallery:
                         selectedForm = new FormGallery();
                         break;
                    case eFormType.FormGroups:
                         selectedForm = new FormGroups();
                         break;
                    case eFormType.FormLikedPages:
                         selectedForm = new FormLikedPages();
                         break;
                    case eFormType.FormPersonalityStatistics:
                         selectedForm = new FormPersonalityStatistics();
                         break;
                    case eFormType.FormPosts:
                         selectedForm = new FormPosts();
                         break;
                    default:
                         throw new Exception("Can't create selected form.");
               }

               return selectedForm;
          }
     }
}
