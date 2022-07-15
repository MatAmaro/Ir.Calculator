using IrCalculator.Servies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrCalculator.Presentation.Screm
{
    public class ScreenMenu : IScreenMenu
    {
        public string MenuPresentation()
        {
            ScreenPresenter.Show(Messages.MainMenu);
            var inputMenu = Console.ReadLine();
            switch (inputMenu)
            {
                case "1":
                    return "1";
                case "2":
                    return "2";
                case "3":
                    return "3";
                default:
                    ScreenPresenter.Show(Messages.Invalid);
                    Console.ReadKey();
                    return MenuPresentation();
            }

        }

        public void ScreamTable(IAliquot aliquot, IDeduction deduction)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Messages.TableAmount + "R$22.847,76" + Messages.TableAliqout + aliquot.Aliquot1.ToString("P01") + Messages.TableDeduction + deduction.Deduction1.ToString("C"));
            sb.AppendLine(Messages.TableAmount + "R$33.919,80" + Messages.TableAliqout + aliquot.Aliquot2.ToString("P01") + Messages.TableDeduction + deduction.Deduction2.ToString("C"));
            sb.AppendLine(Messages.TableAmount + "R$45.012,60" + Messages.TableAliqout + aliquot.Aliquot3.ToString("P01") + Messages.TableDeduction + deduction.Deduction3.ToString("C"));
            sb.AppendLine(Messages.TableAmount + "R$55.976,16" + Messages.TableAliqout + aliquot.Aliquot4.ToString("P01") + Messages.TableDeduction + deduction.Deduction4.ToString("C"));
            sb.AppendLine(Messages.TableAmount_ + "R$55.976,16" + Messages.TableAliqout + aliquot.Aliquot5.ToString("P01") + Messages.TableDeduction + deduction.Deduction5.ToString("C"));
            sb.AppendLine(Messages.ReturnMessage);
            ScreenPresenter.Show(sb.ToString());

        }
    }
}
