using System;
using System.Linq;

using R5T.T0131;


namespace R5T.Z0000
{
	[ValuesMarker]
	public partial interface ICharacterSets : IValuesMarker
	{
		public char[] LowercaseLetters => ICharacterSets.zLowercaseLetters.Value;
		private static readonly Lazy<char[]> zLowercaseLetters = new Lazy<char[]>(
			new[]
			{
				Instances.Characters.a_Lowercase,
				Instances.Characters.b_Lowercase,
				Instances.Characters.c_Lowercase,
				Instances.Characters.d_Lowercase,
				Instances.Characters.e_Lowercase,
				Instances.Characters.f_Lowercase,
				Instances.Characters.g_Lowercase,
				Instances.Characters.h_Lowercase,
				Instances.Characters.i_Lowercase,
				Instances.Characters.j_Lowercase,
				Instances.Characters.k_Lowercase,
				Instances.Characters.l_Lowercase,
				Instances.Characters.m_Lowercase,
				Instances.Characters.n_Lowercase,
				Instances.Characters.o_Lowercase,
				Instances.Characters.p_Lowercase,
				Instances.Characters.q_Lowercase,
				Instances.Characters.r_Lowercase,
				Instances.Characters.s_Lowercase,
				Instances.Characters.t_Lowercase,
				Instances.Characters.u_Lowercase,
				Instances.Characters.v_Lowercase,
				Instances.Characters.w_Lowercase,
				Instances.Characters.x_Lowercase,
				Instances.Characters.y_Lowercase,
				Instances.Characters.z_Lowercase,
			});

		public char[] Numbers => ICharacterSets.zNumbers.Value;
		private static readonly Lazy<char[]> zNumbers = new Lazy<char[]>(
			new[]
			{
				Instances.Characters.Zero,
				Instances.Characters.One,
				Instances.Characters.Two,
				Instances.Characters.Three,
				Instances.Characters.Four,
				Instances.Characters.Five,
				Instances.Characters.Six,
				Instances.Characters.Seven,
				Instances.Characters.Eight,
				Instances.Characters.Nine,
			});

		public char[] SentenceEndings => ICharacterSets.zSentenceEndings.Value;
		private static readonly Lazy<char[]> zSentenceEndings = new Lazy<char[]>(
			new[]
			{
				Instances.Characters.ExclamationMark,
				Instances.Characters.Period,
				Instances.Characters.QuestionMark,
			});

		public char[] SentenceEndings_AndSpace => ICharacterSets.zSentenceEndings_AndSpace.Value;
		private static readonly Lazy<char[]> zSentenceEndings_AndSpace = new Lazy<char[]>(
			ICharacterSets.zSentenceEndings.Value
				.Append(Instances.Characters.Space)
				.ToArray());

		public char[] UppercaseLetters => ICharacterSets.zUppercaseLetters.Value;
		private static readonly Lazy<char[]> zUppercaseLetters = new Lazy<char[]>(
			new[]
			{
				Instances.Characters.A_Uppercase,
				Instances.Characters.B_Uppercase,
				Instances.Characters.C_Uppercase,
				Instances.Characters.D_Uppercase,
				Instances.Characters.E_Uppercase,
				Instances.Characters.F_Uppercase,
				Instances.Characters.G_Uppercase,
				Instances.Characters.H_Uppercase,
				Instances.Characters.I_Uppercase,
				Instances.Characters.J_Uppercase,
				Instances.Characters.K_Uppercase,
				Instances.Characters.L_Uppercase,
				Instances.Characters.M_Uppercase,
				Instances.Characters.N_Uppercase,
				Instances.Characters.O_Uppercase,
				Instances.Characters.P_Uppercase,
				Instances.Characters.Q_Uppercase,
				Instances.Characters.R_Uppercase,
				Instances.Characters.S_Uppercase,
				Instances.Characters.T_Uppercase,
				Instances.Characters.U_Uppercase,
				Instances.Characters.V_Uppercase,
				Instances.Characters.W_Uppercase,
				Instances.Characters.X_Uppercase,
				Instances.Characters.Y_Uppercase,
				Instances.Characters.Z_Uppercase,
			});
	}
}