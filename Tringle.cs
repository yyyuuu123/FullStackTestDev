using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestApp.Model;

namespace TestApp
{
    public class Tringle : Figure
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        private double _sResult;

        public Tringle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Sides A,B,C must be > 0");

            SideA = a; SideB = b; SideC = c;
            _sResult = default(double);
        }

        public override string GetSomeName()
        {
            return "Tringle";
        }

        public override double GetAreaFigure()
        {
            _sResult = (SideA + SideB + SideC) / 2.0;
            return _sResult;
        }
    }
}
