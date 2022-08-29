namespace Day3LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison");
            Console.WriteLine("Enter Number\n 1.Calculate Length of Line\n2.equality\n3.Check Greater or Less");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Length.CalculateLengthOfLine();
                    break;
                case 2:
                    Equality.CalculateLength();
                    break;
                case 3:
                    GreaterOrLess.Compare();
                    break;
                default:
                    Console.WriteLine("Entered Wrong Number");
                    break;
            }
        }
    }
}