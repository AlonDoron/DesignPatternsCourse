using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FacebookWinFormsApp
{
     public class InitPageVisitor
     {
          private readonly List<Color> r_ColorsToShow = new List<Color>
          {
               ColorTranslator.FromHtml("#CAF0F8"),
               ColorTranslator.FromHtml("#ADE8F4"),
               ColorTranslator.FromHtml("#90E0EF"),
               ColorTranslator.FromHtml("#48CAE4"),
               ColorTranslator.FromHtml("#00B4D8"),
               ColorTranslator.FromHtml("#0096C7"),
               ColorTranslator.FromHtml("#0077B6"),
               ColorTranslator.FromHtml("#023E8A"),
               ColorTranslator.FromHtml("#03045E"),
          };

          public void ShowEffectAndGoToInitPage(Form i_CurrentForm)
          {
               showEffect(i_CurrentForm);
               i_CurrentForm.Close();
          }

          private void showEffect(Form i_CurrentForm)
          {
               const int k_TimeoutMs = 50;

               foreach (Color shade in r_ColorsToShow)
               {
                    i_CurrentForm.BackColor = shade;
                    i_CurrentForm.Refresh();
                    Thread.Sleep(k_TimeoutMs);
               }
          }
     }
}