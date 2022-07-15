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
        private readonly IScreamClient _screamClient;
        private readonly IAliquot _aliquot;
        private readonly IDeduction _deduction;
        private readonly IScreamCalculator _screamCalculator;

        public MainFlow(ITaxCalculator calculator, IClient client, IScreamClient screamClient, IAliquot aliquot, IDeduction deduction, IScreamCalculator screamCalculator)
        {
            _calculator = calculator;
            _client = client;
            _screamClient = screamClient;
            _aliquot = aliquot;
            _deduction = deduction;
            _screamCalculator = screamCalculator;
        }

        public void CalculatorFlow()
        {
            _screamClient.NewName();
            _screamClient.NewTotalValue();
            var result = _calculator.TaxCalculation(_client, _aliquot, _deduction);
            _screamCalculator.PrintTax(result, _client.Name);

        }

        public void BeginApp()
        {
            CalculatorFlow();
        }


    }
}
