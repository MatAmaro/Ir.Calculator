using IrCalculator.Servies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrCalculator.Servies
{
    public class Calculator : ITaxCalculator
    {
        public Tuple<decimal, decimal, decimal> TaxCalculation(IClient client, IAliquot aliquot, IDeduction deduction)
        {
            decimal tax;
            var amount = client.TotalValue;
            tax = (amount * aliquot.GetAliquot(amount)) - deduction.GetDeduction(amount);
            var Tax_Aliquot_Deduction = Tuple.Create(tax, aliquot.GetAliquot(amount), deduction.GetDeduction(amount));
            return Tax_Aliquot_Deduction;

        }

    }
}
