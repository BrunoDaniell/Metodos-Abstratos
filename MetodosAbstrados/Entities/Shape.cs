
using MetodosAbstrados.Entities;
using MetodosAbstrados.Entities.Enums;

namespace MetodosAbstrados.Entities
{
    abstract class Shape
    {

        public Color Color { get; set; }

        
        protected Shape(Enums.Color color)
        {
            Color = color;
        }

        public abstract double Area();
        
    }
}
