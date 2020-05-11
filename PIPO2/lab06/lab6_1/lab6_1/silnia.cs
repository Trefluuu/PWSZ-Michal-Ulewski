using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_1
{
    public class silnia
    {
        public int n;
        public int oblicz()
        {
            int wynik = 1;
            if (n < 1)
                return 1;
            else 
            { 
            while (n > 0)
            {
                wynik *= n;
                n--;
            }
            return wynik;
            }
        }
    }
}
