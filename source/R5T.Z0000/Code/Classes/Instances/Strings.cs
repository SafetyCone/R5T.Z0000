using System;


namespace R5T.Z0000
{
    public class Strings : IStrings
    {
        #region Infrastructure

        public static Strings Instance { get; } = new();

        private Strings()
        {
        }

        #endregion
    }
}
