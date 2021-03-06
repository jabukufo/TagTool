﻿using System.Collections.Generic;
using TagTool.Common;
using TagTool.Cache;
using TagTool.Serialization;

namespace TagTool.Geometry
{
    /// <summary>
    /// A material describing how a mesh part should be rendered.
    /// </summary>
    [TagStructure(Size = 0x24, MaxVersion = CacheVersion.HaloOnline571627)]
    [TagStructure(Size = 0x30, MinVersion = CacheVersion.HaloOnline700123)]
    public class RenderMaterial
    {
        /// <summary>
        /// Gets or sets the render method tag to use to render the material.
        /// </summary>
        public CachedTagInstance RenderMethod;

        [MinVersion(CacheVersion.HaloOnline700123)] public List<Skin> Skins;
        public List<Property> Properties;
        public int Unknown;
        public sbyte BreakableSurfaceIndex;
        public sbyte Unknown2;
        public sbyte Unknown3;
        public sbyte Unknown4;

        [TagStructure(Size = 0x14)]
        public class Skin
        {
            public StringId Name;
            public CachedTagInstance RenderMethod;
        }

        [TagStructure(Size = 0xC)]
        public class Property
        {
            public int Type;
            public int IntValue;
            public float RealValue;
        }
    }
}
