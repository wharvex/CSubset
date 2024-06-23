using CSubset.FiniteAutomata.Chars;

namespace CSubset.FiniteAutomata;

public class UnsignedIntFa : IFiniteAutomaton
{
    public HashSet<StateType> States { get; }
    public HashSet<StateType> FinalStates { get; }
    public HashSet<IChar> Alphabet { get; }

    public IState Delta(StateType s, IChar c)
    {
        throw new NotImplementedException();
    }

    public IState StartState { get; }

    public UnsignedIntFa()
    {
        States = new HashSet<StateType>([StateType.S0, StateType.S1, StateType.S2]);
        FinalStates = new HashSet<StateType>([StateType.S1, StateType.S2]);
    }

    public IState Delta(IState s, char c)
    {
        throw new NotImplementedException();
    }
}
