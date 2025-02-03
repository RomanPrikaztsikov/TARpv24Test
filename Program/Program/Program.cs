namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha if ja else konsoolirakendus, kus" +
                "kontrollitakse stringi abil värvi vastavust");

            Console.WriteLine("Värvide valikus on: red, blue, green ja white");

            Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta" +
                "eelpool sisestatud värvi");

            var color = Console.ReadLine();


            if (color == "red")
            {
                Console.WriteLine("You have chosen red");
            }
            else if (color == "blue")
            {
                    Console.WriteLine("You have chosen blue");
            }

            else if (color == "green")
            {
                Console.WriteLine("You have chosen green");
            }

            else if (color == "white")
            {
                Console.WriteLine("You have chosen white");
            }

            else
            {
                Console.WriteLine("Incorrect Input");
            }

        }
    }
}
