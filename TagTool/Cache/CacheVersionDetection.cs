﻿using System;

namespace TagTool.Cache
{
    public static class CacheVersionDetection
    {
        /// <summary>
        /// Detects the engine that a tags.dat was built for.
        /// </summary>
        /// <param name="cache">The cache file.</param>
        /// <param name="closestGuess">On return, the closest guess for the engine's version.</param>
        /// <returns>The engine version if it is known for sure, otherwise <see cref="CacheVersion.Unknown"/>.</returns>
        public static CacheVersion Detect(TagCache cache, out CacheVersion closestGuess)
        {
            return DetectFromTimestamp(cache.Timestamp, out closestGuess);
        }

        /// <summary>
        /// Detects the engine that a tags.dat was built for based on its timestamp.
        /// </summary>
        /// <param name="timestamp">The timestamp.</param>
        /// <param name="closestGuess">On return, the closest guess for the engine's version.</param>
        /// <returns>The engine version if the timestamp matched directly, otherwise <see cref="CacheVersion.Unknown"/>.</returns>
        public static CacheVersion DetectFromTimestamp(long timestamp, out CacheVersion closestGuess)
        {
            var index = Array.BinarySearch(VersionTimestamps, timestamp);
            if (index >= 0)
            {
                // Version matches a timestamp directly
                closestGuess = (CacheVersion)index;
                return closestGuess;
            }

            // Match the closest timestamp
            index = Math.Max(0, Math.Min(~index - 1, VersionTimestamps.Length - 1));
            closestGuess = (CacheVersion)index;
            return CacheVersion.Unknown;
        }

        /// <summary>
        /// Gets the timestamp for a version.
        /// </summary>
        /// <param name="version">The version.</param>
        /// <returns>The timestamp, or -1 for <see cref="CacheVersion.Unknown"/>.</returns>
        public static long GetTimestamp(CacheVersion version)
        {
            if (version == CacheVersion.Unknown)
                return -1;
            return VersionTimestamps[(int)version - 2];
        }

        /// <summary>
        /// Gets the version string corresponding to an <see cref="CacheVersion"/> value.
        /// </summary>
        /// <param name="version">The version.</param>
        /// <returns>The version string.</returns>
        public static string GetVersionString(CacheVersion version)
        {
            switch (version)
            {
                case CacheVersion.HaloOnline106708:
                    return "1.106708 cert_ms23";
                case CacheVersion.HaloOnline235640:
                    return "1.235640 cert_ms23";
                case CacheVersion.HaloOnline301003:
                    return "0.0.1.301003 cert_MS26_new";
                case CacheVersion.HaloOnline327043:
                    return "0.4.1.327043 cert_MS26_new";
                case CacheVersion.HaloOnline372731:
                    return "8.1.372731 Live";
                case CacheVersion.HaloOnline416097:
                    return "0.0.416097 Live";
                case CacheVersion.HaloOnline430475:
                    return "10.1.430475 Live";
                case CacheVersion.HaloOnline454665:
                    return "10.1.454665 Live";
                case CacheVersion.HaloOnline449175:
                    return "10.1.449175 Live";
                case CacheVersion.HaloOnline498295:
                    return "11.1.498295 Live";
                case CacheVersion.HaloOnline530605:
                    return "11.1.530605 Live";
                case CacheVersion.HaloOnline532911:
                    return "11.1.532911 Live";
                case CacheVersion.HaloOnline554482:
                    return "11.1.554482 Live";
                case CacheVersion.HaloOnline571627:
                    return "11.1.571627 Live";
                case CacheVersion.HaloOnline700123:
                    return "12.1.700123 cert_ms30_oct19";
                default:
                    return version.ToString();
            }
        }

        /// <summary>
        /// Compares two version numbers.
        /// </summary>
        /// <param name="lhs">The left-hand version number.</param>
        /// <param name="rhs">The right-hand version number.</param>
        /// <returns>A positive value if the left version is newer, a negative value if the right version is newer, and 0 if the versions are equivalent.</returns>
        public static int Compare(CacheVersion lhs, CacheVersion rhs)
        {
            // Assume the enum values are in order by release date
            return (int)lhs - (int)rhs;
        }

        /// <summary>
        /// Determines whether a version number is between two other version numbers (inclusive).
        /// </summary>
        /// <param name="compare">The version number to compare. If this is <see cref="CacheVersion.Unknown"/>, this function will always return <c>true</c>.</param>
        /// <param name="min">The minimum version number. If this is <see cref="CacheVersion.Unknown"/>, then the lower bound will be ignored.</param>
        /// <param name="max">The maximum version number. If this is <see cref="CacheVersion.Unknown"/>, then the upper bound will be ignored.</param>
        /// <returns></returns>
        public static bool IsBetween(CacheVersion compare, CacheVersion min, CacheVersion max)
        {
            if (compare == CacheVersion.Unknown)
                return true;
            if (min != CacheVersion.Unknown && Compare(compare, min) < 0)
                return false;
            return (max == CacheVersion.Unknown || Compare(compare, max) <= 0);
        }

        /// <summary>
        /// tags.dat timestamps for each game version.
        /// Timestamps in here should correspond directly to <see cref="CacheVersion"/> enum values (excluding <see cref="CacheVersion.Unknown"/>).
        /// </summary>
        private static readonly long[] VersionTimestamps =
        {
            130713360239499012, // HaloOnline106708
            130772932862346058, // HaloOnline235640
            130785901486445524, // HaloOnline301003
            130800445160458507, // V0_4_1_327043_cert_MS26_new
            130814318396118255, // V8_1_372731_Live
            130829123589114103, // V0_0_416097_Live
            130834294034159845, // HaloOnline430475
            130844512316254660, // V10_1_454665_Live
            130851642645809862, // HaloOnline449175
            130858473716879375, // HaloOnline498295
            130868891945946004, // V11_1_530605_Live
            130869644198634503, // V11_1_532911_Live
            130879952719550501, // V11_1_554482_Live
            130881889330693956, // HaloOnline571627
            130930071628935939, // HaloOnline700123
        };
    }

    public enum CacheVersion
    {
        Unknown = -1,
        HaloOnline106708,
        HaloOnline235640,
        HaloOnline301003,
        HaloOnline327043,
        HaloOnline372731,
        HaloOnline416097,
        HaloOnline430475,
        HaloOnline454665,
        HaloOnline449175,
        HaloOnline498295,
        HaloOnline530605,
        HaloOnline532911,
        HaloOnline554482,
        HaloOnline571627,
        HaloOnline700123
    }
}
