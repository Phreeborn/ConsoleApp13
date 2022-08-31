using System;

namespace ConsoleApp13
{
    internal class AirConditioner
    {
        static void Main(string[] args)  //method
        {
            Console.WriteLine("Blowing cool air");

            int calories = Eating("pasta");
            Console.WriteLine($"We get {calories} from the food ");
        }

        private int vend;  //field

        public string Condenser { get; set; } // property

        public delegate int AddNumbers(int a, int b); // delegate

        public AirConditioner(string compressor)  //constructor
        {

        }

        ~AirConditioner()  //destructor
        {
            Console.WriteLine("Clear the water away");

        }

        int Calculator(int firstNumber, int secondNumber) //method/function
        {
            return firstNumber + secondNumber;
        }

        static int Eating(string food)
        {
            if (food == "rice")
            {
                return 500;
            }
            else if (food == "fufu")
            {
                return 300;
            }
            else
            {
                return 100;
            }


        }


        string CommonNames()
        {
            return "Peace";
        }

        void Worrying()
        {

        }

    }
}
