using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaloOnlineTagTool.Common;
using HaloOnlineTagTool.Resources;
using HaloOnlineTagTool.Serialization;

namespace HaloOnlineTagTool.TagStructures
{
	[TagStructure(Class = "wind", Size = 0x78)]
	public class Wind
	{
		public byte[] Function;
		public byte[] Function2;
		public byte[] Function3;
		public byte[] Function4;
		public byte[] Function5;
		public float Unknown;
		public TagInstance WarpBitmap;
	}
}
