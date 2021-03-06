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
	[TagStructure(Class = "trak", Size = 0x10)]
	public class CameraTrack
	{
		public uint Unknown;
		public List<CameraPoint> CameraPoints;

		[TagStructure(Size = 0x1C)]
		public class CameraPoint
		{
			public float PositionI;
			public float PositionJ;
			public float PositionK;
			public float OrientationI;
			public float OrientationJ;
			public float OrientationK;
			public float OrientationW;
		}
	}
}
