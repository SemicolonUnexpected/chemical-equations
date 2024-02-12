using static Chem.TokenType;

namespace Chem;

internal class EquationLexer {
    private readonly string _equation;
    private int _index = 0;
    private List<Token> tokens = new();

    public EquationLexer(string equation) {
        _equation = equation;
    }

    public List<Token> Lex() {

        // Iterate over the whole equation string
        while(_index < _equation.Length) {
            ScanToken();
        }

        return tokens;
    }

    private void ScanToken() {
        char current = Advance();
        switch (current) {
            case '(':
                tokens.Add(new Token(LeftParenthesis, current.ToString(), null));
                break;
            case ')':
                tokens.Add(new Token(RightParenthesis, current.ToString(), null));
                break;
            default:
                throw new EquationSyntaxException("Unexpected character", _equation, _index);
        }
    }

    #region Lexer movements

    private char Advance() => _equation[_index++];

    #endregion
}
