using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1004_Methods
{
    class Program
    {
        private static string monthlyWages;

        static void Main(string[] args)
        {
            //Create a method called FavoriteFood.
            //It should take two string parameters. One representing a name, and the other representing a favorite food.
            //The return type should be void.
            //The method should concatenate
            FavoriteFood("Maddie", "tofu stir-fry");

            //Create a method called RetirementCalculator.
            //It should take an int as a parameter representing the users age.
            //The method should calculate how many more years until the user retires using 65 as the age of retirement.
            //The return type should be void.
            //Once it calculates the users retirement age it should print The user will retire in X years, 
            //where X represents the value that was calculated.
            RetirementCalculator(50);

            //Create a method called WageCalculator.
            //It should take two double parameters. One should represent the hours worked and the other represent the hourly wage.
            //The return type should be of type of double.
            //The method should calculate the monthly wage.
            //Once it calculates the monthly wage it should

            double monthlyWages = WageCalculator(25.25, 10.00);
            Console.WriteLine("Your total monthly wages are $" + monthlyWages + "."); //How to print 2 decimal places?

            //Create two methods of your choosing. At least one of the methods should have a non-void return type.
            //Both of the methods should take at least one parameter
            //Remember when naming your method that it should represent what your method should do.
            //Your method should only aim to accomplish one thing.

            //Problem #1
            Console.WriteLine(SayHello("Cam"));

            SayGoodbye("Gracie");

            //Problem #2 - is this the same as #1?

            //Problem #3
            Console.WriteLine("The sum of the two numbers is " + SumIt(8, 4) + ".");

            //Problem #4
            int[] example = { 20, 10, 5, 2 };
            Console.WriteLine("The sum of the example array is " + TotalIt(20, 10, 5, 2));

            //Problem #5
            Console.WriteLine("The doubled integer is " + DoubleIt(15) + ".");
            
        }

        private static void println(object p)
        {
            throw new NotImplementedException();
        }

        public static void FavoriteFood(string userName, string favFood)
        {
            Console.WriteLine(userName + "'s favorite food is " + favFood + ".");
        }

        public static void RetirementCalculator(int userAge)
        {
            int retirementAge = 65 - userAge;
            Console.WriteLine("The user will retire in " + retirementAge + " years.");
        }

        public static double WageCalculator(double hoursWorked, double hourlyWage)
        {
            double monthlyWages = hoursWorked * hourlyWage;

            return monthlyWages;
        }
        
        public static string SayHello(string name)
        {
            string sayHello = ("Hello, " + name + "!");

            return sayHello;
        }
        public static void SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye, " + name + ".");
        }

        public static int SumIt(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;

            return sum;
        }

        public static int TotalIt(int exampleOne, int exampleTwo, int exampleThree, int exampleFour)
        {
            int totalIt = exampleOne + exampleTwo + exampleThree + exampleFour;

            return totalIt;
        }

        public static int DoubleIt(int userNumber)
        {
            int doubledNumber = userNumber * 2;

            return doubledNumber;
        }


    }
}
