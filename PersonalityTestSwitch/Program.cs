using System;

namespace PersonalityTestSwitch
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
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane": //if(userColor == "punane")
                    Console.WriteLine("Oled romantik.");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled loodusesõber.");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik.");
                    break;
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}