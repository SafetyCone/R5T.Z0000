using System;


namespace R5T.Z0000
{
	public class CharacterSets : ICharacterSets
	{
		#region Infrastructure

	    public static CharacterSets Instance { get; } = new();

	    private CharacterSets()
	    {
        }

	    #endregion
	}
}