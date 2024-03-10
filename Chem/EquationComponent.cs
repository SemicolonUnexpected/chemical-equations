using System.Text;

using static Chem.TokenType;

namespace Chem;

internal struct EquationComponent : IEquatable<EquationComponent> {
    private List<Token> _tokens = new();

    public EquationComponent(List<Token> tokens) => _tokens = tokens;

    public bool Equals(EquationComponent other) => _tokens == other._tokens;

    public override string ToString() {
        StringBuilder stringBuilder = new();

        foreach (Token token in _tokens) {
            stringBuilder.Append(token.Type switch {
                    ArrowLeftToRight => " → ",
                    ArrowRightToLeft => " ← ",
                    ArrowReversible => " ⇌ ",
                    Plus => " + ",
                    LeftParenthesis => '(',
                    RightParenthesis => ')',
                    Text => token.Literal?.ToString(),
                    Superscript => CharacterSets.ToSuperscript(token.Literal!.ToString()!),
                    Subscript => CharacterSets.ToSubscript(token.Literal!.ToString()!),
                    Number => token.Literal?.ToString(),
                    _ => throw new NotImplementedException(),
                    });
        }

        return stringBuilder.ToString();
    }
}
