using System;

namespace TagTool.Common
{
    /// <summary>
    /// A 3D point.
    /// </summary>
    public struct RealPoint3d : IEquatable<RealPoint3d>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealPoint3d"/> struct.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        public RealPoint3d(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealPoint3d"/> struct from a 2D point and a Z component.
        /// </summary>
        /// <param name="xy">The point to obtain the X and Y components from.</param>
        /// <param name="z">The Z component.</param>
        public RealPoint3d(RealPoint2d xy, float z)
        {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealPoint3d"/> struct from an array of components.
        /// </summary>
        /// <param name="components">The components. Must contain at least three elements.</param>
        public RealPoint3d(float[] components)
        {
            X = components[0];
            Y = components[1];
            Z = components[2];
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
        /// Gets the Z component of the point.
        /// </summary>
        public readonly float Z;

        /// <summary>
        /// Gets the X and Y components of the point as a 2D point.
        /// </summary>
        public RealPoint2d XY { get { return new RealPoint2d(X, Y); } }

        /// <summary>
        /// Gets an array containing the point's components.
        /// </summary>
        /// <returns>An array containing the point's components.</returns>
        public float[] ToArray()
        {
            return new[] { X, Y, Z };
        }

        /// <summary>
        /// Computes the squared length of the point.
        /// </summary>
        /// <returns>The squared length of the point.</returns>
        public float LengthSquared()
        {
            return X * X + Y * Y + Z * Z;
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
        public RealPoint3d Normalize()
        {
            return this / Length();
        }

        /// <summary>
        /// Computes the dot product of two points.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns>The dot product.</returns>
        public static float Dot(RealPoint3d lhs, RealPoint3d rhs)
        {
            return lhs.X * rhs.X + lhs.Y * rhs.Y + lhs.Z * rhs.Z;
        }

        /// <summary>
        /// Computes the cross product of two points.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns>The cross product.</returns>
        public static RealPoint3d Cross(RealPoint3d lhs, RealPoint3d rhs)
        {
            var x = lhs.Y * rhs.Z - lhs.Z * rhs.Y;
            var y = lhs.Z * rhs.X - lhs.X * rhs.Z;
            var z = lhs.X * rhs.Y - lhs.Y * rhs.X;
            return new RealPoint3d(x, y, z);
        }

        /// <summary>
        /// Computes the squared distance between two points.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns>The squared distance.</returns>
        public static float DistanceSquared(RealPoint3d lhs, RealPoint3d rhs)
        {
            var xDelta = lhs.X - rhs.X;
            var yDelta = lhs.Y - rhs.Y;
            var zDelta = lhs.Z - rhs.Z;
            return xDelta * xDelta + yDelta * yDelta + zDelta * zDelta;
        }

        /// <summary>
        /// Computes the distance between two points.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns>The distance.</returns>
        public static float Distance(RealPoint3d lhs, RealPoint3d rhs)
        {
            return (float)Math.Sqrt(DistanceSquared(lhs, rhs));
        }

        /// <summary>
        /// Implements the unary + operator.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The point.</returns>
        public static RealPoint3d operator +(RealPoint3d point)
        {
            return point;
        }

        /// <summary>
        /// Negates the components of a point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>The point with all of its components negated.</returns>
        public static RealPoint3d operator -(RealPoint3d point)
        {
            return new RealPoint3d(-point.X, -point.Y, -point.Z);
        }

        /// <summary>
        /// Adds the components of two points.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns>The sum of the two points.</returns>
        public static RealPoint3d operator +(RealPoint3d lhs, RealPoint3d rhs)
        {
            return new RealPoint3d(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        }

        /// <summary>
        /// Subtracts the components of two points.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns>The difference of the two points.</returns>
        public static RealPoint3d operator -(RealPoint3d lhs, RealPoint3d rhs)
        {
            return new RealPoint3d(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        }

        /// <summary>
        /// Multiplies the components of the point by a scalar.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The scaled point.</returns>
        public static RealPoint3d operator *(RealPoint3d point, float scale)
        {
            return new RealPoint3d(point.X * scale, point.Y * scale, point.Z * scale);
        }

        /// <summary>
        /// Multiplies the components of the point by a scalar.
        /// </summary>
        /// <param name="scale">The scalar.</param>
        /// <param name="point">The point.</param>
        /// <returns>The scaled point.</returns>
        public static RealPoint3d operator *(float scale, RealPoint3d point)
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
        public static RealPoint3d operator *(RealPoint3d lhs, RealPoint3d rhs)
        {
            return new RealPoint3d(lhs.X * rhs.X, lhs.Y * rhs.Y, lhs.Z * rhs.Z);
        }

        /// <summary>
        /// Divides the components of the point by a scalar.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <param name="divisor">The scalar.</param>
        /// <returns>The scaled point.</returns>
        public static RealPoint3d operator /(RealPoint3d point, float divisor)
        {
            return new RealPoint3d(point.X / divisor, point.Y / divisor, point.Z / divisor);
        }

        /// <summary>
        /// Compares two points for equality.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns><c>true</c> if the two points are equal.</returns>
        public static bool operator ==(RealPoint3d lhs, RealPoint3d rhs) =>
            lhs.Equals(rhs);

        /// <summary>
        /// Compares two points for inequality.
        /// </summary>
        /// <param name="lhs">The left-hand point.</param>
        /// <param name="rhs">The right-hand point.</param>
        /// <returns><c>true</c> if the two points are not equal.</returns>
        public static bool operator !=(RealPoint3d lhs, RealPoint3d rhs) =>
            !lhs.Equals(rhs);

        public bool Equals(RealPoint3d other)
        {
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        public override bool Equals(object other)
        {
            if (!(other is RealPoint3d))
                return false;
            return Equals((RealPoint3d)other);
        }

        public override int GetHashCode() =>
            13 * 17 + X.GetHashCode()
               * 17 + Y.GetHashCode()
               * 17 + Z.GetHashCode();

        public override string ToString() =>
            $"{{ X: {X}, Y: {Y}, Z: {Z} }}";
    }
}
