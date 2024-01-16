
using CommonFunctions;

namespace DllDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumericFunctions numericFunctions = new NumericFunctions();
            Console.WriteLine(NumericFunctions.AddNumbers(5, 10, 15));
            Console.WriteLine(NumericFunctions.DivideNumbers(40, 10));
            Console.WriteLine(NumericFunctions.MultiplyNumbers(3, 5));
            Console.WriteLine(NumericFunctions.SubtractNumbers(89, 34));
            Console.WriteLine(NumericFunctions.IsPrime(31));
            Console.WriteLine(NumericFunctions.IsEven(20));
            Console.WriteLine(NumericFunctions.IsOdd(35));
            Console.WriteLine(NumericFunctions.MaxInt(23, 35, 10, 400, 22));
            Console.WriteLine(NumericFunctions.MinInt(23, 35, 10, 400, 22));
            Console.WriteLine(StringFunctions.IsPalindrome("acbaa"));
            Console.WriteLine(StringFunctions.ReverseSentence(" hello I am chirag"));
            Console.WriteLine(StringFunctions.NoOfVowels("Hello I am chirag 123"));
            Console.WriteLine(StringFunctions.RemoveSpaces("      Hello   I  am chirag    "));
            Console.WriteLine(StringFunctions.NoOfIntegers("Hello I am chirag 123"));
            Console.WriteLine(StringFunctions.NoOfConsonants("Hello I am chirag 12 3 #$%"));
            Console.WriteLine(StringFunctions.NoOfSpecials("Hello I am chirag 12 3 #$%"));
            Console.WriteLine(StringFunctions.SearchSubstring("pqr", "dsacdbsa"));
            Console.WriteLine(StringFunctions.CountOfSubString("pqr", "dspqracdpqrbspqra"));
            Console.WriteLine(numericFunctions.DisplayAllEvenInRange(31, 46));
            Console.WriteLine(numericFunctions.DisplayAllOddInRange(30, 47));
            Console.WriteLine(numericFunctions.DisplayAllPrimeInRange(30, 50));
            Console.WriteLine(numericFunctions.DisplayTable(15));
            Console.WriteLine(numericFunctions.DisplayTables1to10());
            Console.WriteLine(numericFunctions.DisplayTableInRange(32, 39));
            Console.WriteLine(numericFunctions.ReverseInt(4503));
        }
    }
}
