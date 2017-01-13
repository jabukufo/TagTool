using System;
using TagTool.Cache;

namespace TagTool.Serialization
{
    /// <summary>
    /// Attribute indicating the first engine version in which a tag element is present.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MinVersionAttribute : Attribute
    {
        public MinVersionAttribute(CacheVersion version)
        {
            Version = version;
        }

        public CacheVersion Version { get; set; }
    }
}
