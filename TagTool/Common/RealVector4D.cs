using System;

namespace TagTool.Common
{
    /// <summary>
    /// A 4D vector.
    /// </summary>
    public struct RealVector4d
    {
        /// <summary>
        /// Gets the X component of the vector.
        /// </summary>
        public float I { get; }

        /// <summary>
        /// Gets the Y component of the vector.
        /// </summary>
        public float J { get; }

        /// <summary>
        /// Gets the Z component of the vector.
        /// </summary>
        public float K { get; }

        /// <summary>
        /// Gets the W component of the vector.
        /// </summary>
        public float W { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealVector4d"/> struct.
        /// </summary>
        /// <param name="i">The X component.</param>
        /// <param name="j">The Y component.</param>
        /// <param name="k">The Z component.</param>
        /// <param name="w">The W component.</param>
        public RealVector4d(float i, float j, float k, float w)
        {
            I = i;
            J = j;
            K = k;
            W = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealVector4d"/> struct from a 2D vector and Z and W components.
        /// </summary>
        /// <param name="xy">The vector to obtain the X and Y components from.</param>
        /// <param name="z">The Z component.</param>
        /// <param name="w">The W component.</param>
        public RealVector4d(RealPoint2d xy, float z, float w)
        {
            I = xy.X;
            J = xy.Y;
            K = z;
            W = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealVector4d"/> struct from a 3D vector and a W component.
        /// </summary>
        /// <param name="xyz">The vector to obtain the X, Y, and Z components from.</param>
        /// <param name="w">The W component.</param>
        public RealVector4d(RealPoint3d xyz, float w)
        {
            I = xyz.X;
            J = xyz.Y;
            K = xyz.Z;
            W = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealVector4d"/> struct from an array of components.
        /// </summary>
        /// <param name="components">The components. Must contain at least four elements.</param>
        public RealVector4d(float[] components)
        {
            I = components[0];
            J = components[1];
            K = components[2];
            W = components[3];
        }

        /// <summary>
        /// Gets the X and Y components of the vector as a 2D vector.
        /// </summary>
        public RealPoint2d XY { get { return new RealPoint2d(I, J); } }

        /// <summary>
        /// Gets the X, Y, and Z components of the vector as a 3D vector.
        /// </summary>
        public RealPoint3d XYZ { get { return new RealPoint3d(I, J, K); } }

        /// <summary>
        /// Gets an array containing the vector's components.
        /// </summary>
        /// <returns>An array containing the vector's components.</returns>
        public float[] ToArray()
        {
            return new[] { I, J, K, W };
        }

        /// <summary>
        /// Computes the squared length of the vector.
        /// </summary>
        /// <returns>The squared length of the vector.</returns>
        public float LengthSquared()
        {
            return I * I + J * J + K * K + W * W;
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
        public RealVector4d Normalize()
        {
            return this / Length();
        }

        /// <summary>
        /// Computes the dot product of two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The dot product.</returns>
        public static float Dot(RealVector4d lhs, RealVector4d rhs)
        {
            return lhs.I * rhs.I + lhs.J * rhs.J + lhs.K * rhs.K + lhs.W * rhs.W;
        }

        /// <summary>
        /// Computes the squared distance between two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The squared distance.</returns>
        public static float DistanceSquared(RealVector4d lhs, RealVector4d rhs)
        {
            var xDelta = lhs.I - rhs.I;
            var yDelta = lhs.J - rhs.J;
            var zDelta = lhs.K - rhs.K;
            var wDelta = lhs.W - rhs.W;
            return xDelta * xDelta + yDelta * yDelta + zDelta * zDelta + wDelta * wDelta;
        }

        /// <summary>
        /// Computes the distance between two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The distance.</returns>
        public static float Distance(RealVector4d lhs, RealVector4d rhs)
        {
            return (float)Math.Sqrt(DistanceSquared(lhs, rhs));
        }

        /// <summary>
        /// Implements the unary + operator.
        /// </summary>
        /// <param name="vec">The vector.</param>
        /// <returns>The vector.</returns>
        public static RealVector4d operator+(RealVector4d vec)
        {
            return vec;
        }

        /// <summary>
        /// Negates the components of a vector.
        /// </summary>
        /// <param name="vec">The vector.</param>
        /// <returns>The vector with all of its components negated.</returns>
        public static RealVector4d operator-(RealVector4d vec)
        {
            return new RealVector4d(-vec.I, -vec.J, -vec.K, -vec.W);
        }

        /// <summary>
        /// Adds the components of two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The sum of the two vectors.</returns>
        public static RealVector4d operator+(RealVector4d lhs, RealVector4d rhs)
        {
            return new RealVector4d(lhs.I + rhs.I, lhs.J + rhs.J, lhs.K + rhs.K, lhs.W + rhs.W);
        }

        /// <summary>
        /// Subtracts the components of two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The difference of the two vectors.</returns>
        public static RealVector4d operator-(RealVector4d lhs, RealVector4d rhs)
        {
            return new RealVector4d(lhs.I - rhs.I, lhs.J - rhs.J, lhs.K - rhs.K, lhs.W - rhs.W);
        }

        /// <summary>
        /// Multiplies the components of the vector by a scalar.
        /// </summary>
        /// <param name="vec">The vector.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The scaled vector.</returns>
        public static RealVector4d operator*(RealVector4d vec, float scale)
        {
            return new RealVector4d(vec.I * scale, vec.J * scale, vec.K * scale, vec.W * scale);
        }

        /// <summary>
        /// Multiplies the components of the vector by a scalar.
        /// </summary>
        /// <param name="scale">The scalar.</param>
        /// <param name="vec">The vector.</param>
        /// <returns>The scaled vector.</returns>
        public static RealVector4d operator*(float scale, RealVector4d vec)
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
        public static RealVector4d operator*(RealVector4d lhs, RealVector4d rhs)
        {
            return new RealVector4d(lhs.I * rhs.I, lhs.J * rhs.J, lhs.K * rhs.K, lhs.W * rhs.W);
        }

        /// <summary>
        /// Divides the components of the vector by a scalar.
        /// </summary>
        /// <param name="vec">The vector.</param>
        /// <param name="divisor">The scalar.</param>
        /// <returns>The scaled vector.</returns>
        public static RealVector4d operator/(RealVector4d vec, float divisor)
        {
            return new RealVector4d(vec.I / divisor, vec.J / divisor, vec.K / divisor, vec.W / divisor);
        }

        /// <summary>
        /// Compares two vectors for equality.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns><c>true</c> if the two vectors are equal.</returns>
        public static bool operator==(RealVector4d lhs, RealVector4d rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Compares two vectors for inequality.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns><c>true</c> if the two vectors are not equal.</returns>
        public static bool operator!=(RealVector4d lhs, RealVector4d rhs)
        {
            return !(lhs == rhs);
        }

        public bool Equals(RealVector4d other)
        {
            return I == other.I && J == other.J && K == other.K && W == other.W;
        }

        public override bool Equals(object other)
        {
            if (!(other is RealVector4d))
                return false;
            return Equals((RealVector4d)other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var result = 13;
                result = result * 17 + I.GetHashCode();
                result = result * 17 + J.GetHashCode();
                result = result * 17 + K.GetHashCode();
                result = result * 17 + W.GetHashCode();
                return result;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", I, J, K, W);
        }
    }
}
