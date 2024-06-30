namespace CSubset.FiniteAutomata;

public interface IFiniteAutomaton
{
    StateTypes States { get; }
    StateTypes FinalStates { get; }
    CharTypes Alphabet { get; }
    StateTypes? Delta(StateTypes s, CharTypes c);
}
