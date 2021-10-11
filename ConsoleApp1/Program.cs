using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare Variable and type
            double myNum1;
            double myNum2;
            double myAns;
            string myOps;

            // Ask for first number
            Console.Write("Enter an integer value: ");
            myNum1 = Double.Parse(Console.ReadLine());

            // Ask for operation
            Console.Write("Enter an operator [ Subtract - , Plus + , Multiply * or Division / ]: ");
            myOps = Console.ReadLine();

            // Ask for second number
            Console.Write("Enter another integer value: ");
            myNum2 = Double.Parse(Console.ReadLine());


            // Check what operation has been entered
            switch (myOps)
            {

                case ("-"):
                    myAns = myNum1 - myNum2;
                    Console.WriteLine(myNum1 + " minus " + myNum2 + " equals " + myAns);
                    break;
                case ("+"):
                    myAns = myNum1 + myNum2;
                    Console.WriteLine(myNum1 + " plus " + myNum2 + " equals " + myAns);
                    break;
                case ("*"):
                    myAns = myNum1 * myNum2;
                    Console.WriteLine(myNum1 + " times " + myNum2 + " equals " + myAns);
                    break;
                case ("/"):
                    myAns = myNum1 / myNum2;
                    Console.WriteLine(myNum1 + " divided " + myNum2 + " equals " + myAns);
                    break;
            }
            Console.ReadKey();
        }
    }
}
