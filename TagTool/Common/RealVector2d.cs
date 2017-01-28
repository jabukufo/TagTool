using System;

namespace TagTool.Common
{
    /// <summary>
    /// A 2D vector.
    /// </summary>
    public struct RealVector2d : IEquatable<RealVector2d>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealVector2d"/> struct.
        /// </summary>
        /// <param name="i">The I component.</param>
        /// <param name="j">The J component.</param>
        public RealVector2d(float i, float j)
        {
            I = i;
            J = j;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealVector2d"/> struct from an array of components.
        /// </summary>
        /// <param name="components">The components. Must contain at least two elements.</param>
        public RealVector2d(float[] components)
        {
            I = components[0];
            J = components[1];
        }

        /// <summary>
        /// Gets the I component of the vector.
        /// </summary>
        public readonly float I;

        /// <summary>
        /// Gets the J component of the vector.
        /// </summary>
        public readonly float J;

        /// <summary>
        /// Gets an array containing the vector's components.
        /// </summary>
        /// <returns>An array containing the vector's components.</returns>
        public float[] ToArray()
        {
            return new[] { I, J };
        }

        /// <summary>
        /// Computes the squared length of the vector.
        /// </summary>
        /// <returns>The squared length of the vector.</returns>
        public float LengthSquared()
        {
            return I * I + J * J;
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
        public RealVector2d Normalize()
        {
            return this / Length();
        }

        /// <summary>
        /// Computes the dot product of two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The dot product.</returns>
        public static float Dot(RealVector2d lhs, RealVector2d rhs)
        {
            return lhs.I * rhs.I + lhs.J * rhs.J;
        }

        /// <summary>
        /// Computes the squared distance between two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The squared distance.</returns>
        public static float DistanceSquared(RealVector2d lhs, RealVector2d rhs)
        {
            var xDelta = lhs.I - rhs.I;
            var yDelta = lhs.J - rhs.J;
            return xDelta * xDelta + yDelta * yDelta;
        }

        /// <summary>
        /// Computes the distance between two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The distance.</returns>
        public static float Distance(RealVector2d lhs, RealVector2d rhs)
        {
            return (float)Math.Sqrt(DistanceSquared(lhs, rhs));
        }

        /// <summary>
        /// Implements the unary + operator.
        /// </summary>
        /// <param name="vec">The vector.</param>
        /// <returns>The vector.</returns>
        public static RealVector2d operator +(RealVector2d vec)
        {
            return vec;
        }

        /// <summary>
        /// Negates the components of a vector.
        /// </summary>
        /// <param name="vec">The vector.</param>
        /// <returns>The vector with all of its components negated.</returns>
        public static RealVector2d operator -(RealVector2d vec)
        {
            return new RealVector2d(-vec.I, -vec.J);
        }

        /// <summary>
        /// Adds the components of two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The sum of the two vectors.</returns>
        public static RealVector2d operator +(RealVector2d lhs, RealVector2d rhs)
        {
            return new RealVector2d(lhs.I + rhs.I, lhs.J + rhs.J);
        }

        /// <summary>
        /// Subtracts the components of two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The difference of the two vectors.</returns>
        public static RealVector2d operator -(RealVector2d lhs, RealVector2d rhs)
        {
            return new RealVector2d(lhs.I - rhs.I, lhs.J - rhs.J);
        }

        /// <summary>
        /// Multiplies the components of the vector by a scalar.
        /// </summary>
        /// <param name="vec">The vector.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The scaled vector.</returns>
        public static RealVector2d operator *(RealVector2d vec, float scale)
        {
            return new RealVector2d(vec.I * scale, vec.J * scale);
        }

        /// <summary>
        /// Multiplies the components of the vector by a scalar.
        /// </summary>
        /// <param name="scale">The scalar.</param>
        /// <param name="vec">The vector.</param>
        /// <returns>The scaled vector.</returns>
        public static RealVector2d operator *(float scale, RealVector2d vec)
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
        public static RealVector2d operator *(RealVector2d lhs, RealVector2d rhs)
        {
            return new RealVector2d(lhs.I * rhs.I, lhs.J * rhs.J);
        }

        /// <summary>
        /// Divides the components of the vector by a scalar.
        /// </summary>
        /// <param name="vec">The vector.</param>
        /// <param name="divisor">The scalar.</param>
        /// <returns>The scaled vector.</returns>
        public static RealVector2d operator /(RealVector2d vec, float divisor)
        {
            return new RealVector2d(vec.I / divisor, vec.J / divisor);
        }

        /// <summary>
        /// Compares two vectors for equality.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns><c>true</c> if the two vectors are equal.</returns>
        public static bool operator ==(RealVector2d lhs, RealVector2d rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Compares two vectors for inequality.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns><c>true</c> if the two vectors are not equal.</returns>
        public static bool operator !=(RealVector2d lhs, RealVector2d rhs)
        {
            return !(lhs == rhs);
        }

        public bool Equals(RealVector2d other)
        {
            return I == other.I && J == other.J;
        }

        public override bool Equals(object other)
        {
            if (!(other is RealVector2d))
                return false;
            return Equals((RealVector2d)other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var result = 13;
                result = result * 17 + I.GetHashCode();
                result = result * 17 + J.GetHashCode();
                return result;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", I, J);
        }
    }
}
