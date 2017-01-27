using TagTool.Serialization;

namespace TagTool.Common
{
    [TagStructure]
    public class RealArgbColor
    {
        public float Alpha { get; }
        public float Red { get; }
        public float Green { get; }
        public float Blue { get; }

        public RealArgbColor() : this(1.0f, 0.0f, 0.0f, 0.0f) { }

        public RealArgbColor(float alpha, float red, float green, float blue)
        {
            Alpha = alpha;
            Red = red;
            Green = green;
            Blue = blue;
        }

        public override string ToString() => $"{{ Alpha: {Alpha}, Red: {Red}, Green: {Green}, Blue: {Blue} }}";
    }
}
