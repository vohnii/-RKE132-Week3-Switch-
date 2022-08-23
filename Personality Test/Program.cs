using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada tema lemmikvärvi;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantik";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled loodusesõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled {userColor} ükssarvik;

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine();

            if (userColor == "punane")
            {
                Console.WriteLine("Oled romantik.");
            }
            else if (userColor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            else if (userColor == "roheline")
            {
                Console.WriteLine("Oled loodusesõber.");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik.");
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}