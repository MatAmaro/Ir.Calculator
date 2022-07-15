using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrCalculator.Presentation.Screm
{
    public class ScreenCalculator : IScreenCalculator
    {
        public void PrintTax(Tuple<decimal, decimal, decimal> tax, string name)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(name + Messages.Apresentation);
            sb.AppendLine(Messages.TaxResult + tax.Item1.ToString("C"));
            sb.AppendLine(Messages.AliquotUsed + tax.Item2.ToString("P01"));
            sb.AppendLine(Messages.DeductionUsed + tax.Item3.ToString("C"));
            sb.AppendLine(Messages.ThanksMessage);
            sb.AppendLine(Messages.ReturnMessage);
            ScreenPresenter.Show(sb.ToString());
        }
    }
}
