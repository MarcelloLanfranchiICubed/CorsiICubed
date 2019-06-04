using System;

namespace TypesExample.Classes
{
    class Point2d
    {
        // This fields are protected because of inheritance
        protected int x, y;

        public Point2d() : this(0, 0)
        {
        }

        public Point2d(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Point2d p = (Point2d) obj;
                return (x == p.x) && (y == p.y);
            }
        }

        public override int GetHashCode()
        {
            return (x + 2) ^ y;
        }

        public override string ToString()
        {
            return String.Format("Point({0}, {1})", x, y);
        }
    }
}
