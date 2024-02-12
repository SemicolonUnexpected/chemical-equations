namespace Chem;

internal class Token {
    public  TokenType Type { get; init; }
    public string Lexeme { get; init; }
    public object? Literal { get; init; }

    public Token(TokenType type, string lexeme, object? literal) {
        Type = type;
        Lexeme = lexeme;
        Literal = literal;
    }
}
