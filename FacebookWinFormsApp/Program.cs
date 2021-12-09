// $G$ THE-001 (-22) your grade on diagrams document - 69. please see comments inside the document. 40% of your grade).
// $G$ DSN-999 (-10) You should separate the logic and user interface into different classes.
using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
     public static class Program
     {
          /// <summary>
          /// The main entry point for the application.
          /// </summary>
          [STAThread]
          public static void Main()
          {
               FacebookService.s_UseForamttedToStrings = true;
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new FormMain());
          }
     }
}
