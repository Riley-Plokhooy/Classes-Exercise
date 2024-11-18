namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Honda";
            carOne.Model = "Civic";
            carOne.Year = 2020;


            Console.WriteLine($"This is a {carOne.Make} {carOne.Model}, made in {carOne.Year}.");
        }
    }
}
