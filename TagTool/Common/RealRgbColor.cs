using TagTool.Serialization;

namespace TagTool.Common
{
    [TagStructure]
    public class RealRgbColor
    {
        public float Red { get; }
        public float Green { get; }
        public float Blue { get; }

        public RealRgbColor() : this(0.0f, 0.0f, 0.0f) { }

        public RealRgbColor(float red, float green, float blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public override string ToString() => $"{{ Red: {Red}, Green: {Green}, Blue: {Blue} }}";
    }
}
