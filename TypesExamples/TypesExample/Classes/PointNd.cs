#define DEBUG

using System.Linq;

namespace TypesExample.Classes
{
    public class PointNd
    {
        private int[] coordinates;

        public PointNd(int dimension)
        {
            this.coordinates = Enumerable.Repeat(0,dimension).ToArray();
        }
        public PointNd(params int[] coordinates)
        {
            this.coordinates = coordinates;
        }

        public override bool Equals(object obj)
        {
#if (DEBUG)
            var t = obj?.GetType().Equals(this.GetType()) ?? false;
            var s = ((PointNd)obj)?.coordinates == coordinates;
#endif
            return (obj?.GetType().Equals(this.GetType()) ?? false) && (((PointNd) obj)?.coordinates == coordinates);
        }

        public int Dimension()
        {
            return coordinates.Length;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
