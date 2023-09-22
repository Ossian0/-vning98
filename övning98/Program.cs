using System;
namespace Abow
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du?");
            String Namn = Console.ReadLine();
            Console.WriteLine("hej " + Namn + " ,var bor du?");
            string Boende = Console.ReadLine();
            Console.WriteLine("WOEWEW det spennande att du bor i " + Boende);
            Console.ReadLine();
            Console.WriteLine("Finns det några saker o göra där?");
            string saker = Console.ReadLine();
            Console.WriteLine("WoW det najs");
            Console.ReadLine();
            Console.WriteLine("Hur gammal är du " + Namn + "?");
            int gammal = int.Parse(Console.ReadLine());
            int tio = gammal + 10;
            Console.WriteLine("Om 10 år du kommer bli " + tio);
            Console.ReadLine();
            Console.WriteLine("Vad är din drömresa?");
            String drömresa = Console.ReadLine();
            Console.WriteLine("Du måste jobba jätte hårt för åka till " + drömresa);
            Console.ReadLine();
            Console.WriteLine("Det var kul o snacka med dig " + Namn + "." + " tack för infon om " + Boende + " och din drömresa." + "kanske du kan åka till " + drömresa + " om 10 år när du är "+ tio);


        }
    }
}
