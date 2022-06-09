using System;


namespace R5T.Z0000
{
    public class CharacterClassSignifiers : ICharacterClassSignifiers
    {
        #region Infrastructure

        public static CharacterClassSignifiers Instance { get; } = new();

        private CharacterClassSignifiers()
        {
        }

        #endregion
    }
}
