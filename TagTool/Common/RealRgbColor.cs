using TagTool.Serialization;

namespace TagTool.Common
{
    [TagStructure]
    public class RealRgbColor
    {
        public float Red { get; }
        public float Green { get; }
        public float Blue { get; }

        public RealRgbColor(float red, float green, float blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}
