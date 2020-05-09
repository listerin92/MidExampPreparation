using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Man_O_War
{
    class Man_O_War
    {
        static void Main(string[] args)
        {
            List<int> statusOfPirateShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            List<int> statusOfWarShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            int maxHealthCapacity = int.Parse(Console.ReadLine());

            string commandLine = string.Empty;
            bool terminate = false;

            while ((commandLine = Console.ReadLine()) != "Retire")
            {
                string[] commandSplit = commandLine.Split().ToArray();
                string command = commandSplit[0];
                int index = int.Parse(commandSplit[1]);
                int attackPower = int.Parse(commandSplit[2]);

                if (command == "Fire")
                {
                    if (statusOfWarShip.Count - 1 > index)
                    {
                        statusOfWarShip[index] -= attackPower;
                    }

                    if (statusOfWarShip[index] <= 0)
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        break;
                    }
                }
                if (command == "")
                {

                }
            }

        }
    }
}
