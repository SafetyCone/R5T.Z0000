using System;


namespace R5T.Z0000
{
    public class CharacterClassSignifiers : ICharacterClassSignifiers
    {
        #region Infrastructure

        public static ICharacterClassSignifiers Instance { get; } = new CharacterClassSignifiers();

        private CharacterClassSignifiers()
        {
        }

        #endregion
    }
}
