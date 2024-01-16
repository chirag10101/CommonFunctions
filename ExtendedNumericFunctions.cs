using CommonFunctions;
using System.Text;

namespace DllDemo
{
    public static class ExtendedNumericFunctions
    {
        public static string DisplayAllEvenInRange(this NumericFunctions numericFunctions, int start, int end)
        {
            StringBuilder sb = new StringBuilder();
            if (start % 2 == 1)
                start++;

            if (end % 2 == 1)
                end--;

            for (int i = start; i <= end; i += 2)
                sb.Append(i + " ");

            return sb.ToString();
        }

        public static string DisplayAllOddInRange(this NumericFunctions numericFunctions, int start, int end)
        {
            StringBuilder sb = new StringBuilder();
            if (start % 2 == 0)
                start++;

            if (end % 2 == 0)
                end--;

            for (int i = start; i <= end; i += 2)
                sb.Append(i + " ");

            return sb.ToString();
        }

        public static string DisplayAllPrimeInRange(this NumericFunctions numericFunctions, int start, int end)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = start; i <= end; i++)
                if (NumericFunctions.IsPrime(i))
                {
                    sb.Append(i + " ");
                }

            return sb.ToString();
        }

        public static string DisplayTable(this NumericFunctions numericFunctions, int num)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 10; i++)
            {
                sb.AppendLine($"{num} * {i} = {num*i}");
            }
            return sb.ToString();
        }

        public static string DisplayTables1to10(this NumericFunctions numericFunctions)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    sb.Append((i * j) + " ");
                }
                sb.Append('\n');
            }
            return sb.ToString();
        }

        public static string DisplayTableInRange(this NumericFunctions numericFunctions, int num1, int num2)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = num1; i <= num2; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    sb.Append((i * j) + " ");
                }
                sb.Append('\n');
            }
            return sb.ToString();
        }
        //4503
        public static int ReverseInt(this NumericFunctions numericFunctions, int num)
        {
            int temp = 0;
            int rem = 1;
            while (num != 0)
            {
                rem = num % 10;
                temp = temp * 10 + rem;
                num /= 10;
            }
            return temp;
        }

    }
}
