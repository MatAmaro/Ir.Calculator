
namespace IrCalculator.Presentation.Screm
{
    public interface IScreamCalculator
    {
        void PrintTax(Tuple<decimal, decimal, decimal> tax, string name);
    }
}