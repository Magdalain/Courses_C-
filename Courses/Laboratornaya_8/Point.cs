using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_8_9_10
{
    internal class Point : GraphObject
    {
        public int X;
        public int Y;
        public Point(int x, int y, string Color = "DEFAULT_COLOR")
            : base(Color)
        {
            X = x;
            Y = y;
        }
        public void MoveBy(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
        public override void Draw()
        {
            Console.WriteLine($"Point ({X},{Y} this.Color");
        }
    }
}
