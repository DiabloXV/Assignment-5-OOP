using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_OOP
{
    internal class Point3D : IComparable<Point3D>, ICloneable
    {

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        // Chaining constructors
        public Point3D() : this(0, 0, 0) { }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Overriding ToString method
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        // Overriding Equals and GetHashCode methods for comparison
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Point3D p = (Point3D)obj;
            return X == p.X && Y == p.Y && Z == p.Z;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        // Overloading == and != operators
        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (ReferenceEquals(p1, null))
                return ReferenceEquals(p2, null);

            return p1.Equals(p2);
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }

        // Implementing IComparable interface
        public int CompareTo(Point3D other)
        {
            if (X != other.X)
                return X.CompareTo(other.X);
            if (Y != other.Y)
                return Y.CompareTo(other.Y);
            return Z.CompareTo(other.Z);
        }

        // Implementing ICloneable interface
        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }
}

