using System;


namespace R5T.Z0000
{
    public class CharacterIndexes : ICharacterIndexes
    {
        #region Infrastructure

        public static CharacterIndexes Instance { get; } = new();

        private CharacterIndexes()
        {
        }

        #endregion
    }
}
