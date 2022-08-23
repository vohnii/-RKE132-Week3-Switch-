using System;

namespace Gradingif
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai '5', kuvab konsool "Suurepärane!";
            //'4', kuvab konsool "Väga hea!";
            //'3', kuvab konsool "Hea!;
            //'2', kuvab konsool "Rahuldav";
            //'1', kuvab konsool "Kasin";
            //'0', kuvab konsool "Puudulik";
            //kui kasutaja sisestab midagi muud, siis kuvab konsool "Vale väärtus!";

            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == '5')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (userResult == '4')
            {
                Console.WriteLine("Väga hea!");
            }
            else if (userResult == '3')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == '2')
            {
                Console.WriteLine("Rahuldav");
            }
            else if (userResult == '1')
            {
                Console.WriteLine("Kasin");
            }
            else if (userResult == '0')
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine($"{userResult} on vale väärtus!");
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}