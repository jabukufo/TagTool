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
    [TagStructure(Name = "cache_file_global_tags", Class = "cfgt", Size = 0x10)]
    public class CacheFileGlobalTags
    {
        public List<TagInstance> GlobalTags;
        public uint Unknown;
    }
}
