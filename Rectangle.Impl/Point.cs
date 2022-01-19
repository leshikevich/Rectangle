using System;

namespace Rectangle.Impl
{
    public sealed class Point : IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int CompareTo(object obj)
        {
            if (obj is Point point)
            {
                if (X == point.X && Y == point.Y ||
                    Math.Abs(X) == Math.Abs(point.X) && Math.Abs(Y) == Math.Abs(point.Y)) return 0;
                if (Math.Abs(X) < Math.Abs(point.X) || Math.Abs(Y) < Math.Abs(point.Y)) return -1;
                if (Math.Abs(X) > Math.Abs(point.X) || Math.Abs(Y) > Math.Abs(point.Y)) return 1;
            }
            throw new ArgumentException("Invalid parameter value.");
        }


    }
}
