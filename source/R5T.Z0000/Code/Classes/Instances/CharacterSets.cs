using System;


namespace R5T.Z0000
{
	public class CharacterSets : ICharacterSets
	{
		#region Infrastructure

	    public static ICharacterSets Instance { get; } = new CharacterSets();

	    private CharacterSets()
	    {
        }

	    #endregion
	}
}