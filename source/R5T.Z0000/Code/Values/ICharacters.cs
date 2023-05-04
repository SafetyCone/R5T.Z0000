﻿using System;

using R5T.T0131;


namespace R5T.Z0000
{
    /// <summary>
    /// Characters by name.
    /// See: <see href="https://www.ascii-code.com/"/>
    /// </summary>
    [ValuesMarker]
    public interface ICharacters : IValuesMarker
    {
        public char Ampersand => '&';
        public char Apostrophe => '\'';
        public char Asterix => '*';
        /// <summary>
        /// Also known as "alphasands".
        /// </summary>
        public char At => '@';
        public char Backslash => '\\';
        /// <summary>
        /// Also known as the circumflex, or up-caret.
        /// </summary>
        public char Caret => '^';
        /// <summary>
        /// '\r' - The carriage return.
        /// </summary>
        public const char CarriageReturn_Constant = '\r';
        public char CarriageReturn => ICharacters.CarriageReturn_Constant;
        /// <summary>
        /// The close angle-bracket ('&gt;').
        /// </summary>
        public char CloseAngleBracket => '>';
        /// <summary>
        /// ']'
        /// </summary>
        public char CloseBrace => ']';
        /// <summary>
        /// '}'
        /// </summary>
        public char CloseBracket => '}';
        /// <summary>
        /// The character ')'.
        /// </summary>
        /// <value>
        /// )
        /// </value>
        public char CloseParenthesis => ')';
        /// <summary>
        /// The character ':'.
        /// </summary>
        public const char Colon_Constant = ':';
        /// <inheritdoc cref="Colon_Constant"/>
        public char Colon => ICharacters.Colon_Constant;
        /// <summary>
        /// The character ','.
        /// </summary>
        public char Comma => ',';
        /// <summary>
        /// '©' - The copyright character.
        /// </summary>
        public const char Copyright_Constant = '©';
        /// <inheritdoc cref="Copyright_Constant"/>
        public char Copyright => ICharacters.Copyright_Constant;
        public char Dash => this.Minus;
        public char DoubleQuote => this.Quote;
        public char Dot => this.Period;
        public char Equals => '=';
        /// <summary>
        /// Strangely, in Visual Studio form-feed prints as the feminine (Venus) symbol.
        /// </summary>
        public const char ExclamationMark_Constant = '!';
        /// <inheritdoc cref="ExclamationMark_Constant"/>
        public char ExclamationMark => ICharacters.ExclamationMark_Constant;
        public char FormFeed => '';
        /// <inheritdoc cref="CloseAngleBracket"/>
        public char GreaterThan => this.CloseAngleBracket;
        public char Hyphen => this.Minus;
        /// <inheritdoc cref="OpenAngleBracket"/>
        public char LessThan => this.OpenAngleBracket;
        public char Minus => '-';
        public char NewLine => '\n';
        /// <summary>
        /// Sometimes the next-line character is represented as ellipsis (...).
        /// </summary>
        public char NextLine => '\x85';
        /// <summary>
        /// The open angle-bracket ('&lt;').
        /// </summary>
        public const char OpenAngleBracket_Constant = '<';
        /// <inheritdoc cref="OpenAngleBracket_Constant"/>
        public char OpenAngleBracket => ICharacters.OpenAngleBracket_Constant;
        /// <summary>
        /// '['
        /// </summary>
        public char OpenBrace => '[';
        /// <summary>
        /// '{'
        /// </summary>
        public char OpenBracket => '{';
        /// <summary>
        /// The character '('.
        /// </summary>
        /// <value>
        /// (
        /// </value>
        public char OpenParenthesis => '(';
        public char Percent => '%';
        /// <summary>
        /// The character '.'.
        /// </summary>
        public char Period => '.';
        public char Pipe => '|';
        public char Plus => '+';
        public char Pound => '#';
        public char QuestionMark => '?';
        /// <summary>
        /// The '"' (quote, double-quote, or quotation mark) character.
        /// </summary>
        public char Quote => '"';
        /// <summary>
        /// The character ';'.
        /// </summary>
        public const char Semicolon_Constant = ';';
        /// <inheritdoc cref="Semicolon_Constant"/>
        public char Semicolon => ICharacters.Semicolon_Constant;
        public char SingleQuote => this.Apostrophe;
        /// <summary>
        /// '/' (slash)
        /// </summary>
        public char Slash => '/';
        /// <summary>
        /// The space (' ').
        /// </summary>
        /// <name>
        /// Space
        /// </name>
        /// <value>
        /// (space)
        /// </value>
        public char Space => ' ';
        public char Tab => '\t';
        /// <summary>
        /// The ` (tick) character.
        /// </summary>
        public char Tick => '`';
        public char Underscore => '_';
        /// <summary>
        /// Strangely, in Visual Studio form-feed prints as the masculine (Mars) symbol.
        /// </summary>
        public char VerticalTab => '';

#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// A latin ligature of 'A' and 'E', or the Old English ash, which is the sound in "hat" or "pattern" (as opposed to the sound in "father" or "car").
        /// </summary>
        public char Ash_Uppercase => 'Æ';
        /// <summary>
        /// The 'th" in thorn.
        /// </summary>
        public char A_Uppercase => 'A';
        public char B_Uppercase => 'B';
        public char C_Uppercase => 'C';
        public char D_Uppercase => 'D';
        public const char E_Uppercase_Constant = 'E';
        public char E_Uppercase => ICharacters.E_Uppercase_Constant;
        public const char F_Uppercase_Constant = 'F';
        public char F_Uppercase => ICharacters.F_Uppercase_Constant;
        public char G_Uppercase => 'G';
        public char H_Uppercase => 'H';
        public char I_Uppercase => 'I';
        public char J_Uppercase => 'J';
        public char K_Uppercase => 'K';
        public char L_Uppercase => 'L';
        public const char M_Uppercase_Constant = 'M';
        public char M_Uppercase => ICharacters.M_Uppercase_Constant;
        public const char N_Uppercase_Constant = 'N';
        public char N_Uppercase => ICharacters.N_Uppercase_Constant;
        public char O_Uppercase => 'O';
        public const char P_Uppercase_Constant = 'P';
        public char P_Uppercase => ICharacters.P_Uppercase_Constant;
        public char Q_Uppercase => 'Q';
        public char R_Uppercase => 'R';
        public char S_Uppercase => 'S';
        public const char T_Uppercase_Constant = 'T';
        public char T_Uppercase => ICharacters.T_Uppercase_Constant;
        public char Thorn_Uppercase => 'Þ';
        public char U_Uppercase => 'U';
        public char V_Uppercase => 'V';
        public char W_Uppercase => 'W';
        public char X_Uppercase => 'X';
        public string X_Uppercase_Hat => "X̂";
        public string X_Uppercase_Underbar => "X̲";
        public char Y_Uppercase => 'Y';
        public char Z_Uppercase => 'Z';


        /// <inheritdoc cref="Ash_Uppercase"/>
        public char Ash_Lowercase => 'æ';
        public char a_Lowercase => 'a';
        public char b_Lowercase => 'b';
        public char c_Lowercase => 'c';
        public char d_Lowercase => 'd';
        public char e_Lowercase => 'e';
        public char f_Lowercase => 'f';
        public char g_Lowercase => 'g';
        public char h_Lowercase => 'h';
        public char i_Lowercase => 'i';
        public char j_Lowercase => 'j';
        public char k_Lowercase => 'k';
        public char l_Lowercase => 'l';
        public char m_Lowercase => 'm';
        public char n_Lowercase => 'n';
        public char o_Lowercase => 'o';
        public char p_Lowercase => 'p';
        public char q_Lowercase => 'q';
        public char r_Lowercase => 'r';
        public char s_Lowercase => 's';
        public char t_Lowercase => 't';
        /// <inheritdoc cref="Thorn_Uppercase"/>
        public char Thorn_Lowercase => 'þ';
        public char u_Lowercase => 'u';
        public char v_Lowercase => 'v';
        public char w_Lowercase => 'w';
        public char x_Lowercase => 'x';
        public char y_Lowercase => 'y';
        public char z_Lowercase => 'z';

#pragma warning restore IDE1006 // Naming Styles

        public char Zero => '0';
        public char One => '1';
        public char Two => '2';
        public char Three => '3';
        public char Four => '4';
        public char Five => '5';
        public char Six => '6';
        public char Seven => '7';
        public char Eight => '8';
        public char Nine => '9';
    }
}
