using System;

namespace GradingSwitch
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

            switch (userResult)
            
            {
                case '5':
                    Console.WriteLine("Suurepärane!");
                    break;
                case '4':
                    Console.WriteLine("Väga hea!");
                    break;
                case '3':
                    Console.WriteLine("Hea!");
                    break;
                case '2':
                    Console.WriteLine("Rahuldav");
                    break;
                case '1':
                    Console.WriteLine("Kasin");
                    break;
                case '0':
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine($"{userResult} on puudulik väärtus!");
                    break;
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}