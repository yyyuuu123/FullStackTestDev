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

        public override string GetName()
        {
            return "Tringle";
        }

        public override double GetArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            double area = Math.Sqrt(p * (p - SideA) * (p - SideA) * (p - SideC));
            return area;
        }

        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            double squareSide1 = Math.Pow(side1, 2);
            double squareSide2 = Math.Pow(side2, 2);
            double squareSide3 = Math.Pow(side3, 2);

            if (squareSide1 == squareSide2 + squareSide3 || squareSide2 == squareSide1 + squareSide3 || squareSide3 == squareSide1 + squareSide2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
