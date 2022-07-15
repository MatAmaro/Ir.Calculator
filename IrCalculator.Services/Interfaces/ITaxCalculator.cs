using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrCalculator.Servies.Interfaces
{
    public interface ITaxCalculator
    {
        Tuple<decimal, decimal, decimal> TaxCalculation(IClient client, IAliquot aliquot, IDeduction deduction);
    }
}
