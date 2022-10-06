using System;
using System.Linq;

using R5T.T0131;


namespace R5T.Z0000
{
	[ValuesMarker]
	public partial interface ICharacterSets : IValuesMarker
	{
		private static readonly Lazy<char[]> zSentenceEndings = new Lazy<char[]>(
			new[]
			{
				Instances.Characters.ExclamationMark,
				Instances.Characters.Period,
				Instances.Characters.QuestionMark,
			});
		public char[] SentenceEndings => ICharacterSets.zSentenceEndings.Value;

		private static readonly Lazy<char[]> zSentenceEndings_AndSpace = new Lazy<char[]>(
			ICharacterSets.zSentenceEndings.Value
				.Append(Instances.Characters.Space)
				.ToArray());
		public char[] SentenceEndings_AndSpace => ICharacterSets.zSentenceEndings_AndSpace.Value;
	}
}