using System;

using R5T.T0131;


namespace R5T.Z0000
{
    [ValuesMarker]
    public interface ICharacterClassSignifiers : IValuesMarker
    {
        public char Alpha => Instances.Characters.At; // @
        public char Alphanumeric => Instances.Characters.X_Uppercase; // X
        public string AlphanumericUppercase => Instances.Characters.X_Uppercase_Hat; // X̂
        public string AlphanumericLowercase => Instances.Characters.X_Uppercase_Underbar; // X̲
        public char Lowercase => Instances.Characters.Underscore; // _
        public char Numeric => Instances.Characters.Pound; // #
        public char Uppercase => Instances.Characters.Caret; // ^
    }
}
