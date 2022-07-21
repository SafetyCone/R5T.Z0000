using System;


namespace R5T.Z0000
{
    public class Characters : ICharacters
    {
        #region Infrastructure

        public static Characters Instance { get; } = new();

        private Characters()
        {
        }

        #endregion
    }
}
