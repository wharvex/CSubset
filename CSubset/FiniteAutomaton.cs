namespace CSubset;

public class FiniteAutomaton
{
    public enum StateType
    {
        Start,
        Number,
        Name,
        Comment,
        SingleQuote,
        DoubleQuote
    }

    public HashSet<StateType> States { get; init; }
}
