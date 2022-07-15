using IrCalculator.Servies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrCalculator.Servies
{
    public class Aliquot : IAliquot
    {
        public decimal Aliquot1 { get; }
        public decimal Aliquot2 { get; }
        public decimal Aliquot3 { get; }
        public decimal Aliquot4 { get; }
        public decimal Aliquot5 { get; }

        public Aliquot()
        {
            Aliquot1 = 0.0m;
            Aliquot2 = 0.075m;
            Aliquot3 = 0.150m;
            Aliquot4 = 0.225m;
            Aliquot5 = 0.275m;
        }

        public decimal GetAliquot(decimal amount)
        {
            switch (amount)
            {
                case <= 22847.76m:
                    return Aliquot1;
                case <= 33919.80m:
                    return Aliquot2;
                case <= 45012.61m:
                    return Aliquot3;
                case <= 55976.16m:
                    return Aliquot4;
                case > 55976.16m:
                    return Aliquot5;
            }

        }
    }
}
