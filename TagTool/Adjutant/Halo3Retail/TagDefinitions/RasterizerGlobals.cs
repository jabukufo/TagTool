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
	[TagStructure(Class = "rasg", Size = 0xA4)]
	public class RasterizerGlobals
	{
		public List<DefaultBitmap> DefaultBitmaps;
		public List<DefaultRasterizerBitmap> DefaultRasterizerBitmaps;
		public TagInstance VertexShaderSimple;
		public TagInstance PixelShaderSimple;
		public List<DefaultShader> DefaultShaders;
		public uint Unknown;
		public uint Unknown2;
		public uint Unknown3;
		public int Unknown4;
		public int Unknown5;
		public TagInstance ActiveCamoDistortion;
		public TagInstance DefaultPerformanceTemplate;
		public TagInstance DefaultShieldImpact;
		public int Unknown6;
		public uint Unknown7;
		public uint Unknown8;
		public uint Unknown9;
		public uint Unknown10;
		public uint Unknown11;
		public uint Unknown12;

		[TagStructure(Size = 0x14)]
		public class DefaultBitmap
		{
			public int Unknown;
			public TagInstance Bitmap;
		}

		[TagStructure(Size = 0x10)]
		public class DefaultRasterizerBitmap
		{
			public TagInstance Bitmap;
		}

		[TagStructure(Size = 0x20)]
		public class DefaultShader
		{
			public TagInstance VertexShader;
			public TagInstance PixelShader;
		}
	}
}
