using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrCalculator.Servies.Interfaces
{
    public interface IAliquot
    {
        decimal Aliquot1 { get; }
        decimal Aliquot2 { get; }
        decimal Aliquot3 { get; }
        decimal Aliquot4 { get; }
        decimal Aliquot5 { get; }

        decimal GetAliquot(decimal amount);
    }
}
