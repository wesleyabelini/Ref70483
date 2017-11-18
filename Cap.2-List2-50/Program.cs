using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._2_List2_50
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangle retangle = new Retangle(15, 32);
            Console.WriteLine(retangle.Area);

            Retangle retSquare = new Square();
            retSquare.Width = 10;
            retSquare.Height = 5;

            Console.WriteLine(retSquare.Area);
        }
    }

    class Retangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Retangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area
        {
            get { return Height * Width; }
        }
    }

    class Square : Retangle
    {
        public override int Width
        {
            get { return base.Width; }
            set { base.Width = value; base.Height = value; }
        }

        public override int Height
        {
            get { return base.Height; }
            set { base.Height = value; base.Width = value; }
        }
    }
}
