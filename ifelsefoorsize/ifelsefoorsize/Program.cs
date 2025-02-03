namespace ifelsefoorsize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your shoe size: ");
            int shoeSize = int.Parse(Console.ReadLine()); 


            if (shoeSize >= 30 && shoeSize <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;  
                Console.WriteLine("Text color is green");
            }
            else if (shoeSize >= 34 && shoeSize <= 38)
            {
                Console.BackgroundColor = ConsoleColor.White;  
                Console.ForegroundColor = ConsoleColor.Black;  
                Console.WriteLine("Background color is white");
            }
            else if (shoeSize >= 39 && shoeSize <= 44)
            {
                Console.ForegroundColor = ConsoleColor.Blue;  
                Console.BackgroundColor = ConsoleColor.Yellow;  
                Console.WriteLine("Text color is blue and background is yellow");
            }
            else if (shoeSize >= 45 && shoeSize <= 48)
            {
                Console.Beep();
                Console.WriteLine("Beep sound played");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black; 
                Console.BackgroundColor = ConsoleColor.Gray; 
                Console.WriteLine("text color is black and background is gray");
            }

        }
    }
}
