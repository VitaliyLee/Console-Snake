using System;

namespace Snake
{
    struct Vector2
    {
        // X component of the vector.
        public int x;
        // Y component of the vector.
        public int y;

        // Access the /x/ or /y/ component using [0] or [1] respectively.
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default:
                        throw new IndexOutOfRangeException("Invalid Vector2 index!");
                }
            }

            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    default:
                        throw new IndexOutOfRangeException("Invalid Vector2 index!");
                }
            }
        }

        // Adds two vectors.
        public static Vector2 operator +(Vector2 a, Vector2 b) { return new Vector2(a.x + b.x, a.y + b.y); }
        // Subtracts one vector from another.
        public static Vector2 operator -(Vector2 a, Vector2 b) { return new Vector2(a.x - b.x, a.y - b.y); }
        // Multiplies one vector by another.
        public static Vector2 operator *(Vector2 a, Vector2 b) { return new Vector2(a.x * b.x, a.y * b.y); }
        // Divides one vector over another.
        public static Vector2 operator /(Vector2 a, Vector2 b) { return new Vector2(a.x / b.x, a.y / b.y); }
        // Negates a vector.
        public static Vector2 operator -(Vector2 a) { return new Vector2(-a.x, -a.y); }
        // Multiplies a vector by a number.
        public static Vector2 operator *(Vector2 a, int d) { return new Vector2(a.x * d, a.y * d); }
        // Multiplies a vector by a number.
        public static Vector2 operator *(int d, Vector2 a) { return new Vector2(a.x * d, a.y * d); }
        // Divides a vector by a number.
        public static Vector2 operator /(Vector2 a, int d) { return new Vector2(a.x / d, a.y / d); }
        public static bool operator ==(Vector2 lhs, Vector2 rhs)
        {
            float diff_x = lhs.x - rhs.x;
            float diff_y = lhs.y - rhs.y;
            return diff_x == diff_y;
        }
        public static bool operator !=(Vector2 lhs, Vector2 rhs) { return !(lhs == rhs); }

        public Vector2(int x, int y) { this.x = x; this.y = y; }

        static readonly Vector2 zeroVector = new Vector2(0, 0);
        static readonly Vector2 oneVector = new Vector2(1, 1);
        static readonly Vector2 upVector = new Vector2(0, 1);
        static readonly Vector2 downVector = new Vector2(0, -1);
        static readonly Vector2 leftVector = new Vector2(-1, 0);
        static readonly Vector2 rightVector = new Vector2(1, 0);

        public static Vector2 zero { get { return zeroVector; } }
        public static Vector2 one { get { return oneVector; } }
        public static Vector2 up { get { return upVector; } }
        public static Vector2 down { get { return downVector; } }
        public static Vector2 left { get { return leftVector; } }
        public static Vector2 right { get { return rightVector; } }
    }
}
