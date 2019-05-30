namespace DelegateExample.Classes
{
    public class Algebra
    {
        public delegate int AlgebraicOperation(int operad1, int operad2);

        public int Sum(int operad1, int operad2)
        {
            return operad1 + operad2;
        }

        public int Product(int operad1, int operad2)
        {
            return operad1 * operad2;
        }
    }
}
