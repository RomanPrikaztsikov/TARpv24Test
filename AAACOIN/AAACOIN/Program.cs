namespace AAACOIN
{
    internal class Program
    {
        static void Main()
        {
            // Radius of the Earth in kilometers
            double earthRadiusKm = 6371;

            // Convert the radius to meters
            double earthRadiusM = earthRadiusKm * 1000;

            // Calculate the Earth's circumference in meters using the formula 2 * π * radius
            double earthCircumference = 2 * Math.PI * earthRadiusM;

            // Diameter of a 2-euro coin in meters (25.75 mm converted to meters)
            double coinDiameterM = 25.75 / 1000;

            // Calculate how many 2-euro coins it takes to go around the Earth
            double numberOfCoins = earthCircumference / coinDiameterM;

            // Output the result
            Console.WriteLine("Number of 2-euro coins required to go around the Earth: " + numberOfCoins);
        }
    }
}
