using System;

namespace UniqueString
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(IsUniqueChars("abcdef"));
            Console.Read();
        }        

        private static bool IsUniqueChars(string str)
        {
            //remove extra white space
            str = str.Trim();

            //return false if the input argument is invalid.
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            //return flase if the input string length greater than 128 characters.
            if (str.Length > 128)
            {
                return false;
            }            

            bool[] char_set = new bool[128];
            for (int i = 0; i < str.Length; i++)
            {
                if (char_set[str[i]])
                {
                    return false;
                }

                char_set[str[i]] = true;
            }

            return true;
        }
    }
}
