
namespace IrCalculator.Presentation.Screm
{
    public interface IScreenCalculator
    {
        void PrintTax(Tuple<decimal, decimal, decimal> tax, string name);
    }
}