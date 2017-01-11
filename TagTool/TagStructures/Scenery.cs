using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Common;
using TagTool.Resources;
using TagTool.Serialization;

namespace TagTool.TagStructures
{
    [TagStructure(Name = "scenery", Class = "scen", Size = 0x8)]
    public class Scenery : GameObject
    {
        public PathfindingPolicyValue PathfindingPolicy;
        public ushort Flags2;
        public LightmappingPolicyValue LightmappingPolicy;
        public short Unknown6;

        public enum PathfindingPolicyValue : short
        {
            CutOut,
            Static,
            Dynamic,
            None,
        }

        public enum LightmappingPolicyValue : short
        {
            PerVertex,
            PerPixelNotImplemented,
            Dynamic,
        }
    }
}
