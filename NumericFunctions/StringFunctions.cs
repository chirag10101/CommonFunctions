

using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CommonFunctions
{
    public static class StringFunctions
    {
        public static int NumberOfCharacters(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    count++;
            }
            return count;
        }

        public static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static string ReverseSentence(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static int NoOfVowels(string str)
        {
            int count = 0;
            char[]sent =  str.ToArray();
            for (int i = 0; i < sent.Length; i++)
            {
                if (Char.IsLetter
                if (str[i] == 'a' || str[i] == 'o' || str[i] == 'e' || str[i] == 'u' || str[i] == 'i' ||
                    str[i] == 'A' || str[i] == 'O' || str[i] == 'E' || str[i] == 'U' || str[i] == 'I')
                {
                    count++;
                }
            }
            return count;
        }

        public static int NoOfConsonants(string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'o' || str[i] == 'e' || str[i] == 'u' || str[i] == 'i' ||
                    str[i] == 'A' || str[i] == 'O' || str[i] == 'E' || str[i] == 'U' || str[i] == 'I')
                {
                }
                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    count++;
                }
            }
            return count;
        }

        public static int NoOfIntegers(string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '1' && str[i] <= '9')
                {
                    count++;
                }
            }
            return count;
        }

        public static int NoOfSpecials(string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z') || (str[i] >= '0' && str[i] <= '9'))
                {

                }
                else
                    count++;
            }
            return count;
        }

        public static string ToUpperCase(string str)
        {
            return str.ToUpper();
        }

        public static string ToProperCase(string str)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(str);
        }

        public static string CombineSentences(string str1, string str2)
        {
            return str1 + str2;
        }

        public static string RemoveSpaces(string str)
        {
            string temp = str.Trim();
            return Regex.Replace(temp, @"\s+", " ");
        }

        public static int CountNoOfWords(string str)
        {
            return str.Split(' ').Length;
        } 

        public static bool SearchSubstring(string substr, string str)
        {
            if (!str.Contains(substr, StringComparison.CurrentCulture))
            {
                return false;
            }
            else
            {
                return true;
            };
            
        }

        public static int CountOfSubString(string substr, string str)
        {
            return Regex.Matches(str, substr).Count;
        }


    }
}
