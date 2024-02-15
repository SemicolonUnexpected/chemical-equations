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
        while(!AtEnd()) {
            ScanToken();
        }

        return tokens;
    }

    private void ScanToken() {
        char current = Advance();
        switch (current) {
            // Ignore whitespace
            case ' ' :
            case '\r' :
            case '\t' : 
                break;

            // Handle parenthesis
            case '(' :
                AddToken(LeftParenthesis);
                break;
            case ')' :
                AddToken(RightParenthesis);
                break;

            // Handle non-unicode arrows
            case '-':
                if (!Match('>')) Error("Missing arrow head");
                AddToken(ArrowLeftToRight);
                break;

            case '<' :
                if (!Match('-')) Error("Missing arrow body");
                if (Peek() == '>') AddToken(ArrowBoth)
                // COME HERE THERE IS STILL WORK TO DO

            // Handle superscript non-unicode
            case '^' :
                if (!Match('{')) Error("Missing brace");
                break;

            // Handle subscript non-unicode
            case '_' :
                if (!Match('{')) Error("Missing brace");
                break;

            default :
                // Handle balancing numbers
                if (char.IsAsciiDigit(current)) {
                    int start = _index;
                    while (char.IsAsciiDigit(current) && !AtEnd()) {
                        current = Advance();                           
                    }
                    AddToken(Number, int.Parse(_equation.Substring(start, _index - start)));
                    break;
                }

                // If we get here that means the string contains
                // a value that the equation lexer cannot handle 
                Error("Invalid token in equation");
                break;
        }
    }

    #region Helpers

    // Lexer movements
    private bool AtEnd() => _index >= _equation.Length;

    private char Advance() => _equation[_index++];

    private char? Peek(int step = 1) {
        if (_index + step >= _equation.Length) return null;
        return _equation[_index + step];
    }

    private bool Match(char expected) {
        if (AtEnd()) return false;
        return Advance() == expected;
    }

    // Helpers to add tokens quickly
    private void AddToken(TokenType type) => tokens.Add(new Token(type, null));

    private void AddToken(TokenType type, object? literal) => tokens.Add(new Token(type, literal));

    // Throw an error with a specified message
    private void Error(string message) => throw new EquationSyntaxException(message, _equation, _index);

    #endregion

    #region Character groups



    #endregion
}
