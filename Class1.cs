using System;


namespace ClassLibrarySqr
{
    public class Figure
    {
        double r;
        private double sqr;
        double[] side;
        public Figure(double radius)
        {
            this.r = radius;
            this.sqr = Math.PI * Math.Pow(radius, 2.0);

        }

        public Figure(double x1, double x2, double x3)
        {
            this.side = new double[3];
            this.side[0] = x1;
            this.side[1] = x2;
            this.side[2] = x3;
            double p = (x1 + x2 + x3) / 2.0;
            this.sqr = Math.Sqrt(p * (p - x1) * (p - x2) * (p - x3));
        }

        public double Sqr
        {
            get { return sqr; }
        }

        public bool IsSqrTriangle()
        {
            bool res = false;
            try
            {
                Array.Sort(this.side);
                res = (Math.Pow(this.side[2], 2.0) == (Math.Pow(this.side[0], 2.0) + Math.Pow(this.side[1], 2.0))) ? true : false;

            }
            catch
            {
                Console.WriteLine("это не треугольник");
            }

            return res;
        }
    }
}
