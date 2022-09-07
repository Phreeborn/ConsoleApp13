using System;

namespace ConsoleApp13
{
    internal class AirConditioner
    {
        static void Main(string[] args)  //method
        {
            Console.WriteLine("Blowing cool air");
            var amount = compoundinterest();
            Console.WriteLine(amount);
            //int calories = Eating("pasta");
            //Console.WriteLine($"We get {calories} from the food ");
            //}

            //    private int vend;  //field

            //    public string Condenser { get; set; } // property

            //    public delegate int AddNumbers(int a, int b); // delegate

            //    public AirConditioner(string compressor)  //constructor
            //    {

            //    }

            //    ~AirConditioner()  //destructor
            //    {
            //        Console.WriteLine("Clear the water away");

            //    }

            //    int Calculator(int firstNumber, int secondNumber) //method/function
            //    {
            //        return firstNumber + secondNumber;
            //    }

            //static int Eating(string food)
            //{
            //    if (food == "rice")
            //    {
            //        return 500;
            //    }
            //    else if (food == "fufu")
            //    {
            //        return 300;
            //    }
            //    else
            //    {
            //        return 100;
            //    }


            //}


            //    string CommonNames()
            //    {
            //        return "Peace";
            //    }

            //static void Worrying()
            //{


            //    int total = 0;
            //    for (int i = 0; i < 12; i++)
            //    {

            //        total = total + i;
            //        Console.WriteLine($"Hello i am {total}for now");
            //    }
            //}

            //static void Worryingchidi()
            //{
            //    int[] apcFans = {23,17,21,31,27,18 };

            //        int total =0;
            //    foreach (var youthAge in apcFans)
            //    {
            //        total += youthAge;
            //    }
            //   int sum = total;
            //   Console.WriteLine($"the total age of apc fans is {total}");
            //   Console.ReadLine();



        }
        static double compoundinterest()
        {
            double amount;
            double principal = 10000;
            double rate = .01;
            for (int i = 1; i < 20; i++)
            {
                amount = principal * Math.Pow(1 + rate, 1);
            }
            return amount;


        }
    }


