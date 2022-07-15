using IrCalculator.Servies.Interfaces;

namespace IrCalculator.Presentation.Screm
{
    public interface IScreenMenu
    {
        string MenuPresentation();
        void ScreamTable(IAliquot aliquot, IDeduction deduction);
    }
}