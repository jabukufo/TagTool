using System;
using TagTool.GameDefinitions;

namespace TagTool.Serialization
{
    /// <summary>
    /// Attribute indicating the last engine version in which a tag element is present.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MaxVersionAttribute : Attribute
    {
        public MaxVersionAttribute(GameDefinitionSet version)
        {
            Version = version;
        }

        public GameDefinitionSet Version { get; set; }
    }
}
