namespace ASSIGNMENT_7_1_2
{
    internal class Program
    {
        static string MergeAlternately(string word1, string word2)
        {
            int i = 0; 
            int j = 0;
            string result = "";

            //Alternate adding characters from both strings
            while (i < word1.Length && j < word2.Length)
            {
                result += word1[i];
                result += word2[j];
                i++;
                j++;
            }

            //Append remaining characters from word1 if any 
            while (i < word1.Length)
            {
                result += word1[i];
                i++;
            }

            //Append remaining characters from word2 if any
            while (j < word2.Length)
            {
                result += word2[j];
                j++;
            }

            return result;
        }

        static void Main()
        {
            //Example 1 
            string word1 = "abc";
            string word2 = "pqr";
            Console.WriteLine(MergeAlternately(word1, word2));

            //Example 2
            word1 = "ab";
            word2 = "pqrs";
            Console.WriteLine(MergeAlternately(word1, word2));
        }
    }
}
