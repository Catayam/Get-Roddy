
using Cartras_game;
using System;
using System.Threading;

internal class Program
{
    static bool devilOfferSeen = false;

    static int autoPrinters = 0;
    static int hackers = 0;
    static int contacts = 0;
    static int rescueIntel = 0;

    static decimal money = 0;
    static decimal moneyPerPress = 1;
    static decimal passiveIncome = 0;

    static void Main()
    {
        Console.Title = "GET RODDY | CLASSIFIED";
        Console.CursorVisible = true;

        Player Roddy = new Player("Roddy");

        money = Roddy.money;
        moneyPerPress = Roddy.moneyPerPress;

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(@"
LE RODDyRichUms

");
        Console.ResetColor();

        Thread.Sleep(1000);

        TypeLine(">> INITIALIZING CLASSIFIED SYSTEM...", 25);
        TypeLine(">> CONNECTION ESTABLISHED.", 25);

        Thread.Sleep(500);

        Console.ForegroundColor = ConsoleColor.Red;
        TypeLine("\nYOUR FRIEND RODDY HAS BEEN CAPTURED.", 35);
        TypeLine("THE EVIL CORPORATION IS BEHIND THIS.", 35);
        Console.ResetColor();

        TypeLine("\nYour mission: GET RODDY BACK.", 35);
        TypeLine("......", 10);

        Console.Write("\nAre you ready to fight back? (y/n): ");

        if ((Console.ReadLine() ?? "").ToLower() != "y")
        {
            TypeLine("MISSION ABORTED.", 30);
            Console.ReadKey(true);
            return;
        }

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Green;
        TypeLine("MISSION ACCEPTED.", 50);
        TypeLine("OPERATION: GET RODDY.", 50);
        Console.ResetColor();

        while (true)
        {
            // PASSIVE INCOME
            money += passiveIncome;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-------------- SAVIOUR-CORP --------------");
            Console.ResetColor();

            Console.WriteLine($" AGENT FUNDS:       ${money}");
            Console.WriteLine($" MONEY PER PRESS:   ${moneyPerPress}");
            Console.WriteLine($" PASSIVE INCOME:    ${passiveIncome}/sec");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($" RESCUE INTEL:      {rescueIntel}/10");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(" [ENTER]  Print money");
            Console.WriteLine(" [M]      Saviour-Corp HQ");
            Console.WriteLine(" [R]      Rescue Roddy");
            Console.WriteLine(" [ESC]    Abandon mission");
            Console.WriteLine("------------------------------------------");

            if (Console.KeyAvailable)
            {
                // Clear leftover key presses
            }

            ConsoleKey key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.Enter)
            {
                money += moneyPerPress;

                if (money >= 666 && !devilOfferSeen)
                {
                    devilOfferSeen = true;
                    bool loop = true;
                    while (loop)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;

                    TypeLine("UNKNOWN ENTITY DETECTED.", 40);
                    TypeLine("I've been watching you.", 40);
                    TypeLine("Give me your soul...", 40);

                        while (Console.KeyAvailable)
                        {
                            Console.ReadKey(intercept: true);
                        }

                        Console.ResetColor();

                        Console.WriteLine("\n[1] ACCEPT THE DEAL");
                        Console.WriteLine("[2] REJECT THE DEAL");

                        string choice = Console.ReadLine() ?? "";

                        if (choice == "1")
                        {
                            Console.Clear();
                            TypeLine("CONTRACT SIGNED.", 50);
                            TypeLine("YOUR SOUL IS NO LONGER YOURS.", 50);
                            TypeLine("ENDING UNLOCKED: THE DEVIL'S EMPLOYEE", 50);
                            Console.ReadKey(true);
                            return;
                        }
                        if (choice == "2")
                        {
                            TypeLine("DEAL REJECTED.", 40);
                            Thread.Sleep(1500);
                            loop = false;
                        }
                    }
                }
            }
            else if (key == ConsoleKey.M)
            {
                Headquarters();
            }
            else if (key == ConsoleKey.R)
            {
                if (rescueIntel >= 10 && money >= 10000000)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;

                    TypeLine("SECURITY SYSTEM BREACHED.", 50);
                    TypeLine("LOCATION FOUND.", 50);
                    TypeLine("RODDY HAS BEEN LOCATED.", 50);

                    Thread.Sleep(1000);

                    TypeLine("\nYOU BREAK INTO THE FACILITY...", 50);
                    TypeLine("YOU FOUND RODDY!", 70);

                    Console.WriteLine(@"

        RESCUE SUCCESSFUL

          RODDY IS FREE!

          GOOD ENDING

");
                    Console.ResetColor();
                    Console.ReadKey(true);
                    return;
                }
                else
                {
                    TypeLine("RESCUE FAILED.", 35);
                    TypeLine("You need $10,000 and 10 Rescue Intel.", 35);
                    Thread.Sleep(1500);
                }
            }
            else if (key == ConsoleKey.Escape)
            {
                TypeLine("AGENT DISCONNECTED.", 40);
                return;
            }
        }
    }

    static void Headquarters()
    {
        while (true)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("       SAVIOUR-CORP HEADQUARTERS");
            Console.ResetColor();

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Funds: ${money}");
            Console.WriteLine($"Income: ${passiveIncome}/sec");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("[1] Auto Printer - $500");
            Console.WriteLine("[2] Money Multiplier - $30,000");
            Console.WriteLine("[3] Hacking Software - $60,000");
            Console.WriteLine("[4] Underground Contacts - $10,000");
            Console.WriteLine("[5] Rescue Intel - $333,333,333,333,333,333");
            Console.WriteLine("[6] Return to mission");
            Console.Write("\nPurchase upgrade: ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    if (money >= 500)
                    {
                        money -= 500;
                        autoPrinters++;
                        passiveIncome += 5;
                        TypeLine("AUTO PRINTER PURCHASED! +$5/SEC", 25);
                    }
                    else TypeLine("NOT ENOUGH MONEY.", 25);
                    break;

                case "2":
                    if (money >= 30000)
                    {
                        money -= 30000;
                        moneyPerPress *= 2;
                        TypeLine("MONEY PER PRESS DOUBLED!", 25);
                    }
                    else TypeLine("NOT ENOUGH MONEY.", 25);
                    break;

                case "3":
                    if (money >= 60000)
                    {
                        money -= 60000;
                        hackers++;
                        rescueIntel += 2;
                        TypeLine("SECURITY BREACHED! +2 RESCUE INTEL", 25);
                    }
                    else TypeLine("NOT ENOUGH MONEY.", 25);
                    break;

                case "4":
                    if (money >= 10000)
                    {
                        money -= 10000;
                        contacts++;
                        passiveIncome += 25;
                        TypeLine("UNDERGROUND NETWORK ESTABLISHED! +$25/SEC", 25);
                    }
                    else TypeLine("NOT ENOUGH MONEY.", 25);
                    break;

                case "5":
                    if (money >= 333333333333333333)
                    {
                        money -=  333333333333333333;
                        rescueIntel += 2;
                        TypeLine("RESCUE INTEL ACQUIRED!", 25);
                    }
                    else TypeLine("NOT ENOUGH MONEY.", 25);
                    break;

                case "6":
                    return;

                default:
                    TypeLine("INVALID COMMAND.", 25);
                    break;
            }

            Thread.Sleep(1000);
        }
    }

    static void TypeLine(string text, int delay)
    {
        foreach (char character in text)
        {
            Console.Write(character);
            Thread.Sleep(delay);
        }

        Console.WriteLine();
    }

}
