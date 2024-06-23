using CSubset.FiniteAutomata;

namespace CSubset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("" + CharTypes.ZeroThruNine.HasFlag(CharTypes.Eight));
        }
    }
}
