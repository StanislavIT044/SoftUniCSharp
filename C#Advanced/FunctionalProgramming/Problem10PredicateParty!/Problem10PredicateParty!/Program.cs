using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem10PredicateParty
{
    class Program
    {
        static void Main()
        {
            List<string> partyMembers = Console.ReadLine()
                .Split()
                .ToList();
            List<string> listToPrint = partyMembers;

            Func<string, bool> doubleMembers = x =>{
                 if (true)
                 {

                 }
                 return true;
             };

            Func<string, bool> doubleMembersLenght = x =>
            {

                return true;
            };

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "party")
                {
                    break;
                }

                string[] tokens = command.Split();
                if (tokens[0] == "Double")
                {
                    if (tokens[1] == "StartsWith")
                    {

                    }
                    else if (tokens[1] == "Lenght")
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    if (tokens[1] == "StartsWith")
                    {

                    }
                    else if (tokens[1] == "Lenght")
                    {

                    }
                    else
                    {

                    }
                }

            }




        }
    }
}
