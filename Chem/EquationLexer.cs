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
        if (current == '(') { AddToken(LeftParenthesis); return; }
        if (current == ')') { AddToken(RightParenthesis); return; }
        if (current == ')') { AddToken(RightParenthesis); return; }
    }

    #region Lexer movements

    private char Advance() => _equation[_index++];
    private char Peek(int step = 1) {
        if (_index + step >= _equation.Length) return '\0';
        return _equation[_index + step];
    }

    #endregion

    private void AddToken(TokenType type) => tokens.Add(new Token(type, null));
    private void AddToken(TokenType type, object? literal) => tokens.Add(new Token(type, null));
}
