using System;
using ExResolvidoClasseAbstrata.Entities.Enums;

namespace ExResolvidoClasseAbstrata.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
