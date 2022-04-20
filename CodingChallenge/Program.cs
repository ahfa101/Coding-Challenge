using System;


namespace CodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            int testCases = 0, getSqrt = 0, counter = 0;
            string inputText, outputText;
            Console.WriteLine("Enter number of messages: ");
            testCases = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                counter++;
                Console.WriteLine("Enter message " + counter);
                inputText = Console.ReadLine();
                getSqrt = Convert.ToInt32(Math.Sqrt(Convert.ToInt32(inputText.Length)));
                outputText = "";

                for (int i = getSqrt - 1; i >= 0; i--)
                {
                    for (int j = 0; j < getSqrt; j++)
                    {
                       outputText += inputText[getSqrt * j + i];
                    }
                }

                Console.WriteLine(outputText + "\n");

                if (counter == testCases)
                {
                    break;
                }
            }
        }
    }
}
