using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Model;

namespace TestApp
{
    public class Circle : Figure
    {
        const double PI = Math.PI;

        public double Radius { get; set; }

        private double _sResult;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius must be > 0", nameof(radius));
            Radius = radius;
            _sResult = default;
        }

        public override string GetSomeName()
        {
            return "Circle";
        }

        public override double GetAreaFigure()
        {
            _sResult = (Radius * Radius) * PI;
            return Math.Round(_sResult, 3);
        }
    }
}
