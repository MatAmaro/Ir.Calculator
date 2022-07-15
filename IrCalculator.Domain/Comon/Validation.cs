using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrCalculator.Domain.Comon
{
    public static class Validation
    {

        private static string CapitalizeLettersAfterSpace(string text)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(text);
        }
        public static string DefaultTextFormat(string userInput)
        {
            return CapitalizeLettersAfterSpace(userInput).Trim();
        }
    }
}
