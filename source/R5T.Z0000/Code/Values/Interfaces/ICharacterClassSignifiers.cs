using System;

using R5T.T0131;


namespace R5T.Z0000
{
    [ValuesMarker]
    public interface ICharacterClassSignifiers : IValuesMarker
    {
        public char Alpha => Instances.Character.At; // @
        public char Alphanumeric => Instances.Character.X_Uppercase; // X
        public string AlphanumericUppercase => Instances.Character.X_Uppercase_Hat; // X̂
        public string AlphanumericLowercase => Instances.Character.X_Uppercase_Underbar; // X̲
        public char Lowercase => Instances.Character.Underscore; // _
        public char Numeric => Instances.Character.Pound; // #
        public char Uppercase => Instances.Character.Caret; // ^
    }
}
