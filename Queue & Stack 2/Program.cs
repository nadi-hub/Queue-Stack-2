namespace Queue___Stack_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> buecherStapel = new Stack<string>();

            // Bücher werden auf den Stapel gelegt
            buecherStapel.Push("Buch 1");
            buecherStapel.Push("Buch 2");
            buecherStapel.Push("Buch 3");

            Console.WriteLine("Das oberste Buch wird genommen: " + buecherStapel.Pop());
            Console.WriteLine("Das nächste Buch wird genommen: " + buecherStapel.Pop());

            // Aktueller Stapel anzeigen
            Console.WriteLine("Aktueller Bücherstapel:");
            foreach (var buch in buecherStapel)
            {
                Console.WriteLine(buch);
            }
        }
    }
}
