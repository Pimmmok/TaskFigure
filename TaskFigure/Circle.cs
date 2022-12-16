namespace TaskFigure
{
    public class Circle : Figure
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return this.radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public override double СalculateArea()
        {
            return radius * radius;
        }
        public override string ToString()
        {
            return new string("Circle: radius = "
                + this.radius.ToString());
        }
    }
}
