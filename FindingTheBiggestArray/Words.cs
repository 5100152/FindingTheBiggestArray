using System.Globalization;

namespace FindingTheBiggestArray
{
    internal class Words
    {
        public static string CapitalizeAllWords(string inputString)
        {
            string[] words = inputString.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words[i]);
            }

            return string.Join(" ", words);
        }
    }
}