namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Exercise 1, #1---------------------
            int a = 17;
            int b = 4;

            var sum = a + b;
            var diff = a - b;
            var prod = a * b;
            double quot = a / b;
            var mod = a % b;

            //Exercise 1, #2----------------------

            int x = 24;
            int y = 5;


            double quote = x / y;
            int remainder = x % y;

            //Exercise 1, #3------------------------

            Console.WriteLine($"The sum of {a} + {b} is {sum}.");
            Console.WriteLine($"When you subtract {b} from {a}, you get {diff}.");
            Console.WriteLine($"When you multiply {a} by {b}, you get {diff}");
            Console.WriteLine($"When you divide {a} by {b}, you get {quote}.");
            Console.WriteLine($"{a} divided by {b} has a remainder of {mod}.");
            Console.WriteLine($"{x} divided by {y} is {quote}.");
            Console.WriteLine($"The remainder of {x} divided by {y} is {remainder}.");


            //Calling Exercise 2 Method----------------
            
            //AreaOfCircle();
            Console.WriteLine(AreaOfCircle());
        }



        //Exercise 2, #1----------------------------

        public static double AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle");
             double radius = double.Parse(Console.ReadLine());

            double areaCircle = (Math.PI * radius * radius);
            return areaCircle;
        }

     

           
      
    }
}
