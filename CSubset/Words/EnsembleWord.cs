namespace CSubset.Words;

public class EnsembleWord(int line, string contents) : IWord
{
    public enum EnsembleWordType
    {
        Num,
        NumWithDot,
        Identifier,
        CharContents,
        StringContents,
    }

    public int Line { get; } = line;
    public string Contents { get; } = contents;
}
