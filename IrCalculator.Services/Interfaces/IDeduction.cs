using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrCalculator.Servies.Interfaces
{
    public interface IDeduction
    {
        decimal Deduction1 { get; }
        decimal Deduction2 { get; }
        decimal Deduction3 { get; }
        decimal Deduction4 { get; }
        decimal Deduction5 { get; }

        decimal GetDeduction(decimal amount);
    }
}
