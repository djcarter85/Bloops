namespace Bloops
{
    using System;

    struct Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double Length
        {
            get { return Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2)); }
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector
            {
                X = v1.X + v2.X,
                Y = v1.Y + v2.Y
            };
        }

        public static Vector operator *(Vector v, double factor)
        {
            return new Vector
            {
                X = v.X * factor,
                Y = v.Y * factor
            };
        }

        public double DistanceTo(Vector other)
        {
            return Math.Sqrt(Math.Pow(this.X - other.X, 2) + Math.Pow(this.Y - other.Y, 2));
        }

        public void Limit(double maxLength)
        {
            if (this.Length > maxLength)
            {
                this *= maxLength / this.Length;
            }
        }
    }
}
