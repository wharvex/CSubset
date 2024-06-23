namespace CSubset.Words;

public class SoloWord(int line) : IWord
{
    public enum SoloWordType
    {
        Ampersand,
        Bang,
        Caret,
        Colon,
        Comma,
        Dot,
        Equal,
        FSlash,
        Minus,
        Percent,
        Pipe,
        Plus,
        Semicolon,
        Separator,
        Star,
        Tilde
    }

    public int Line { get; } = line;
}
