using System;
using TagTool.GameDefinitions;

namespace TagTool.Serialization
{
    /// <summary>
    /// Attribute indicating the first engine version in which a tag element is present.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MinVersionAttribute : Attribute
    {
        public MinVersionAttribute(GameDefinitionSet version)
        {
            Version = version;
        }

        public GameDefinitionSet Version { get; set; }
    }
}
