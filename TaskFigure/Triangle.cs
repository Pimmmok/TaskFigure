using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskFigure
{
    public class Triangle : Figure
    {
        private double sideOne;
        private double sideTwo;
        private double sideThree;

        public Triangle() { }

        public Triangle(double sideOne, double sideTwo, double sideThree)
        {

            if (Exists(Math.Abs(sideOne), Math.Abs(sideTwo), Math.Abs(sideThree)))
            {
                this.sideOne = Math.Abs(sideOne);
                this.sideTwo = Math.Abs(sideTwo);
                this.sideThree = Math.Abs(sideThree);
            }
            else
            {

                throw new TriangleException("Triangle with these sides doesnt exist");
            }
        }

        public void GetSide(out double sideOne, out double sideTwo, out double sideThree)
        {
            sideOne = this.sideOne;
            sideTwo = this.sideTwo;
            sideThree = this.sideThree;
        }

        public void SetSide(double sideOne, double sideTwo, double sideThree)
        {
            if (Exists(Math.Abs(sideOne), Math.Abs(sideTwo), Math.Abs(sideThree)))
            {
                this.sideOne = Math.Abs(sideOne);
                this.sideTwo = Math.Abs(sideTwo);
                this.sideThree = Math.Abs(sideThree);
            }
            else
            {
                throw new TriangleException("Triangle with these sides doesnt exist");
            }
        }

        public static bool Exists(double sideOne, double sideTwo, double sideThree)
        {
            return (sideOne + sideTwo
                > sideThree) && (sideTwo + sideThree > sideOne) && (sideOne + sideThree) > sideTwo;
        }

        public override double СalculateArea()
        {
            double halfPerimeter = (this.sideOne + this.sideTwo + this.sideThree) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sideOne) * (halfPerimeter - this.sideTwo)
                * (halfPerimeter - this.sideThree));
        }

        public bool CheckTriangleAsRectangular()
        {
            double[] sides = new double[] { this.sideOne, this.sideTwo, sideThree};
            IEnumerable<double> sidesOrdered = sides.OrderBy(x => x);
            int i = 0;
            foreach (double side in sidesOrdered)
            {
                sides[i] = side;
                i++;
            }
            return sides[2] * sides[2] == (sides[1] * sides[1]) + sides[0] * sides[0];
        }

        public override string ToString()
        {
            return new string("Triangle : side one = "
                + sideOne.ToString()
                + ", side two = "
                + sideTwo.ToString()
                + ", side three = "
                + sideThree.ToString());
        }
    }
}

