using System;


namespace R5T.Z0000
{
    public class CharacterIndexes : ICharacterIndexes
    {
        #region Infrastructure

        public static ICharacterIndexes Instance { get; } = new CharacterIndexes();

        private CharacterIndexes()
        {
        }

        #endregion
    }
}
