namespace SimpleCalculator1Ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to simple calculator");
            Thread.Sleep(1000);
            Console.WriteLine();

            double x;
            double y;
            string answer;
            do
            {
                Console.WriteLine("Enter first number");
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Invalid input, try again");
                }
                Console.WriteLine("Enter second number");
                while (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Invalid input, try again");
                }
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine($"First number is {x} and second number is {y}");
                Console.WriteLine();
                Console.WriteLine("Decide what to do");
                Console.WriteLine();
                Console.WriteLine("Add press 1");
                Console.WriteLine("Subtract press 2");
                Console.WriteLine("Multiply press 3");
                Console.WriteLine("Divide press 4");
                Console.WriteLine();
                int userChoice;
                while (!int.TryParse(Console.ReadLine(), out userChoice) || (userChoice > 4 || userChoice < 1))
                {
                    Console.WriteLine("Invalid input, try again");
                }

                Thread.Sleep(600);
                Console.Clear();

                double result;
                string solution = "Solution of operation:";
                Console.WriteLine(solution);
                Console.WriteLine();
                switch (userChoice)
                {
                    case 1:
                        {
                            result = x + y;
                            Console.WriteLine($"{x} + {y} = {result}");
                            break;
                        }
                    case 2:
                        {
                            result = x - y;
                            Console.WriteLine($"{x} - {y} = {result}");
                            break;
                        }
                    case 3:
                        {   
                            result = x * y;
                            Console.WriteLine($"{x} * {y} = {result}");
                            break;
                        }
                    case 4:
                        {
                            result = x / y;
                            Console.WriteLine($"{x} / {y} = {result}");
                            break;
                        }

                }
                Console.WriteLine("\n");
                Console.WriteLine("If you want to calculate again press y if not press n");
                answer = Console.ReadLine().ToLower();
                Thread.Sleep(600);
                Console.Clear();
                while (answer != "y" && answer != "n")
                {
                    Console.WriteLine("Invalid input press y or n");
                    answer = Console.ReadLine().ToLower();
                }
                Thread.Sleep(600);
                Console.Clear();
            } while (answer == "y");
            Console.WriteLine("End of app");
        }
    }
}
