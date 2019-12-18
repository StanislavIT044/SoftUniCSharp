using System;

namespace Problem7.Tuple
{
    class Program
    {
        static void Main()
        {
            string[] inputPersonInfo = Console.ReadLine()
                .Split();
            string[] inputPersonBeer = Console.ReadLine()
                .Split();
            string[] inputNumbersInfo = Console.ReadLine()
                .Split();

            string fullName = inputPersonInfo[0] + " " + inputPersonInfo[1];
            string address = inputPersonInfo[2];

            string name = inputPersonBeer[0];
            int litters = int.Parse(inputPersonBeer[1]);

            int myInt = int.Parse(inputNumbersInfo[0]);
            double myDouble = double.Parse(inputNumbersInfo[1]);

            MyTuple<string, string> personInfo = new MyTuple<string, string>(fullName, address);
            MyTuple<string, int> personBeer = new MyTuple<string, int>(name, litters);
            MyTuple<int, double> numbersInfo = new MyTuple<int, double>(myInt, myDouble);

            Console.WriteLine(personInfo);
            Console.WriteLine(personBeer);
            Console.WriteLine(numbersInfo);
        }
    }
}