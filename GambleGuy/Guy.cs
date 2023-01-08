using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GambleGuy
{
    internal class Guy
    {
        public string Name;
        public int Cash; 

        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " bucks.");
        }


        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
                return 0;
            }if (amount > Cash)
            {
                Console.WriteLine(Name + " says: " + "I dont have enough cash to give you" + amount);
                return 0;
            }
            Cash -= amount;
            return amount;
        }
        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: " + amount + " isnt ant amount i will take.");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
