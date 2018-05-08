using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhepToanPhanSo
{
    class lopdungchungcs
    {
        public static int UCLN(int a, int b)
        {
            int a1 = Math.Abs(a);
            int b1 = Math.Abs(b);
            if (b1 == 0)
                return a1;
            return UCLN(b1, a1 % b1);
        }
    }
}
