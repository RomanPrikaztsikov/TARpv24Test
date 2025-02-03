namespace IfElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Control!");

            int number = 189;

            //kontrollistakse kas arv on suurem kui 189-st
            if (number > 189)

            {
                //kui vastab if tingimustele, siis n'itab konsoolis seda arvu 
                Console.WriteLine("Number is bigger");

                //if ja else nestmine
                if (number > 190 && number < 200)
                {
                    Console.WriteLine("number is between 190 to 200");
                }
                else
                {
                    Console.WriteLine("number is bigger than 200");
                }

            }
            else
            {
                Console.WriteLine("Number is smaller");
            }
        }
    }
}
