namespace Algorithms___Big_O_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Algorithms myAlgos = new Algorithms();

            int someNmber = 7;
            myAlgos.OddEven(someNmber);

            Random myRandome = new Random();
            int randm = myRandome.Next();
            myAlgos.OddEven(randm);


            Console.WriteLine("Please enter a random number");
            int number = int.Parse(Console.ReadLine());
            myAlgos.OddEven(number);


        }
    }
}