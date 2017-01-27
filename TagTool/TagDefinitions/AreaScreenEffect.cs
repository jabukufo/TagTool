using System;
using System.Collections.Generic;
using TagTool.Cache;
using TagTool.Common;
using TagTool.Serialization;

namespace TagTool.TagDefinitions
{
    [TagStructure(Name = "area_screen_effect", Class = "sefc", Size = 0xC)]
    public class AreaScreenEffect
    {
        public List<ScreenEffectBlock> ScreenEffects;

        [Flags]
        public enum ScreenEffectFlags : ushort
        {
            None = 0,
            DebugDisable = 1 << 0,
            AllowEffectOutsideRadius = 1 << 1,
            Unattached = 1 << 2,
            FirstPersonOnly = 1 << 3,
            ThirdPersonOnly = 1 << 4,
            DisableCinematicCameraFalloffs = 1 << 5,
            OnlyAffectsAttachedObject = 1 << 6,
            DrawPreciselyOne = 1 << 7,
            UsePlayerTravelDirection = 1 << 8
        }

        [Flags]
        public enum ScreenEffectHiddenFlags : ushort
        {
            None = 0,
            UpdateThread = 1 << 0,
            RenderThread = 1 << 1
        }

        [TagStructure(Size = 0x9C)]
        public class ScreenEffectBlock
        {
            public StringId Name;
            public ScreenEffectFlags Flags;
            public ScreenEffectHiddenFlags HiddenFlags;

            //
            //  DISTANCE FALLOFF:
            //      Controls the maximum distance and the distance falloff of this effect.
            //      NOTE: Not used for scenario global effects
            //

            /// <summary>
            /// The maximum distance this screen effect will affect.
            /// </summary>
            public float MaximumDistance;

            /// <summary>
            /// The function data of the distance falloff.
            /// </summary>
            public byte[] DistanceFalloffFunction;

            //
            //  TIME EVOLUTION:
            //      Controls the lifetime and time falloff of this effect.
            //      NOTE: Not used for scenario global effects
            //

            /// <summary>
            /// The effect is destroyed after this many seconds. (0 = never dies)
            /// </summary>
            public float Duration;

            /// <summary>
            /// The function data of the time evolution.
            /// </summary>
            public byte[] TimeEvolutionFunction;

            //
            //  ANGLE FALLOFF:
            //      Controls the falloff of this effect based on how close you are to looking directly at it.
            //      NOTE: not used for scenario global effects
            //

            /// <summary>
            /// The function data of the angle falloff.
            /// </summary>
            public byte[] AngleFalloffFunction;

            public float LightIntensity;
            public float PrimaryHue;
            public float SecondaryHue;
            public float Saturation;
            public float Desaturation;
            public float GammaIncrease;
            public float GammaDecrease;
            public float ShadowBrightness;
            public RealRgbColor ColorFilter;
            public RealRgbColor ColorFloor;

            public float Tracing;

            public float ScreenShake;

            public TagInstance ScreenShader;
        }
    }
}
