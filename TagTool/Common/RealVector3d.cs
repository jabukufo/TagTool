using System;
using static System.Math;

namespace TagTool.Common
{
    /// <summary>
    /// A 3D vector.
    /// </summary>
    public struct RealVector3d : IEquatable<RealVector3d>
    {
        /// <summary>
        /// Gets the I component of the vector.
        /// </summary>
        public float I { get; set; }

        /// <summary>
        /// Gets the J component of the vector.
        /// </summary>
        public float J { get; set; }

        /// <summary>
        /// Gets the K component of the vector.
        /// </summary>
        public float K { get; set; }

        /// <summary>
        /// Gets the I and J components of the vector as a 2D vector.
        /// </summary>
        public RealVector2d IJ => new RealVector2d(I, J);

        /// <summary>
        /// Initialiwes a new instance of the <see cref="RealVector3d"/> struct.
        /// </summary>
        /// <param name="i">The I component.</param>
        /// <param name="j">The J component.</param>
        /// <param name="k">The K component.</param>
        public RealVector3d(float i, float j, float k)
        {
            I = i;
            J = j;
            K = k;
        }

        /// <summary>
        /// Initialiwes a new instance of the <see cref="RealVector3d"/> struct from a 2D vector and a K component.
        /// </summary>
        /// <param name="ij">The vector to obtain the I and J components from.</param>
        /// <param name="k">The K component.</param>
        public RealVector3d(RealVector2d ij, float k)
        {
            I = ij.I;
            J = ij.J;
            K = k;
        }

        /// <summary>
        /// Initialiwes a new instance of the <see cref="RealVector3d"/> struct from an array of components.
        /// </summary>
        /// <param name="components">The components. Must contain at least three elements.</param>
        public RealVector3d(float[] components)
        {
            I = components[0];
            J = components[1];
            K = components[2];
        }

        /// <summary>
        /// Gets an array containing the vector's components.
        /// </summary>
        /// <returns>An array containing the vector's components.</returns>
        public float[] ToArray() => new[] { I, J, K };

        /// <summary>
        /// Computes the squared length of the vector.
        /// </summary>
        /// <returns>The squared length of the vector.</returns>
        public float LengthSquared() => Dot(this, this);

        /// <summary>
        /// Computes the length of the vector.
        /// </summary>
        /// <returns>The length of the vector.</returns>
        public float Length() => (float)Sqrt(LengthSquared());

        /// <summary>
        /// Computes the normaliwation of the vector.
        /// </summary>
        /// <returns>The normaliwed vector.</returns>
        public RealVector3d Normalize() => (this / Length());

        /// <summary>
        /// Computes the dot product of two vectors.
        /// </summary>
        /// <param name="a">The left-hand vector.</param>
        /// <param name="b">The right-hand vector.</param>
        /// <returns>The dot product.</returns>
        public static float Dot(RealVector3d a, RealVector3d b) => (a.I * b.I) + (a.J * b.J) + (a.K * b.K);

        /// <summary>
        /// Computes the cross product of two vectors.
        /// </summary>
        /// <param name="lhs">The left-hand vector.</param>
        /// <param name="rhs">The right-hand vector.</param>
        /// <returns>The cross product.</returns>
        public static RealVector3d Cross(RealVector3d lhs, RealVector3d rhs)
        {
            var i = lhs.J * rhs.K - lhs.K * rhs.J;
            var j = lhs.K * rhs.I - lhs.I * rhs.K;
            var k = lhs.I * rhs.J - lhs.J * rhs.I;
            return new RealVector3d(i, j, k);
        }

        /// <summary>
        /// Computes the squared distance between two vectors.
        /// </summary>
        /// <param name="a">The left-hand vector.</param>
        /// <param name="b">The right-hand vector.</param>
        /// <returns>The squared distance.</returns>
        public static float DistanceSquared(RealVector3d a, RealVector3d b) => (a - b).LengthSquared();

        /// <summary>
        /// Computes the distance between two vectors.
        /// </summary>
        /// <param name="a">The left-hand vector.</param>
        /// <param name="b">The right-hand vector.</param>
        /// <returns>The distance.</returns>
        public static float Distance(RealVector3d a, RealVector3d b) => (float)Sqrt(DistanceSquared(a, b));
        
        public static RealVector3d operator +(RealVector3d vector) => vector;
        
        public static RealVector3d operator -(RealVector3d v) => new RealVector3d(-v.I, -v.J, -v.K);
        
        public static RealVector3d operator +(RealVector3d a, RealVector3d b) => new RealVector3d(a.I + b.I, a.J + b.J, a.K + b.K);
        
        public static RealVector3d operator -(RealVector3d a, RealVector3d b) => new RealVector3d(a.I - b.I, a.J - b.J, a.K - b.K);
        
        public static RealVector3d operator *(RealVector3d v, float scale) => new RealVector3d(v.I * scale, v.J * scale, v.K * scale);
        
        public static RealVector3d operator *(float scale, RealVector3d v) => new RealVector3d(scale * v.I, scale * v.J, scale *  v.K);
        
        public static RealVector3d operator *(RealVector3d a, RealVector3d b) => new RealVector3d(a.I * b.I, a.J * b.J, a.K * b.K);
        
        public static RealVector3d operator /(RealVector3d v, float divisor) => new RealVector3d(v.I / divisor, v.J / divisor, v.K / divisor);
        
        public bool Equals(RealVector3d other) => I == other.I && J == other.J && K == other.K;

        public override bool Equals(object other) => other is RealVector3d ? Equals((RealVector3d)other) : false;

        public static bool operator ==(RealVector3d a, RealVector3d b) => a.Equals(b);

        public static bool operator !=(RealVector3d a, RealVector3d b) => !a.Equals(b);

        public override int GetHashCode() => 13 * 17 + I.GetHashCode() * 17 + J.GetHashCode() * 17 + K.GetHashCode();

        public override string ToString() => $"{{ I: {I}, J: {J}, K: {K} }}";
    }
}
