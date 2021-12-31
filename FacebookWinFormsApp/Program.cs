﻿using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace FacebookWinFormsApp
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
               Application.Run(FormFactory.CreateFormByType(FormFactory.eFormType.FormMain));
          }
     }
}
