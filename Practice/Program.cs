using System;
using System.Text;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 words separated by a space");
            string phrase = Console.ReadLine();

            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"{word}");
            }

            string str = "";
            for (int i = 0; i < phrase.Length; i++)
            {
                if (!char.IsDigit(phrase[i]))
                {
                    str += phrase[i];
                }
            }
            Console.WriteLine(str);

            string[] evenWordInReverseOrder = str.Split(' ');
            for (int i = 0; i < evenWordInReverseOrder.Length; i++)
            {
                string current = evenWordInReverseOrder[i];
                if (i % 2 != 0)
                {
                    string stri = "";

                    for (int j = current.Length - 1; j >= 0; j--)
                    {
                        stri += current[j];
                    }
                    evenWordInReverseOrder[i] = stri;
                }
                Console.WriteLine(evenWordInReverseOrder[i]);
            }

            for (int i = 0; i < evenWordInReverseOrder.Length; i++)
            {
                string strn = "";
                string current = evenWordInReverseOrder[i];
                for (int j = 0; j < current.Length; j++)
                {
                    char currentChar = current[j];
                    if (j == 0)
                    {
                        char str0 = char.ToUpper(currentChar);
                        strn += str0;
                    }
                    else
                    {
                        char str1 = char.ToLower(currentChar);
                        strn += str1;
                    }
                    evenWordInReverseOrder[i] = strn;
                }
                Console.WriteLine(evenWordInReverseOrder[i]);
            }

            for (int i = 0; i < evenWordInReverseOrder.Length; i++)
            {
                string current = evenWordInReverseOrder[i];
                StringBuilder newWord = new StringBuilder();

                // if (current[0] == 'P' || current[0] == 'p')
                if (current.StartsWith("p", StringComparison.InvariantCultureIgnoreCase))
                {
                    newWord.Append('S');
                    newWord.Append(current.Substring(1));
                    evenWordInReverseOrder[i] = newWord.ToString();
                }

                if (current.EndsWith("n", StringComparison.InvariantCultureIgnoreCase))
                {
                    newWord.Append(current.Substring(0, current.Length - 1));
                    newWord.Append('O');
                    evenWordInReverseOrder[i] = newWord.ToString();
                }
                Console.WriteLine(evenWordInReverseOrder[i]);
            }
        }
    }
}
