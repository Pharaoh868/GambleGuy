namespace GambleGuy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Cash = 100, Name = "The Player" };
            Console.WriteLine("Welcome to the Casino. The odds are " + odds);

            while (player.Cash>0)
            {
                player.WriteMyInfo();
                Console.Write("How much do you want to bet: ");
                string howMuch = Console.ReadLine();

                if (int.TryParse(howMuch,out int amount))
                {
                    int pot = amount;
                    pot *= 2;
                    if (random.NextDouble() > odds)
                    {
                        Console.WriteLine("YOU WIN" + pot);
                        player.ReceiveCash(pot);

                    }
                    else
                    {
                        Console.WriteLine("BAD LUCK YOU LOSE LMAO");
                        player.Cash -= amount;
                    }
                    

                  
                }
            }  Console.WriteLine("THE HOUSE ALWAYS WINS!");
        }
    }
}