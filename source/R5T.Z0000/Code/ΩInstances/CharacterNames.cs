using System;


namespace R5T.Z0000
{
    public class CharacterNames : ICharacterNames
    {
        #region Infrastructure

        public static ICharacterNames Instance { get; } = new CharacterNames();

        private CharacterNames()
        {
        }

        #endregion
    }   
}
