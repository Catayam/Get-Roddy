using System;
using System.Collections.Generic;
using System.Text;

namespace Cartras_game
{
    internal class Player
    {
        public String Name { get; set; }
        public int money { get; set; }
        public int phoneLevel { get; set; }
        public int moneyPerPress { get; set; }
        public Player(string name, int money = 0, int phoneLevel = 0, int moneyPerPress = 1)
        {
            Name = name;
            this.money = money;
            this.phoneLevel = phoneLevel;
            this.moneyPerPress = moneyPerPress;
        }

        public void UpgradePhone()
        {
            Console.Clear();
            Console.WriteLine(" PHONE UPGRADE ");
            Console.WriteLine($"Money: ${money}");
            Console.WriteLine("Upgrade cost: $10");
            Console.WriteLine("You Now Print 2 KennyBucks.\n");
            if (phoneLevel == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("You Already Have This Diddy!");
            }
            else if (money >= 10)
            {
                money -= 10;
                moneyPerPress = 2;

                Console.WriteLine("Phone upgraded!");
                Console.WriteLine("You now earn 2 KennyBucks per print!");
            }
            else
            {
                Console.WriteLine("You need $10 to buy this!");
            }
        }

        internal void GetMoney()
        {
            money += moneyPerPress;
        }
    }
}
