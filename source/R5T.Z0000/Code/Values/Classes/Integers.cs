﻿using System;


namespace R5T.Z0000
{
    public class Integers : IIntegers
    {
        #region Infrastructure

        public static Integers Instance { get; } = new();

        private Integers()
        {
        }

        #endregion
    }
}
