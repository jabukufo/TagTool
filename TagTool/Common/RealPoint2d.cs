using System;

namespace TagTool.Common
{
    /// <summary>
    /// A 2D vector.
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
        /// Gets the X component of the vector.
        /// </summary>
        public readonly float X;

        /// <summary>
        /// Gets the Y component of the vector.
        /// </summary>
        public readonly float Y;

        /// <summary>
        /// Gets an array containing the vector's components.
        /// </summary>
        /// <returns>An array containing the vector's components.</returns>
        public float[] ToArray()
        {
            return new[] { X, Y };
        }

        /// <summary>
        /// Computes the squared length of the vector.
        /// </summary>
        /// <returns>The squared length of the vector.</returns>
        public float LengthSquared()
        {
            return X * X + Y * Y;
        }

        /// <summary>
        /// Computes the length of the vector.
        /// </summary>
        /// <returns>The length of the vector.</returns>
        public float Length()
        {
            return (float)Math.Sqrt(LengthSquared());
        }

        /// <summary>
        /// Computes the normalization of the vector.
        /// </summary>
        /// <returns>The normalized vector.</returns>
        public RealPoint2d Normalize()
        {
            return this / Length();
        }

        /// <summary>
        /// Computes the dot product of two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The dot product.</returns>
        public static float Dot(RealPoint2d lhs, RealPoint2d rhs)
        {
            return lhs.X * rhs.X + lhs.Y * rhs.Y;
        }

        /// <summary>
        /// Computes the squared distance between two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The squared distance.</returns>
        public static float DistanceSquared(RealPoint2d lhs, RealPoint2d rhs)
        {
            var xDelta = lhs.X - rhs.X;
            var yDelta = lhs.Y - rhs.Y;
            return xDelta * xDelta + yDelta * yDelta;
        }

        /// <summary>
        /// Computes the distance between two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The distance.</returns>
        public static float Distance(RealPoint2d lhs, RealPoint2d rhs)
        {
            return (float)Math.Sqrt(DistanceSquared(lhs, rhs));
        }

        /// <summary>
        /// Implements the unary + operator.
        /// </summary>
        /// <param name="vec">The vector.</param>
        /// <returns>The vector.</returns>
        public static RealPoint2d operator+(RealPoint2d vec)
        {
            return vec;
        }

        /// <summary>
        /// Negates the components of a vector.
        /// </summary>
        /// <param name="vec">The vector.</param>
        /// <returns>The vector with all of its components negated.</returns>
        public static RealPoint2d operator-(RealPoint2d vec)
        {
            return new RealPoint2d(-vec.X, -vec.Y);
        }

        /// <summary>
        /// Adds the components of two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The sum of the two vectors.</returns>
        public static RealPoint2d operator+(RealPoint2d lhs, RealPoint2d rhs)
        {
            return new RealPoint2d(lhs.X + rhs.X, lhs.Y + rhs.Y);
        }

        /// <summary>
        /// Subtracts the components of two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The difference of the two vectors.</returns>
        public static RealPoint2d operator-(RealPoint2d lhs, RealPoint2d rhs)
        {
            return new RealPoint2d(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }

        /// <summary>
        /// Multiplies the components of the vector by a scalar.
        /// </summary>
        /// <param name="vec">The vector.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The scaled vector.</returns>
        public static RealPoint2d operator*(RealPoint2d vec, float scale)
        {
            return new RealPoint2d(vec.X * scale, vec.Y * scale);
        }

        /// <summary>
        /// Multiplies the components of the vector by a scalar.
        /// </summary>
        /// <param name="scale">The scalar.</param>
        /// <param name="vec">The vector.</param>
        /// <returns>The scaled vector.</returns>
        public static RealPoint2d operator*(float scale, RealPoint2d vec)
        {
            return vec * scale;
        }

        /// <summary>
        /// Components the component-wise multiplication (Hadamard product) of
        /// two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The component-wise multiplication.</returns>
        public static RealPoint2d operator*(RealPoint2d lhs, RealPoint2d rhs)
        {
            return new RealPoint2d(lhs.X * rhs.X, lhs.Y * rhs.Y);
        }

        /// <summary>
        /// Divides the components of the vector by a scalar.
        /// </summary>
        /// <param name="vec">The vector.</param>
        /// <param name="divisor">The scalar.</param>
        /// <returns>The scaled vector.</returns>
        public static RealPoint2d operator/(RealPoint2d vec, float divisor)
        {
            return new RealPoint2d(vec.X / divisor, vec.Y / divisor);
        }

        /// <summary>
        /// Compares two vectors for equality.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns><c>true</c> if the two vectors are equal.</returns>
        public static bool operator==(RealPoint2d lhs, RealPoint2d rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Compares two vectors for inequality.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns><c>true</c> if the two vectors are not equal.</returns>
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
