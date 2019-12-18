using System;
using System.Linq;

namespace Problem8Threeuple
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
            string town = string.Join(" ", inputPersonInfo.Skip(3));

            string name = inputPersonBeer[0];
            int litters = int.Parse(inputPersonBeer[1]);
            bool isDrunk = inputPersonBeer[2] == "drunk" ? true : false;

            string personName = inputNumbersInfo[0];
            double myDouble = double.Parse(inputNumbersInfo[1]);
            string bankNmae = inputNumbersInfo[2];

            Threeuple<string, string, string> personInfo = new Threeuple<string, string, string>(fullName, address, town);
            Threeuple<string, int, bool> personBeer = new Threeuple<string, int, bool>(name, litters, isDrunk);
            Threeuple<string, double, string> numbersInfo = new Threeuple<string, double, string>(personName, myDouble, bankNmae);

            Console.WriteLine(personInfo);
            Console.WriteLine(personBeer);
            Console.WriteLine(numbersInfo);
        }
    }
}