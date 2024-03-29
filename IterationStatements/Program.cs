using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace IterationStatements
{
    public class Program
    {
      

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Console.WriteLine("numbers 1000 to - 1000:");
            Thousand();
            Console.WriteLine();
            Console.WriteLine("Numbers by three:");
            ByThree();
            Console.WriteLine();
            Console.WriteLine("equal or not:");
            Equal(9, 6);
            Console.WriteLine();
            Console.WriteLine("Odd or Even:");
            OddOrEven(7);
            Console.WriteLine();
            Console.WriteLine("positive or negative:");
            PosOrNeg(9);

            Console.WriteLine();
            Console.WriteLine("number in range:");

            string userNum;
            int num;
            bool doIt;

            do
            {
                Console.WriteLine("is your number between -10 and 10? type a number...");
                userNum = Console.ReadLine();
                doIt = int.TryParse(userNum, out num);
            } while (!doIt);

            InRange(num);

            Console.WriteLine();
            Console.WriteLine("voting age: ");

            string userInput;
            int age;
            bool forward;

            do
            {
                Console.WriteLine("Lets see if you can vote... Enter your age.");
                userInput = Console.ReadLine();
                forward = int.TryParse(userInput, out age); 
            } while (!forward);

            VotingAge(age);

            Console.WriteLine();
            Console.WriteLine("multiplication table of 3:");

            Table(3);
        }

        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void Thousand() 
        {
            for (int i = 1000; i >= -1000; i--) 
            {
                Console.WriteLine(i);
            }
        
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void ByThree()
        {
            for(int i = 3; i <= 999; i += 3) 
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not

        public static bool Equal(int a, int b)
        {
            if(a == b)
            {
                Console.WriteLine($"{a} and {b} are equal");
                return true;
            }
            else
            {
                Console.WriteLine($"{a} and {b} are NOT equal");
                return false;
            }
        }

        //Write a method to check whether a given number is even or odd

        public static void OddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} <--- is even!");
            }
            else 
            {
                Console.WriteLine($"{number} <--- is odd!");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static bool PosOrNeg(int num1)
        {
            if (num1 > 0)
            {
                Console.WriteLine($"{num1} <--- is positive!");
                return true;
            }
            else
            {
                Console.WriteLine($"{num1} <--- is negative!");
                return false;
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote. 

        public static bool VotingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Yay! you can vote! so cool!");
                return true;
            }
            else
            {
                Console.WriteLine("Not yet!");
                return false;
            }
        }

        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static bool InRange(int num)
        {
            if (num <= 10 && num >= -10)
            {
                Console.WriteLine("Yes its in range!");
                return true;
            }
            else
            {
                Console.WriteLine($"{num} is not in range!");
                return false;
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void Table(int num2)
        {
            int result;

           for (int i = 1; i <= 12; i++)
           {
                result = num2 * i;
                Console.WriteLine($"{i} * {num2} = {result}  \n");
                
           }
        }



    }
}
