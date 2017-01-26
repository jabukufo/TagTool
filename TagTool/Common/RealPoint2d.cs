using System;

namespace TagTool.Common
{
    /// <summary>
    /// A 2D point.
    /// </summary>
    public struct RealPoint2d : IEquatable<RealPoint2d>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealPoint2d"/> struct.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        public RealPoint2d(float x, float y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealPoint2d"/> struct from an array of components.
        /// </summary>
        /// <param name="components">The components. Must contain at least two elements.</param>
        public RealPoint2d(float[] components)
        {
            X = components[0];
            Y = components[1];
        }

        /// <summary>
        /// Gets the X component of the point.
        /// </summary>
        public readonly float X;

        /// <summary>
        /// Gets the Y component of the point.
        /// </summary>
        public readonly float Y;

        /// <summary>
        /// Gets an array containing the point's components.
        /// </summary>
        /// <returns>An array containing the point's components.</returns>
        public float[] ToArray()
        {
            return new[] { X, Y };
        }

        /// <summary>
        /// Computes the squared length of the point.
        /// </summary>
        /// <returns>The squared length of the point.</returns>
        public float LengthSquared()
        {
            return X * X + Y * Y;
        }

        /// <summary>
        /// Computes the length of the point.
        /// </summary>
        /// <returns>The length of the point.</returns>
        public float Length()
        {
            return (float)Math.Sqrt(LengthSquared());
        }

        /// <summary>
        /// Computes the normalization of the point.
        /// </summary>
        /// <returns>The normalized point.</returns>
        public RealPoint2d Normalize()
        {
            return this / Length();
        }

        /// <summary>
        /// Computes the dot product of two points.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns>The dot product.</returns>
        public static float Dot(RealPoint2d lhs, RealPoint2d rhs)
        {
            return lhs.X * rhs.X + lhs.Y * rhs.Y;
        }

        /// <summary>
        /// Computes the squared distance between two points.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns>The squared distance.</returns>
        public static float DistanceSquared(RealPoint2d lhs, RealPoint2d rhs)
        {
            var xDelta = lhs.X - rhs.X;
            var yDelta = lhs.Y - rhs.Y;
            return xDelta * xDelta + yDelta * yDelta;
        }

        /// <summary>
        /// Computes the distance between two points.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns>The distance.</returns>
        public static float Distance(RealPoint2d lhs, RealPoint2d rhs)
        {
            return (float)Math.Sqrt(DistanceSquared(lhs, rhs));
        }

        /// <summary>
        /// Implements the unary + operator.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The point.</returns>
        public static RealPoint2d operator+(RealPoint2d point)
        {
            return point;
        }

        /// <summary>
        /// Negates the components of a point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The point with all of its components negated.</returns>
        public static RealPoint2d operator-(RealPoint2d point)
        {
            return new RealPoint2d(-point.X, -point.Y);
        }

        /// <summary>
        /// Adds the components of two points.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns>The sum of the two points.</returns>
        public static RealPoint2d operator+(RealPoint2d lhs, RealPoint2d rhs)
        {
            return new RealPoint2d(lhs.X + rhs.X, lhs.Y + rhs.Y);
        }

        /// <summary>
        /// Subtracts the components of two points.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns>The difference of the two points.</returns>
        public static RealPoint2d operator-(RealPoint2d lhs, RealPoint2d rhs)
        {
            return new RealPoint2d(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }

        /// <summary>
        /// Multiplies the components of the point by a scalar.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The scaled point.</returns>
        public static RealPoint2d operator*(RealPoint2d point, float scale)
        {
            return new RealPoint2d(point.X * scale, point.Y * scale);
        }

        /// <summary>
        /// Multiplies the components of the point by a scalar.
        /// </summary>
        /// <param name="scale">The scalar.</param>
        /// <param name="point">The point.</param>
        /// <returns>The scaled point.</returns>
        public static RealPoint2d operator*(float scale, RealPoint2d point)
        {
            return point * scale;
        }

        /// <summary>
        /// Components the component-wise multiplication (Hadamard product) of
        /// two points.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns>The component-wise multiplication.</returns>
        public static RealPoint2d operator*(RealPoint2d lhs, RealPoint2d rhs)
        {
            return new RealPoint2d(lhs.X * rhs.X, lhs.Y * rhs.Y);
        }

        /// <summary>
        /// Divides the components of the point by a scalar.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <param name="divisor">The scalar.</param>
        /// <returns>The scaled point.</returns>
        public static RealPoint2d operator/(RealPoint2d point, float divisor)
        {
            return new RealPoint2d(point.X / divisor, point.Y / divisor);
        }

        /// <summary>
        /// Compares two points for equality.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns><c>true</c> if the two points are equal.</returns>
        public static bool operator==(RealPoint2d lhs, RealPoint2d rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Compares two points for inequality.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns><c>true</c> if the two points are not equal.</returns>
        public static bool operator!=(RealPoint2d lhs, RealPoint2d rhs)
        {
            return !(lhs == rhs);
        }

        public bool Equals(RealPoint2d other)
        {
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object other)
        {
            if (!(other is RealPoint2d))
                return false;
            return Equals((RealPoint2d)other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var result = 13;
                result = result * 17 + X.GetHashCode();
                result = result * 17 + Y.GetHashCode();
                return result;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", X, Y);
        }
    }
}
