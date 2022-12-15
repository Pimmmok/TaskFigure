using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskFigure
{
    class Triangle : Figure
    {
        private double sideOne;
        private double sideTwo;
        private double sideThree;

        public Triangle(double sideOne, double sideTwo, double sideThree)
        {

            if (Exists(sideOne, sideTwo, sideThree))
            {
                this.sideOne = Math.Abs(sideOne);
                this.sideTwo = Math.Abs(sideTwo);
                this.sideThree = Math.Abs(sideThree);
                throw new TriangleException("Triangle with these sides doesnt exist");
            }
        }

        public bool CheckTriangleAsRectangular()
        {
            double[] sides = new double[] { this.sideOne, this.sideTwo, sideThree };
            IEnumerable<double> sidesOrder = sides.OrderBy(x => x);
            int i = 0;
            foreach (double side in sidesOrder)
            {
                sides[i] = side;
            }
            return sides[0] * sides[0] == sides[1] * sides[1] + sides[2] * sides[2];
        }

        public void GetSide(out double sideOne, out double sideTwo, out double sideThree)
        {
            sideOne = this.sideOne;
            sideTwo = this.sideTwo;
            sideThree = this.sideThree;
        }
        public void SetSide(double sideOne, double sideTwo, double sideThree)
        {
            if (Exists(sideOne, sideTwo, sideThree))
            {
                this.sideOne = Math.Abs(sideOne);
                this.sideTwo = Math.Abs(sideTwo);
                this.sideThree = Math.Abs(sideThree);
                throw new TriangleException("Triangle with these sides doesnt exist");
            }
        }

        private static bool Exists(double sideOne, double sideTwo, double sideThree)
        {
            return (sideOne + sideTwo > sideThree) && (sideTwo + sideThree > sideOne) && (sideOne + sideThree) > sideTwo;
        }

        public override double СalculateArea()
        {
            double halfPerimeter = (sideOne + sideTwo + sideThree) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sideOne) * (halfPerimeter - sideTwo) * (halfPerimeter - sideThree));
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

