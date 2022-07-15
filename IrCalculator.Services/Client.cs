using IrCalculator.Servies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrCalculator.Servies
{
    public class Client: IClient
    {
        
        public string Name { get;  set; }
        public decimal TotalValue { get; set; }


        
        public void AddName(string name)
        {
            Name = name;
        }
        public void AddTotalValue(decimal totalValue)
        {
            TotalValue = totalValue;
        }


    }
}
