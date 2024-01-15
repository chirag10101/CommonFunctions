
namespace CommonFunctions
{
    public  class NumericFunctions
    {
        public static int AddNumbers(params int[] nums) {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum+= nums[i];
            }
            return sum;
        }

        public static int SubtractNumbers(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int MultiplyNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int DivideNumbers(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int MaxInt(params int[] nums)
        {
            int max = 0;
            for(int i = 0;i < nums.Length;i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        public static int MinInt(params int[] nums)
        {
            int min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }

            }
            return min;
        }

        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }

        public static bool IsOdd(int num)
        {
            if (num % 2 == 0)
                return false;
            else
                return true;
        }

        public static bool IsPrime(int num)
        {
            for(int i = 2; i < num/2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
