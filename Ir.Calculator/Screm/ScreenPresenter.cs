using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrCalculator.Presentation.Screm
{
    public static class ScreenPresenter
    {
        public static void Show(string screen)
        {
            Console.Clear();
            Console.WriteLine(Messages.Header);
            Console.WriteLine(screen);          
        }

    }
}



