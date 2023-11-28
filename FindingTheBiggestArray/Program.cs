namespace FindingTheBiggestArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 2, 1, 7, 4, 9, 5 };
            int biggest = Numbers.BiggestNumber(myNumbers);
            int secondBiggest = Numbers.SecondBiggestNumber(myNumbers);

            Console.WriteLine(biggest);
            Console.WriteLine(secondBiggest);







            string inputString = "i hope you had a good weekend?";
            string result = Words.CapitalizeAllWords(inputString);

            Console.WriteLine(result);
        }
        
    }
}