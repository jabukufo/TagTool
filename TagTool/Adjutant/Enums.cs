namespace Adjutant.Library.Definitions
{
    public enum DefinitionSet
    {
        Unknown = -1,
        Halo1Xbox = 0,
        Halo1PC = 1,
        Halo1CE = 2,
        Halo2Xbox = 4,
        Halo3Beta = 6,
        Halo3Retail = 7,
        Halo3ODST = 8
    }

    public enum SampleRate
    {
        _22050Hz = 0,
        _44100Hz = 1
    }

    public enum SoundType
    {
        Mono = 0,
        Stereo = 1,
        Unknown2 = 2, //2 and 3 probably surround stereo
        Unknown3 = 3
    }
}
