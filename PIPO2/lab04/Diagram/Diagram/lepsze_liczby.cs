using System;
using System.Collections.Generic;
using System.Text;

namespace Diagram
{
    public class lepsze_liczby : liczby
    {
        protected int d;

        public lepsze_liczby(int a, int b, int c, int d) :base(a,b,c)
        {
            this.d = 0;
        }

        public int D
        {
            get => d;
            set => d = value;
            
        }
    }
}