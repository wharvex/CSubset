using CSubset.FiniteAutomata.Chars;

namespace CSubset.FiniteAutomata;

public interface IFiniteAutomaton
{
    HashSet<StateType> States { get; }
    HashSet<StateType> FinalStates { get; }
    HashSet<IChar> Alphabet { get; }
    IState Delta(StateType s, IChar c);
}
