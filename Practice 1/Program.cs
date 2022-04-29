using System;
using System.Text;

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
            Console.WriteLine("Please write 5 words");
            string phrase = Console.ReadLine();
 
            string[] words = phrase.Split(' ');

            Console.WriteLine(phrase);

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                StringBuilder newWord = new StringBuilder();

                for (int j = 0; j < word.Length; j++)
                {

                }
            }
           
            
        }
    }
}
