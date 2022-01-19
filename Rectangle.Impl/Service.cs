using System;
using System.Collections.Generic;

namespace Rectangle.Impl
{
    public static class Service
    {
        /// <summary>
        /// See TODO.txt file for task details.
        /// Do not change contracts: input and output arguments, method name and access modifiers
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        /// 



        public static Rectangle FindRectangle(List<Point> points)
        {
            if (ValidationPoints(points))
            {
                points.Sort();//Sort by distance from the point (0, 0). Implemented interface IComparable.
                points.RemoveAt(points.Count - 1); //Removing the furthest point from (0, 0).

                int width = Math.Abs(points[0].X) + Math.Abs(points[points.Count - 1].X);
                int height = Math.Abs(points[0].X) + Math.Abs(points[points.Count - 1].X);
                int x = points[0].X;
                int y = points[0].Y;

                return new Rectangle(x, y, width, height);
            }
            return null;
        }

        private static bool ValidationPoints(List<Point> points)
        {
            if (points == null || points.Count <= 1)
            {
                throw new ArgumentException("The list must contain two or more points.");
            }

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = 0; j < points.Count; j++)
                {
                    if ( points[i].X == points[j].X && points[i].Y == points[j].Y && i != j )
                    {
                        throw new ArgumentException("The list must not contain the same points");
                    }
                }
            }

            return true;
        }
    }
}
