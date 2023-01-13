using System;
using MetodosAbstrados.Entities.Enums;

namespace MetodosAbstrados.Entities
{
    internal class Circle : Shape
    {

        public double Raius { get; set; }

       
        public Circle(double raius, Color color) : base(color)
        {
            Raius = raius;
        }


        public override double Area()
        {
            return Math.PI * Raius * Raius;
        }
    }
}
