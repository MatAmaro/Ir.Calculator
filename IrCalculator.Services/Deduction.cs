using IrCalculator.Servies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrCalculator.Servies
{
    public class Deduction : IDeduction
    {
        public decimal Deduction1 { get; }
        public decimal Deduction2 { get; }
        public decimal Deduction3 { get; }
        public decimal Deduction4 { get; }
        public decimal Deduction5 { get; }

        public Deduction()
        {
            Deduction1 = 0.0m;
            Deduction2 = 1713.58m;
            Deduction3 = 4257.57m;
            Deduction4 = 7633.51m;
            Deduction5 = 10432.32m;
        }



        public decimal GetDeduction(decimal amount)
        {
            switch (amount)
            {
                case <= 22847.76m:
                    return Deduction1;
                case <= 33919.80m:
                    return Deduction2;
                case <= 45012.61m:
                    return Deduction3;
                case <= 55976.16m:
                    return Deduction4;
                case > 55976.16m:
                    return Deduction5;
            }

        }
    }
}
