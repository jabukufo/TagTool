﻿using TagTool.Cache;

namespace TagTool.GameDefinitions.HaloOnline498295
{
    /// <summary>
    /// StringID resolver for 11.1.498295.
    /// </summary>
    public class StringIDResolver : StringIDResolverBase
    {
        // These values were figured out through trial-and-error
        private static readonly int[] SetOffsets = { 0x910, 0x1, 0x685, 0x720, 0x7C4, 0x778, 0x7D0, 0x8EB, 0x903 };
        private const int SetMin = 0x1;   // Mininum index that goes in a set
        private const int SetMax = 0xF1F; // Maximum index that goes in a set

        public override int GetMinSetStringIndex()
        {
            return SetMin;
        }

        public override int GetMaxSetStringIndex()
        {
            return SetMax;
        }

        public override int[] GetSetOffsets()
        {
            return SetOffsets;
        }
    }
}
