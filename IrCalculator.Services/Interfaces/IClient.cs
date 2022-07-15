using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrCalculator.Servies.Interfaces
{
    public interface IClient
    {
        string Name { get; protected set; }
        decimal TotalValue { get; protected set; }
        public void AddName(string name);
        public void AddTotalValue(decimal totalValue);

    }
}
