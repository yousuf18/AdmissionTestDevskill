using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FractionPrinter
    {
        public string Print(int numerator, int denominator, int count)
        {
            var item = (double)numerator / (double)denominator;
            var str = item.ToString();
            Console.WriteLine(str);
            var decimalPart = str.Split('.')[0];
            var fractionpart = str.Split('.')[1];
            if(count<=fractionpart.Length)
            fractionpart = fractionpart.Substring(0, count);
            str = decimalPart + '.' + fractionpart;

            return str;
        }
    }
}
