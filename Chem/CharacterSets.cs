namespace Chem;

internal static class CharacterSets {
    private static readonly string _subSuperScriptable = "0123456789+-n";
    private static readonly string _subScript = "₀₁₂₃₄₅₆₇₈₉₊₋ₙ";
    private static readonly string _superScript = "⁰¹²³⁴⁵⁶⁷⁸⁹⁺⁻ⁿ";

    public static bool IsSubSuperScriptable(char test) => _subSuperScriptable.Contains(test.ToString());

    public static bool IsSubScript(char test) => _subScript.Contains(test.ToString());
    public static bool IsSuperScript(char test) => _superScript.Contains(test.ToString());

    public static char ToSuperScript(char character) => _superScript[_subSuperScriptable.IndexOf(character)];
    public static char ToSubScript(char character) => _subScript[_subSuperScriptable.IndexOf(character)];

    public static char FromSuperScript(char character) => _subSuperScriptable[_superScript.IndexOf(character)];
    public static char FromSubScript(char character) =>  _subSuperScriptable[_subScript.IndexOf(character)];
}
