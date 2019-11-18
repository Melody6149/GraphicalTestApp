using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }

        public static Vector3 operator *(Vector3 lhs, float rhs)
        {
            return new Vector3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        }

        public static Vector3 operator *(float lhs, Vector3 rhs)
        {
            return new Vector3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        }

        public static Vector3 operator /(Vector3 lhs, float rhs)
        {
            return new Vector3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        }

        public static Vector3 operator /(float lhs, Vector3 rhs)
        {
            return new Vector3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        public float MagnitudeSqr()
        {
            return (x * x + y * y + z + z);
        }

        public float Distance(Vector3 other)
        {
            float diffx = x - other.x;
            float diffy = y - other.y;
            float diffz = z - other.z;
            return (float)Math.Sqrt(diffx * diffx + diffy * diffy + diffz * diffz);
        }

        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m;
            this.y /= m;
            this.z /= m;
        }

        public Vector3 GetNormalised()
        {
            return (this / Magnitude());
        }

        public float dotproduc(Vector3 other)
        {
            return ((x * other.x) + (y * other.y) + (z * other.z));
        }

        public float Dot(Vector3 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z;
        }

        public Vector3 Cross(Vector3 rhs)
        {
            return new Vector3(
                y * rhs.z - z * rhs.y,
                z * rhs.x - x * rhs.z,
                x * rhs.y - y * rhs.x);
        }

        public override string ToString()
        {
            return "{" + x + "," + y + "," + z + "}";
        }

        public static Vector3 Min(Vector3 a, Vector3 b)
        {
            return new Vector3(Math.Min(a.x, b.x), Math.Min(a.y, b.y), Math.Min(a.z, b.z));
        }
        public static Vector3 Max(Vector3 a, Vector3 b)
        {
            return new Vector3(Math.Max(a.x, b.x), Math.Max(a.y, b.y), Math.Max(a.z, b.z));
        }

        public static Vector3 Clamp(Vector3 t, Vector3 a, Vector3 b)
        {
            return Max(a, Min(b, t));
        }


    }
}
