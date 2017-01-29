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
	[TagStructure(Class = "jmad", Size = 0x104)]
	public class ModelAnimationGraph
	{
		public TagInstance ParentAnimationGraph;
		public InheritanceFlagsValue InheritanceFlags;
		public PrivateFlagsValue PrivateFlags;
		public short AnimationCodecPack;
		public List<SkeletonNode> SkeletonNodes;
		public List<SoundReference> SoundReferences;
		public List<EffectReference> EffectReferences;
		public List<BlendScreen> BlendScreens;
		public List<Leg> Legs;
		public List<Animation> Animations;
		public List<Mode> Modes;
		public List<VehicleSuspensionBlock> VehicleSuspension;
		public List<ObjectOverlay> ObjectOverlays;
		public List<InheritanceListBlock> InheritanceList;
		public List<WeaponListBlock> WeaponList;
		public UnknownArmNodes1Value UnknownArmNodes1;
		public UnknownArmNodes2Value UnknownArmNodes2;
		public UnknownArmNodes3Value UnknownArmNodes3;
		public UnknownArmNodes4Value UnknownArmNodes4;
		public UnknownArmNodes5Value UnknownArmNodes5;
		public UnknownArmNodes6Value UnknownArmNodes6;
		public UnknownArmNodes7Value UnknownArmNodes7;
		public UnknownArmNodes8Value UnknownArmNodes8;
		public UnknownNodes1Value UnknownNodes1;
		public UnknownNodes2Value UnknownNodes2;
		public UnknownNodes3Value UnknownNodes3;
		public UnknownNodes4Value UnknownNodes4;
		public UnknownNodes5Value UnknownNodes5;
		public UnknownNodes6Value UnknownNodes6;
		public UnknownNodes7Value UnknownNodes7;
		public UnknownNodes8Value UnknownNodes8;
		public byte[] LastImportResults;
		public uint Unknown;
		public uint Unknown2;
		public uint Unknown3;
		public List<RawInformationGroup> RawInformationGroups;

		public enum InheritanceFlagsValue : byte
		{
			None,
			InheritRootTransScaleOnly,
			InheritForUseOnPlayer,
			Bit2 = 4,
			Bit3 = 8,
			Bit4 = 16,
			Bit5 = 32,
			Bit6 = 64,
			Bit7 = 128,
		}

		public enum PrivateFlagsValue : byte
		{
			None,
			PreparedForCache,
			Bit1,
			ImportedWithCodecCompressors = 4,
			Bit3 = 8,
			WrittenToCache = 16,
			AnimationDataReordered = 32,
			Bit6 = 64,
			Bit7 = 128,
		}

		[TagStructure(Size = 0x20)]
		public class SkeletonNode
		{
			public StringID Name;
			public short NextSiblingNodeIndex;
			public short FirstChildNodeIndex;
			public short ParentNodeIndex;
			public ModelFlagsValue ModelFlags;
			public NodeJointFlagsValue NodeJointFlags;
			public float BaseVectorI;
			public float BaseVectorJ;
			public float BaseVectorK;
			public float VectorRange;
			public float ZPosition;

			public enum ModelFlagsValue : byte
			{
				None,
				PrimaryModel,
				SecondaryModel,
				LocalRoot = 4,
				LeftHand = 8,
				RightHand = 16,
				LeftArmMember = 32,
				Bit6 = 64,
				Bit7 = 128,
			}

			public enum NodeJointFlagsValue : byte
			{
				None,
				BallSocket,
				Hinge,
				NoMovement = 4,
				Bit3 = 8,
				Bit4 = 16,
				Bit5 = 32,
				Bit6 = 64,
				Bit7 = 128,
			}
		}

		[TagStructure(Size = 0x14)]
		public class SoundReference
		{
			public TagInstance Sound;
			public FlagsValue Flags;
			public short Unknown;

			public enum FlagsValue : ushort
			{
				None,
				AllowOnPlayer,
				LeftArmOnly,
				RightArmOnly = 4,
				FirstPersonOnly = 8,
				ForwardOnly = 16,
				ReverseOnly = 32,
				Bit6 = 64,
				Bit7 = 128,
				Bit8 = 256,
				Bit9 = 512,
				Bit10 = 1024,
				Bit11 = 2048,
				Bit12 = 4096,
				Bit13 = 8192,
				Bit14 = 16384,
				Bit15 = 32768,
			}
		}

		[TagStructure(Size = 0x14)]
		public class EffectReference
		{
			public TagInstance Effect;
			public FlagsValue Flags;
			public short Unknown;

			public enum FlagsValue : ushort
			{
				None,
				AllowOnPlayer,
				LeftArmOnly,
				RightArmOnly = 4,
				FirstPersonOnly = 8,
				ForwardOnly = 16,
				ReverseOnly = 32,
				Bit6 = 64,
				Bit7 = 128,
				Bit8 = 256,
				Bit9 = 512,
				Bit10 = 1024,
				Bit11 = 2048,
				Bit12 = 4096,
				Bit13 = 8192,
				Bit14 = 16384,
				Bit15 = 32768,
			}
		}

		[TagStructure(Size = 0x1C)]
		public class BlendScreen
		{
			public StringID Label;
			public Angle RightYawPerFrame;
			public Angle LeftYawPerFrame;
			public short RightFrameCount;
			public short LeftFrameCount;
			public Angle DownPitchPerFrame;
			public Angle UpPitchPerFrame;
			public short DownPitchFrameCount;
			public short UpPitchFrameCount;
		}

		[TagStructure(Size = 0x1C)]
		public class Leg
		{
			public StringID FootMarker;
			public float FootMin;
			public float FootMax;
			public StringID AnkleMarker;
			public float AnkleMin;
			public float AnkleMax;
			public AnchorsValue Anchors;
			public short Unknown;

			public enum AnchorsValue : short
			{
				False,
				True,
			}
		}

		[TagStructure(Size = 0x88)]
		public class Animation
		{
			public StringID Name;
			public float Weight;
			public short LoopFrameIndex;
			public PlaybackFlagsValue PlaybackFlags;
			public sbyte BlendScreen;
			public DesiredCompressionValue DesiredCompression;
			public CurrentCompressionValue CurrentCompression;
			public byte NodeCount;
			public short FrameCount;
			public TypeValue Type;
			public FrameInfoTypeValue FrameInfoType;
			public ProductionFlagsValue ProductionFlags;
			public InternalFlagsValue InternalFlags;
			public int NodeListChecksum;
			public int ProductionChecksum;
			public short Unknown;
			public short Unknown2;
			public short PreviousVariantSibling;
			public short NextVariantSibling;
			public short RawInformationGroupIndex;
			public short RawInformationMemberIndex;
			public List<FrameEvent> FrameEvents;
			public List<SoundEvent> SoundEvents;
			public List<EffectEvent> EffectEvents;
			public List<UnknownBlock> Unknown3;
			public List<ObjectSpaceParentNode> ObjectSpaceParentNodes;
			public List<LegAnchoringBlock> LegAnchoring;
			public float Unknown4;
			public float Unknown5;
			public float Unknown6;
			public float Unknown7;
			public float Unknown8;

			public enum PlaybackFlagsValue : ushort
			{
				None,
				DisableInterpolationIn,
				DisableInterpolationOut,
				DisableModeIk = 4,
				DisableWeaponIk = 8,
				DisableWeaponAimFirstPerson = 16,
				DisableLookScreen = 32,
				DisableTransitionAdjustment = 64,
				Bit7 = 128,
				Bit8 = 256,
				Bit9 = 512,
				Bit10 = 1024,
				Bit11 = 2048,
				Bit12 = 4096,
				Bit13 = 8192,
				Bit14 = 16384,
				Bit15 = 32768,
			}

			public enum DesiredCompressionValue : sbyte
			{
				BestScore,
				BestCompression,
				BestAccuracy,
				BestFullframe,
				BestSmallKeyframe,
				BestLargeKeyframe,
			}

			public enum CurrentCompressionValue : sbyte
			{
				BestScore,
				BestCompression,
				BestAccuracy,
				BestFullframe,
				BestSmallKeyframe,
				BestLargeKeyframe,
			}

			public enum TypeValue : sbyte
			{
				Base,
				Overlay,
				Replacement,
			}

			public enum FrameInfoTypeValue : sbyte
			{
				None,
				DxDy,
				DxDyDyaw,
				DxDyDzDyaw,
			}

			public enum ProductionFlagsValue : ushort
			{
				None,
				DoNotMonitorChanges,
				VerifySoundEvents,
				DoNotInheritForPlayerGraphs = 4,
				Bit3 = 8,
				Bit4 = 16,
				Bit5 = 32,
				Bit6 = 64,
				Bit7 = 128,
				Bit8 = 256,
				Bit9 = 512,
				Bit10 = 1024,
				Bit11 = 2048,
				Bit12 = 4096,
				Bit13 = 8192,
				Bit14 = 16384,
				Bit15 = 32768,
			}

			public enum InternalFlagsValue : ushort
			{
				None,
				Bit0,
				WorldRelative,
				Bit2 = 4,
				Bit3 = 8,
				Bit4 = 16,
				CompressionDisabled = 32,
				OldProductionChecksum = 64,
				ValidProductionChecksum = 128,
				Bit8 = 256,
				Bit9 = 512,
				Bit10 = 1024,
				Bit11 = 2048,
				Bit12 = 4096,
				Bit13 = 8192,
				Bit14 = 16384,
				Bit15 = 32768,
			}

			[TagStructure(Size = 0x4)]
			public class FrameEvent
			{
				public TypeValue Type;
				public short Frame;

				public enum TypeValue : short
				{
					PrimaryKeyframe,
					SecondaryKeyframe,
					LeftFoot,
					RightFoot,
					AllowInterruption,
					TransitionA,
					TransitionB,
					TransitionC,
					TransitionD,
					BothFeetShuffle,
					BodyImpact,
				}
			}

			[TagStructure(Size = 0x8)]
			public class SoundEvent
			{
				public short Sound;
				public short Frame;
				public StringID MarkerName;
			}

			[TagStructure(Size = 0x8)]
			public class EffectEvent
			{
				public short Effect;
				public short Frame;
				public StringID MarkerName;
			}

			[TagStructure(Size = 0x4)]
			public class UnknownBlock
			{
				public short Unknown;
				public short Unknown2;
			}

			[TagStructure(Size = 0x1C)]
			public class ObjectSpaceParentNode
			{
				public short NodeIndex;
				public ComponentFlagsValue ComponentFlags;
				public short RotationX;
				public short RotationY;
				public short RotationZ;
				public short RotationW;
				public float DefaultTranslationX;
				public float DefaultTranslationY;
				public float DefaultTranslationZ;
				public float DefaultScale;

				public enum ComponentFlagsValue : ushort
				{
					None,
					Rotation,
					Translation,
					Scale = 4,
				}
			}

			[TagStructure(Size = 0x10)]
			public class LegAnchoringBlock
			{
				public short LegIndex;
				public short Unknown;
				public List<UnknownBlock> Unknown2;

				[TagStructure(Size = 0x14)]
				public class UnknownBlock
				{
					public short Frame1a;
					public short Frame2a;
					public short Frame1b;
					public short Frame2b;
					public uint Unknown;
					public uint Unknown2;
					public uint Unknown3;
				}
			}
		}

		[TagStructure(Size = 0x28)]
		public class Mode
		{
			public StringID Label;
			public List<WeaponClassBlock> WeaponClass;
			public List<ModeIkBlock> ModeIk;
			public uint Unknown;
			public uint Unknown2;
			public uint Unknown3;

			[TagStructure(Size = 0x1C)]
			public class WeaponClassBlock
			{
				public StringID Label;
				public List<WeaponTypeBlock> WeaponType;
				public List<WeaponIkBlock> WeaponIk;

				[TagStructure(Size = 0x34)]
				public class WeaponTypeBlock
				{
					public StringID Label;
					public List<Action> Actions;
					public List<Overlay> Overlays;
					public List<DeathAndDamageBlock> DeathAndDamage;
					public List<Transition> Transitions;

					[TagStructure(Size = 0x8)]
					public class Action
					{
						public StringID Label;
						public short GraphIndex;
						public short Animation;
					}

					[TagStructure(Size = 0x8)]
					public class Overlay
					{
						public StringID Label;
						public short GraphIndex;
						public short Animation;
					}

					[TagStructure(Size = 0x10)]
					public class DeathAndDamageBlock
					{
						public StringID Label;
						public List<Direction> Directions;

						[TagStructure(Size = 0xC)]
						public class Direction
						{
							public List<Region> Regions;

							[TagStructure(Size = 0x4)]
							public class Region
							{
								public short GraphIndex;
								public short Animation;
							}
						}
					}

					[TagStructure(Size = 0x18)]
					public class Transition
					{
						public StringID FullName;
						public StringID StateName;
						public short Unknown;
						public sbyte IndexA;
						public sbyte IndexB;
						public List<Destination> Destinations;

						[TagStructure(Size = 0x14)]
						public class Destination
						{
							public StringID FullName;
							public StringID ModeName;
							public StringID StateName;
							public FrameEventLinkValue FrameEventLink;
							public sbyte Unknown;
							public sbyte IndexA;
							public sbyte IndexB;
							public short GraphIndex;
							public short Animation;

							public enum FrameEventLinkValue : sbyte
							{
								NoKeyframe,
								KeyframeTypeA,
								KeyframeTypeB,
								KeyframeTypeC,
								KeyframeTypeD,
							}
						}
					}
				}

				[TagStructure(Size = 0x8)]
				public class WeaponIkBlock
				{
					public StringID Marker;
					public StringID AttachToMarker;
				}
			}

			[TagStructure(Size = 0x8)]
			public class ModeIkBlock
			{
				public StringID Marker;
				public StringID AttachToMarker;
			}
		}

		[TagStructure(Size = 0x28)]
		public class VehicleSuspensionBlock
		{
			public StringID Label;
			public short GraphIndex;
			public short Animation;
			public StringID MarkerName;
			public float MassPointOffset;
			public float FullExtensionGroundDepth;
			public float FullCompressionGroundDepth;
			public StringID RegionName;
			public float MassPointOffset2;
			public float ExpressionGroundDepth;
			public float CompressionGroundDepth;
		}

		[TagStructure(Size = 0x14)]
		public class ObjectOverlay
		{
			public StringID Label;
			public short GraphIndex;
			public short Animation;
			public short Unknown;
			public FunctionControlsValue FunctionControls;
			public StringID Function;
			public uint Unknown2;

			public enum FunctionControlsValue : short
			{
				Frame,
				Scale,
			}
		}

		[TagStructure(Size = 0x30)]
		public class InheritanceListBlock
		{
			public TagInstance InheritedGraph;
			public List<NodeMapBlock> NodeMap;
			public List<NodeMapFlag> NodeMapFlags;
			public float RootZOffset;
			public InheritanceFlagsValue InheritanceFlags;

			[TagStructure(Size = 0x2)]
			public class NodeMapBlock
			{
				public short LocalNode;
			}

			[TagStructure(Size = 0x4)]
			public class NodeMapFlag
			{
				public LocalNodeFlagsValue LocalNodeFlags;

				public enum LocalNodeFlagsValue : int
				{
					None,
					Node0326496128160192224,
					Node1336597129161193225,
					Node2346698130162194226 = 4,
					Node3356799131163195227 = 8,
					Node43668100132164196228 = 16,
					Node53769101133165197229 = 32,
					Node63870102134166198230 = 64,
					Node73971103135167199231 = 128,
					Node84072104136168200232 = 256,
					Node94173105137169201233 = 512,
					Node104274106138170202234 = 1024,
					Node114375107139171203235 = 2048,
					Node124476108140172204236 = 4096,
					Node134577109141173205237 = 8192,
					Node144678110142174206238 = 16384,
					Node154779111143175207239 = 32768,
					Node164880112144176208240 = 65536,
					Node174981113145177209241 = 131072,
					Node185082114146178210242 = 262144,
					Node195183115147179211243 = 524288,
					Node205284116148180212244 = 1048576,
					Node215385117149181213245 = 2097152,
					Node225486118150182214246 = 4194304,
					Node235587119151183215247 = 8388608,
					Node245688120152184216248 = 16777216,
					Node255789121153185217249 = 33554432,
					Node265890122154186218250 = 67108864,
					Node275991123155187219251 = 134217728,
					Node286092124156188220252 = 268435456,
					Node296193125157189221253 = 536870912,
					Node306294126158190222254 = 1073741824,
					Node316395127159191223255 = -2147483648,
				}
			}

			public enum InheritanceFlagsValue : int
			{
				None,
				TightenNodes,
				Bit1,
				Bit2 = 4,
				Bit3 = 8,
				Bit4 = 16,
				Bit5 = 32,
				Bit6 = 64,
				Bit7 = 128,
				Bit8 = 256,
				Bit9 = 512,
				Bit10 = 1024,
				Bit11 = 2048,
				Bit12 = 4096,
				Bit13 = 8192,
				Bit14 = 16384,
				Bit15 = 32768,
				Bit16 = 65536,
				Bit17 = 131072,
				Bit18 = 262144,
				Bit19 = 524288,
				Bit20 = 1048576,
				Bit21 = 2097152,
				Bit22 = 4194304,
				Bit23 = 8388608,
				Bit24 = 16777216,
				Bit25 = 33554432,
				Bit26 = 67108864,
				Bit27 = 134217728,
				Bit28 = 268435456,
				Bit29 = 536870912,
				Bit30 = 1073741824,
				Bit31 = -2147483648,
			}
		}

		[TagStructure(Size = 0x8)]
		public class WeaponListBlock
		{
			public StringID WeaponName;
			public StringID WeaponClass;
		}

		public enum UnknownArmNodes1Value : int
		{
			None,
			Node0,
			Node1,
			Node2 = 4,
			Node3 = 8,
			Node4 = 16,
			Node5 = 32,
			Node6 = 64,
			Node7 = 128,
			Node8 = 256,
			Node9 = 512,
			Node10 = 1024,
			Node11 = 2048,
			Node12 = 4096,
			Node13 = 8192,
			Node14 = 16384,
			Node15 = 32768,
			Node16 = 65536,
			Node17 = 131072,
			Node18 = 262144,
			Node19 = 524288,
			Node20 = 1048576,
			Node21 = 2097152,
			Node22 = 4194304,
			Node23 = 8388608,
			Node24 = 16777216,
			Node25 = 33554432,
			Node26 = 67108864,
			Node27 = 134217728,
			Node28 = 268435456,
			Node29 = 536870912,
			Node30 = 1073741824,
			Node31 = -2147483648,
		}

		public enum UnknownArmNodes2Value : int
		{
			None,
			Node32,
			Node33,
			Node34 = 4,
			Node35 = 8,
			Node36 = 16,
			Node37 = 32,
			Node38 = 64,
			Node39 = 128,
			Node40 = 256,
			Node41 = 512,
			Node42 = 1024,
			Node43 = 2048,
			Node44 = 4096,
			Node45 = 8192,
			Node46 = 16384,
			Node47 = 32768,
			Node48 = 65536,
			Node49 = 131072,
			Node50 = 262144,
			Node51 = 524288,
			Node52 = 1048576,
			Node53 = 2097152,
			Node54 = 4194304,
			Node55 = 8388608,
			Node56 = 16777216,
			Node57 = 33554432,
			Node58 = 67108864,
			Node59 = 134217728,
			Node60 = 268435456,
			Node61 = 536870912,
			Node62 = 1073741824,
			Node63 = -2147483648,
		}

		public enum UnknownArmNodes3Value : int
		{
			None,
			Node64,
			Node65,
			Node66 = 4,
			Node67 = 8,
			Node68 = 16,
			Node69 = 32,
			Node70 = 64,
			Node71 = 128,
			Node72 = 256,
			Node73 = 512,
			Node74 = 1024,
			Node75 = 2048,
			Node76 = 4096,
			Node77 = 8192,
			Node78 = 16384,
			Node79 = 32768,
			Node80 = 65536,
			Node81 = 131072,
			Node82 = 262144,
			Node83 = 524288,
			Node84 = 1048576,
			Node85 = 2097152,
			Node86 = 4194304,
			Node87 = 8388608,
			Node88 = 16777216,
			Node89 = 33554432,
			Node90 = 67108864,
			Node91 = 134217728,
			Node92 = 268435456,
			Node93 = 536870912,
			Node94 = 1073741824,
			Node95 = -2147483648,
		}

		public enum UnknownArmNodes4Value : int
		{
			None,
			Node96,
			Node97,
			Node98 = 4,
			Node99 = 8,
			Node100 = 16,
			Node101 = 32,
			Node102 = 64,
			Node103 = 128,
			Node104 = 256,
			Node105 = 512,
			Node106 = 1024,
			Node107 = 2048,
			Node108 = 4096,
			Node109 = 8192,
			Node110 = 16384,
			Node111 = 32768,
			Node112 = 65536,
			Node113 = 131072,
			Node114 = 262144,
			Node115 = 524288,
			Node116 = 1048576,
			Node117 = 2097152,
			Node118 = 4194304,
			Node119 = 8388608,
			Node120 = 16777216,
			Node121 = 33554432,
			Node122 = 67108864,
			Node123 = 134217728,
			Node124 = 268435456,
			Node125 = 536870912,
			Node126 = 1073741824,
			Node127 = -2147483648,
		}

		public enum UnknownArmNodes5Value : int
		{
			None,
			Node128,
			Node129,
			Node130 = 4,
			Node131 = 8,
			Node132 = 16,
			Node133 = 32,
			Node134 = 64,
			Node135 = 128,
			Node136 = 256,
			Node137 = 512,
			Node138 = 1024,
			Node139 = 2048,
			Node140 = 4096,
			Node141 = 8192,
			Node142 = 16384,
			Node143 = 32768,
			Node144 = 65536,
			Node145 = 131072,
			Node146 = 262144,
			Node147 = 524288,
			Node148 = 1048576,
			Node149 = 2097152,
			Node150 = 4194304,
			Node151 = 8388608,
			Node152 = 16777216,
			Node153 = 33554432,
			Node154 = 67108864,
			Node155 = 134217728,
			Node156 = 268435456,
			Node157 = 536870912,
			Node158 = 1073741824,
			Node159 = -2147483648,
		}

		public enum UnknownArmNodes6Value : int
		{
			None,
			Node160,
			Node161,
			Node162 = 4,
			Node163 = 8,
			Node164 = 16,
			Node165 = 32,
			Node166 = 64,
			Node167 = 128,
			Node168 = 256,
			Node169 = 512,
			Node170 = 1024,
			Node171 = 2048,
			Node172 = 4096,
			Node173 = 8192,
			Node174 = 16384,
			Node175 = 32768,
			Node176 = 65536,
			Node177 = 131072,
			Node178 = 262144,
			Node179 = 524288,
			Node180 = 1048576,
			Node181 = 2097152,
			Node182 = 4194304,
			Node183 = 8388608,
			Node184 = 16777216,
			Node185 = 33554432,
			Node186 = 67108864,
			Node187 = 134217728,
			Node188 = 268435456,
			Node189 = 536870912,
			Node190 = 1073741824,
			Node191 = -2147483648,
		}

		public enum UnknownArmNodes7Value : int
		{
			None,
			Node192,
			Node193,
			Node194 = 4,
			Node195 = 8,
			Node196 = 16,
			Node197 = 32,
			Node198 = 64,
			Node199 = 128,
			Node200 = 256,
			Node201 = 512,
			Node202 = 1024,
			Node203 = 2048,
			Node204 = 4096,
			Node205 = 8192,
			Node206 = 16384,
			Node207 = 32768,
			Node208 = 65536,
			Node209 = 131072,
			Node210 = 262144,
			Node211 = 524288,
			Node212 = 1048576,
			Node213 = 2097152,
			Node214 = 4194304,
			Node215 = 8388608,
			Node216 = 16777216,
			Node217 = 33554432,
			Node218 = 67108864,
			Node219 = 134217728,
			Node220 = 268435456,
			Node221 = 536870912,
			Node222 = 1073741824,
			Node223 = -2147483648,
		}

		public enum UnknownArmNodes8Value : int
		{
			None,
			Node224,
			Node225,
			Node226 = 4,
			Node227 = 8,
			Node228 = 16,
			Node229 = 32,
			Node230 = 64,
			Node231 = 128,
			Node232 = 256,
			Node233 = 512,
			Node234 = 1024,
			Node235 = 2048,
			Node236 = 4096,
			Node237 = 8192,
			Node238 = 16384,
			Node239 = 32768,
			Node240 = 65536,
			Node241 = 131072,
			Node242 = 262144,
			Node243 = 524288,
			Node244 = 1048576,
			Node245 = 2097152,
			Node246 = 4194304,
			Node247 = 8388608,
			Node248 = 16777216,
			Node249 = 33554432,
			Node250 = 67108864,
			Node251 = 134217728,
			Node252 = 268435456,
			Node253 = 536870912,
			Node254 = 1073741824,
			Node255 = -2147483648,
		}

		public enum UnknownNodes1Value : int
		{
			None,
			Node0,
			Node1,
			Node2 = 4,
			Node3 = 8,
			Node4 = 16,
			Node5 = 32,
			Node6 = 64,
			Node7 = 128,
			Node8 = 256,
			Node9 = 512,
			Node10 = 1024,
			Node11 = 2048,
			Node12 = 4096,
			Node13 = 8192,
			Node14 = 16384,
			Node15 = 32768,
			Node16 = 65536,
			Node17 = 131072,
			Node18 = 262144,
			Node19 = 524288,
			Node20 = 1048576,
			Node21 = 2097152,
			Node22 = 4194304,
			Node23 = 8388608,
			Node24 = 16777216,
			Node25 = 33554432,
			Node26 = 67108864,
			Node27 = 134217728,
			Node28 = 268435456,
			Node29 = 536870912,
			Node30 = 1073741824,
			Node31 = -2147483648,
		}

		public enum UnknownNodes2Value : int
		{
			None,
			Node32,
			Node33,
			Node34 = 4,
			Node35 = 8,
			Node36 = 16,
			Node37 = 32,
			Node38 = 64,
			Node39 = 128,
			Node40 = 256,
			Node41 = 512,
			Node42 = 1024,
			Node43 = 2048,
			Node44 = 4096,
			Node45 = 8192,
			Node46 = 16384,
			Node47 = 32768,
			Node48 = 65536,
			Node49 = 131072,
			Node50 = 262144,
			Node51 = 524288,
			Node52 = 1048576,
			Node53 = 2097152,
			Node54 = 4194304,
			Node55 = 8388608,
			Node56 = 16777216,
			Node57 = 33554432,
			Node58 = 67108864,
			Node59 = 134217728,
			Node60 = 268435456,
			Node61 = 536870912,
			Node62 = 1073741824,
			Node63 = -2147483648,
		}

		public enum UnknownNodes3Value : int
		{
			None,
			Node64,
			Node65,
			Node66 = 4,
			Node67 = 8,
			Node68 = 16,
			Node69 = 32,
			Node70 = 64,
			Node71 = 128,
			Node72 = 256,
			Node73 = 512,
			Node74 = 1024,
			Node75 = 2048,
			Node76 = 4096,
			Node77 = 8192,
			Node78 = 16384,
			Node79 = 32768,
			Node80 = 65536,
			Node81 = 131072,
			Node82 = 262144,
			Node83 = 524288,
			Node84 = 1048576,
			Node85 = 2097152,
			Node86 = 4194304,
			Node87 = 8388608,
			Node88 = 16777216,
			Node89 = 33554432,
			Node90 = 67108864,
			Node91 = 134217728,
			Node92 = 268435456,
			Node93 = 536870912,
			Node94 = 1073741824,
			Node95 = -2147483648,
		}

		public enum UnknownNodes4Value : int
		{
			None,
			Node96,
			Node97,
			Node98 = 4,
			Node99 = 8,
			Node100 = 16,
			Node101 = 32,
			Node102 = 64,
			Node103 = 128,
			Node104 = 256,
			Node105 = 512,
			Node106 = 1024,
			Node107 = 2048,
			Node108 = 4096,
			Node109 = 8192,
			Node110 = 16384,
			Node111 = 32768,
			Node112 = 65536,
			Node113 = 131072,
			Node114 = 262144,
			Node115 = 524288,
			Node116 = 1048576,
			Node117 = 2097152,
			Node118 = 4194304,
			Node119 = 8388608,
			Node120 = 16777216,
			Node121 = 33554432,
			Node122 = 67108864,
			Node123 = 134217728,
			Node124 = 268435456,
			Node125 = 536870912,
			Node126 = 1073741824,
			Node127 = -2147483648,
		}

		public enum UnknownNodes5Value : int
		{
			None,
			Node128,
			Node129,
			Node130 = 4,
			Node131 = 8,
			Node132 = 16,
			Node133 = 32,
			Node134 = 64,
			Node135 = 128,
			Node136 = 256,
			Node137 = 512,
			Node138 = 1024,
			Node139 = 2048,
			Node140 = 4096,
			Node141 = 8192,
			Node142 = 16384,
			Node143 = 32768,
			Node144 = 65536,
			Node145 = 131072,
			Node146 = 262144,
			Node147 = 524288,
			Node148 = 1048576,
			Node149 = 2097152,
			Node150 = 4194304,
			Node151 = 8388608,
			Node152 = 16777216,
			Node153 = 33554432,
			Node154 = 67108864,
			Node155 = 134217728,
			Node156 = 268435456,
			Node157 = 536870912,
			Node158 = 1073741824,
			Node159 = -2147483648,
		}

		public enum UnknownNodes6Value : int
		{
			None,
			Node160,
			Node161,
			Node162 = 4,
			Node163 = 8,
			Node164 = 16,
			Node165 = 32,
			Node166 = 64,
			Node167 = 128,
			Node168 = 256,
			Node169 = 512,
			Node170 = 1024,
			Node171 = 2048,
			Node172 = 4096,
			Node173 = 8192,
			Node174 = 16384,
			Node175 = 32768,
			Node176 = 65536,
			Node177 = 131072,
			Node178 = 262144,
			Node179 = 524288,
			Node180 = 1048576,
			Node181 = 2097152,
			Node182 = 4194304,
			Node183 = 8388608,
			Node184 = 16777216,
			Node185 = 33554432,
			Node186 = 67108864,
			Node187 = 134217728,
			Node188 = 268435456,
			Node189 = 536870912,
			Node190 = 1073741824,
			Node191 = -2147483648,
		}

		public enum UnknownNodes7Value : int
		{
			None,
			Node192,
			Node193,
			Node194 = 4,
			Node195 = 8,
			Node196 = 16,
			Node197 = 32,
			Node198 = 64,
			Node199 = 128,
			Node200 = 256,
			Node201 = 512,
			Node202 = 1024,
			Node203 = 2048,
			Node204 = 4096,
			Node205 = 8192,
			Node206 = 16384,
			Node207 = 32768,
			Node208 = 65536,
			Node209 = 131072,
			Node210 = 262144,
			Node211 = 524288,
			Node212 = 1048576,
			Node213 = 2097152,
			Node214 = 4194304,
			Node215 = 8388608,
			Node216 = 16777216,
			Node217 = 33554432,
			Node218 = 67108864,
			Node219 = 134217728,
			Node220 = 268435456,
			Node221 = 536870912,
			Node222 = 1073741824,
			Node223 = -2147483648,
		}

		public enum UnknownNodes8Value : int
		{
			None,
			Node224,
			Node225,
			Node226 = 4,
			Node227 = 8,
			Node228 = 16,
			Node229 = 32,
			Node230 = 64,
			Node231 = 128,
			Node232 = 256,
			Node233 = 512,
			Node234 = 1024,
			Node235 = 2048,
			Node236 = 4096,
			Node237 = 8192,
			Node238 = 16384,
			Node239 = 32768,
			Node240 = 65536,
			Node241 = 131072,
			Node242 = 262144,
			Node243 = 524288,
			Node244 = 1048576,
			Node245 = 2097152,
			Node246 = 4194304,
			Node247 = 8388608,
			Node248 = 16777216,
			Node249 = 33554432,
			Node250 = 67108864,
			Node251 = 134217728,
			Node252 = 268435456,
			Node253 = 536870912,
			Node254 = 1073741824,
			Node255 = -2147483648,
		}

		[TagStructure(Size = 0xC)]
		public class RawInformationGroup
		{
			public int MemberCount;
			public ushort ZoneAssetSalt;
			public ushort ZoneAssetIndex;
			public int UselessPadding;
		}
	}
}
