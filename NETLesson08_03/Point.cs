using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLesson08_03
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            Y = y;
            X = x;
        }
    }

    public struct Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public bool IsPointInRectangle(Point taskas)
        {
            if (taskas.X <= BottomRight.X && taskas.X >= TopLeft.X && taskas.Y <= TopLeft.Y && taskas.Y >= BottomRight.Y) { return true; }
            else { return false; };

        }
    }
}
