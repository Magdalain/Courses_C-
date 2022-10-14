using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Laboratornaya_8_9_10
{
    abstract class GraphObject : IColourful
    {
        public const string DEFAULT_COLOR = "black";
        public string Color;

        public GraphObject(string Color = DEFAULT_COLOR)
        {
            this.Color = Color;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Graphobject.{0}, this.Color");
        }
        static List<GraphObject> scene = new List<GraphObject>();
        public static void DrawScene()
        {
            foreach (GraphObject obj in scene)
                obj.Draw();
        }

        void IColourful.SetColor(string Color)
        {
            this.Color = Color;
        }

        public static void ScaleScene(string Color)
        {
            foreach (GraphObject obj in scene)
            {
                if (obj is IColourful)
                {
                    (obj as IColourful).SetColor(Color);
                }
            }
        }
    }


    internal class Program
    {



        static void Main(string[] args)
        {
            try
            {
                Circle circle = new Circle(2, 3, -1, "желтый");


                circle.Draw();


            }
            catch (ArgumentOutOfRangeException arg)
            {
                Console.WriteLine(arg.Message);


            }

        }
    }
}


