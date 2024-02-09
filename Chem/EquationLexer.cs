namespace Chem;

internal class EquationLexer {
    private readonly string _equation;
    private int _index = 0;

    public EquationLexer(string equation) {
        _equation = equation;
    }

    public List<Token> Lex() {
        List<Token> tokens = new();

        // Iterate over the whole equation string
        while(_index < _equation.Length) {
            char current = Advance();
        }

        return tokens;
    }

    #region Lexer movements

    private char Advance() => _equation[_index++];

    #endregion
}
