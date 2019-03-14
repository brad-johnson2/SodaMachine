using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class SodaMachine
    {
        List<int> coinPayment = new List<int>();

        int pennies = 50;
        int nickels = 20;
        int dimes = 10;
        int quarters = 20;

        int grapeNumber = 15;
        int lemonNumber = 5;
        int orangeNumber = 30;

        List<int> machineCoins = new List<int> { pennies, nickels, dimes, quarters };
        public void Payment(List<Coin> payment, Can can)
        {
            int total = payment[0] + payment[1] * 5 + payment[2] * 10 + payment[3] * 25);
            if (total < Can.price)
            {
                Console.WriteLine("Not enough momey.");
                ClearPayment(); 
            }
            if (total = can.price)
            {
                if(can.inventory >= 1)
                {
                    AcceptPayment();
                    Can.inventory--;
                }
                else
                {
                    ClearPayment();
                }

                
            }
            if (total > can.price)
                if (can.inventory >= 1)
                {
                    if ("coin inventory - payment returns value below 0 for any index")
                    {
                        ClearPayment();
                    }
                    else
                    {
                        AcceptPayment();
                        DispenseChange();
                        can.inventory--;
                    }
                }
                else
                {
                    ClearPayment();
                }

        }

        private void AcceptPayment()
        {
            for (int i = 0; i <= 3; i++)
            {
                machineCoins[i] += payment[i];
            }

            
        }

        private List<int> DispenseChange(total, Can.price)
        {

            int change = total - Can.price;

            int quarters = Math.Floor(change / 25);
            int quarters_leftover = change % 25;

            int dimes = Math.Floor(quarters_leftover / 10);
            int dimes_leftover = quarters_leftover % 10;

            int nickels = Math.Floor(dimes_leftover / 5);
            int nickels_leftover = dimes_leftover % 5;

            int pennies = Math.Floor(nickels_leftover / 1);



        }

        private void ClearPayment()
        {
            coinPayment = null;
        }

        public List<int> InsertCoins()
        {
            
            Console.WriteLine("Grape is 60 cents. Orange is 35 cents. Lemon is 6 cents. Which coin are you inserting? 1. Penny 2. Nickel 3. Dime 4. Quarter 5. Finished");
            string coinChoice = Console.ReadLine();
            switch (coinChoice)
            {
                case "1":
                    coinPayment[0] += 1;
                    InsertCoins();
                    break;

                case "2":
                    coinPayment[1] += 1;
                    InsertCoins();
                    break;

                case "3":
                    coinPayment[2] += 1;
                    InsertCoins();
                    break;

                case "4":
                    coinPayment[3] += 1;
                    InsertCoins();
                    break;

                case "5":
                    return coinPayment;
                    

                default:
                    InsertCoins();
                    break;
            }

        }

    }
}
