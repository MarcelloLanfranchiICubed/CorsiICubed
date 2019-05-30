using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExample.Classes
{
    public static class StaticAlgebra
    {
        public delegate int AlgebraicOperation(int operad1, int operad2);

        public static int Sum(int operad1, int operad2)
        {
            return operad1 + operad2;
        }

        public static int Product(int operad1, int operad2)
        {
            return operad1 * operad2;
        }
    }
}
