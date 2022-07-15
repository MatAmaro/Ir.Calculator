using IrCalculator.Servies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrCalculator.Presentation.Screm
{
    public class MainFlow : IMainFlow
    {
        private readonly ITaxCalculator _calculator;
        private readonly IClient _client;
        private readonly IScreenClient _screamClient;
        private readonly IAliquot _aliquot;
        private readonly IDeduction _deduction;
        private readonly IScreenCalculator _screamCalculator;
        private readonly IScreenMenu _screamMenu;

        public MainFlow(ITaxCalculator calculator, IClient client, IScreenClient screamClient, IAliquot aliquot, IDeduction deduction, IScreenCalculator screamCalculator, IScreenMenu screamMenu)
        {
            _calculator = calculator;
            _client = client;
            _screamClient = screamClient;
            _aliquot = aliquot;
            _deduction = deduction;
            _screamCalculator = screamCalculator;
            _screamMenu = screamMenu;
        }

        public void CalculatorFlow()
        {
            _screamClient.NewName();
            _screamClient.NewTotalValue();
            var result = _calculator.TaxCalculation(_client, _aliquot, _deduction);
            _screamCalculator.PrintTax(result, _client.Name);

        }

        public void MenuFlow()
        {
            var menu = _screamMenu.MenuPresentation();
            switch (menu)
            {
                case "1":
                    CalculatorFlow();
                    Console.ReadKey();
                    MenuFlow();
                    break;
                case "2":
                    _screamMenu.ScreamTable(_aliquot, _deduction);
                    Console.ReadKey();
                    MenuFlow();
                    break;
                case "3":
                    ScreenPresenter.Show(Messages.QuitMessage);
                    Console.ReadKey();
                    break;


            }
        }

        public void BeginApp()
        {
            MenuFlow();
        }


    }
}
