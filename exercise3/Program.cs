using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Näme vad hälsar vandrare!");
            Console.Write("Vad vill du att dina första äventyrare ska ha för namn? ");
            string name1 = Console.ReadLine();
            Console.Write("{0} vilket påhittigt namn! Vad ska {0} kompanjon heta? ", name1);
            string name2 = Console.ReadLine();
            Console.WriteLine("{0} var väl inte lika bra men okej... ", name2);
            Console.WriteLine("Tryck eter för att läsa historien");
            Console.ReadKey();
            Console.WriteLine("Sagan om {0} och {1}", name1, name2);
            Console.WriteLine("Det var en tidig morgon. {0} skulle precis gå över en väg då {0} såg {1}.", name1, name2);
            Console.WriteLine("Då av någon konstig anledning blev {0} hungrig och gick och tog ett bett på {1}.", name1, name2);
            Console.WriteLine("Snipp snapp snut, så var sagan om {0} och {1} slut.", name1, name2);
            Console.ReadKey();

        }
    }
}
