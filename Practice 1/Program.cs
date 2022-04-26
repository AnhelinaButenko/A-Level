using System;

namespace Practice_1
{
    // Ввести в консоль текст и распарсить ее как строку. Текст должен состоять минимум из 5 слов разделенных пробелом: 
    //      + Удалить все цифры из текста
    //      + и в каждом нечетном слове заменить буквы в обратном порядке
    //      + 2) Преобразовать эту строку так, чтобы в каждом слове текста первая буква была в верхнем регистре, а остальная часть слов в нижнем.
    //3) Если слово начинается с буквы ‘P’, то заменить ее на ‘S’. 
    //Если заканчивается на ‘N’ то заменить на ‘O’.
    //Заменять на буквы в верхнем регистре, но исходное значение буквы не учитывает регистр.Например не важно это ‘p’ или ‘P’ то все равно заменить на S’

    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "privet6 7world AnLin 5AndreW Test";
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
                }
                evenWordInReverseOrder[i] = strn;                         
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
                        string s = current.Replace('p', 'S');
                        string l = current.Replace('P', 'S');
                        strn += s;
                        strn += s;

                    }
                    else
                    {

                    }
                }
                evenWordInReverseOrder[i] = strn;
            }


            


        }
    }
}
