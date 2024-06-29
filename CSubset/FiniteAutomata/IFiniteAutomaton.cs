namespace CSubset.FiniteAutomata;

public interface IFiniteAutomaton
{
    StateTypes States { get; }
    StateTypes FinalStates { get; }
    CharTypes Alphabet { get; }
    StateTypes? Delta(StateTypes s, CharTypes c);

    public static CharTypes GetAlphabet(params CharTypes[] cts)
    {
        return cts.Aggregate(CharTypes.None, (acc, nxt) => acc | nxt);
    }
}
