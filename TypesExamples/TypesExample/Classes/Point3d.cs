using System;

namespace TypesExample.Classes
{
    // Sealed specifies that this class cannot be inherited
    sealed class Point3d : Point2d
    {
        int z;

        public Point3d(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        public override bool Equals(Object obj)
        {
            Point3d pt3 = obj as Point3d;
            if (pt3 == null)
                return false;
            else
                return base.Equals((Point2d)obj) && z == pt3.z;
        }

        public override int GetHashCode()
        {
            return (base.GetHashCode() << 2) ^ z;
        }

        public override String ToString()
        {
            return String.Format("Point({0}, {1}, {2})", x, y, z);
        }
    }
}
