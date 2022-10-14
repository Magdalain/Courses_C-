using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_8_9_10
{
    internal class Circle : GraphObject
    {
        public int x;
        public int y;
        private int _radius;
        public int Radius
        {
            get => _radius;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Radius), "Радиус отрицательный");
                }
                _radius = value;
            }
        }

        public Circle(int x, int y, int radius, string Color = "DEFAULT_COLOR")
            : base(Color)
        {
            this.x = x;
            this.y = y;
            Radius = radius;
        }
        public void Scale(double f)
        {
            Radius = (int)(f * Radius);

        }
        public override void Draw()
        {
            Console.WriteLine($"Circle: ({x},{y}). R: {Radius}. {Color}");
        }
    }
}
