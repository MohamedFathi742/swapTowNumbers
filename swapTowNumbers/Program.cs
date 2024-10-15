namespace swapTowNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // swap tow numbers
            Console.WriteLine("welcome to swap tow numbers app  ");

            // ask user to enter number 1

            Console.WriteLine("please enter number one ");

            //read number 1
            byte numberOne = 0;
            bool convert = byte.TryParse(Console.ReadLine(), out numberOne);

            //ask user to enter number 2
            Console.WriteLine("please enter number tow ");

            //read number 1
            byte numberTow = 0;
            bool convertt = byte.TryParse(Console.ReadLine(), out numberTow);


            // swaping 

            byte temp = 0;
            temp = numberOne;
            numberOne = numberTow;
            numberTow = temp;

            //print swap 

            Console.WriteLine($" After swaping \n  number one:  {numberOne} \n number tow: {numberTow}");

            Console.WriteLine("\n");
        }
    }
}
