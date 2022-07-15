using IrCalculator.Domain.Comon;
using IrCalculator.Servies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrCalculator.Presentation.Screm
{
    public class ScreenClient : IScreenClient

    {
        private readonly IClient _client;

        public ScreenClient(IClient client)
        {
            _client = client;
        }
        
        public void NewName()
        {
            bool correctInput = false;
            while (!correctInput)
            {
                ScreenPresenter.Show(Messages.NameMessage);
                var InputName = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(InputName))
                {
                    var name = Validation.DefaultTextFormat(InputName);
                    _client.AddName(name);
                    correctInput = true;
                }
                else
                {
                    ScreenPresenter.Show(Messages.Invalid);
                    Console.ReadKey();
                }                            
            }
           


        }

        public void NewTotalValue()
        {
            bool correctInput = false;
            while (!correctInput)
            {
                ScreenPresenter.Show(Messages.TotalValueMessage);
                var newTotalValue = Console.ReadLine();
                bool validNewTotalValue = decimal.TryParse(newTotalValue, out decimal InputTotalValue);
                if (validNewTotalValue && InputTotalValue > 0)
                {
                    _client.AddTotalValue(InputTotalValue);
                    correctInput=true;
                }
                else
                {
                    ScreenPresenter.Show(Messages.Invalid);
                    Console.ReadKey();
                }
            }
                
        }
    }
}
