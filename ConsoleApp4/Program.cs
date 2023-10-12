using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Соответствие номера из таблицы Unicode символу

            //for (int i = 0; i < 256; i++)
            //    Console.WriteLine("Знак unicode N'{0}'является символом {1}", i, (char)i);

            //Задача 2. Дан символ. Вывести его код

            //Console.Write("Введите символ: ");
            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine($"Символ: {ch} Код: {(int)ch}");

            //Задача 3. Дан символ. Вывести символ, который в кодовой таблице ASCII следует за этим символом

            //Console.Write("Введите символ: ");
            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine(); 
            //int asciiCode = (int)ch;
            //asciiCode++;
            //char nextChar = (char)asciiCode;
            //Console.WriteLine($"Символ, следующий за {ch} в кодовой таблице ASCII, это: {nextChar}", ch, nextChar);

            //Задача 6. Дано название футбольного клуба. Напечатать его на экране «столбиком»

            //Console.Write("Введите название клуба: ");
            //string ch = (Console.ReadLine());
            //char[] omas = ch.ToCharArray();
            //for (int i=0; i< omas.Length ; i++)
            //    {
            //    Console.WriteLine(omas[i]);
            //    }

            //Задача 7. Составить программу, которая печатает заданное слово, начиная с последней буквы

            //Console.Write("Введите слово: ");
            //string word = Console.ReadLine();
            //int length = word.Length;

            //for (int i = length - 1; i >= 0; i--)
            //{
            //    Console.Write(word[i]);
            //}

            //Console.WriteLine();

            //Задача 8.Преобразовать символы в строке из строчных в прописные и обратно

            {
                Console.Write("Введите строку:");
                string str = Console.ReadLine();
                char[] simvol = str.ToCharArray();
                for (int i = 0; i < simvol.Length; i++)
                {
                    Console.Write(char.ToUpper(simvol[i]));
                }
                Console.WriteLine();
                for (int i = 0; i < simvol.Length; i++)
                {
                    Console.Write(char.ToLower(simvol[i]));
                }

                Console.ReadKey();

            }
        }
    }
}
