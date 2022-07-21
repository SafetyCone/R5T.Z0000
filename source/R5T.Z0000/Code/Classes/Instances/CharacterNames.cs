using System;


namespace R5T.Z0000
{
    public class CharacterNames : ICharacterNames
    {
        #region Infrastructure

        public static CharacterNames Instance { get; } = new();

        private CharacterNames()
        {
        }

        #endregion
    }   
}
