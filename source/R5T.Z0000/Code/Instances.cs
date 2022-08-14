using System;


namespace R5T.Z0000
{
    public static class Instances
    {
        public static ICharacters Characters { get; } = Z0000.Characters.Instance;
        public static IStrings Strings { get; } = Z0000.Strings.Instance;
    }
}
