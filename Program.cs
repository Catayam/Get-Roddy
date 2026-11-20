
using Cartras_game;
using System;
using System.Threading;

internal class Program
{
    static bool devilOfferSeen = false;
    static bool devilMode = false;
    static bool apocalypseUnlocked = false;

    static int autoPrinters = 0;
    static int hackers = 0;
    static int contacts = 0;
    static int rescueIntel = 0;

    // DEVIL UPGRADES
    static int soulPrinters = 0;
    static int demonWorkers = 0;
    static int hellHackers = 0;
    static int soulContracts = 0;

    static decimal money = 0;
    static decimal moneyPerPress = 1;
    static decimal passiveIncome = 0;

    // NORMAL UPGRADE PRICES
    static decimal autoPrinterCost = 500;
    static decimal multiplierCost = 30000;
    static decimal hackerCost = 60000;
    static decimal contactsCost = 10000;
    static decimal intelCost = 120000;

    // DEVIL UPGRADE PRICES
    static decimal soulPrinterCost = 1000000;
    static decimal demonWorkerCost = 10000000;
    static decimal hellHackerCost = 50000000;
    static decimal soulContractCost = 250000000;
    static decimal apocalypseEngineCost = 1000000000;

    static decimal priceMultiplier = 0.6m;

    static void Main()
    {
        Console.Title = "GET RODDY | CLASSIFIED";
        Console.CursorVisible = true;

        Player Roddy = new Player("Roddy");

        money = Roddy.money;
        moneyPerPress = 1;

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
            money += passiveIncome;

            Console.Clear();

            if (devilMode)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("============== HELL MODE ==============");
                Console.ResetColor();
                Console.WriteLine(" THE DEVIL OWNS YOUR SOUL.");
                Console.WriteLine($" SOUL CASH:          ${money:N0}");
                Console.WriteLine($" MONEY PER PRESS:    ${moneyPerPress:N0}");
                Console.WriteLine($" HELL INCOME:        ${passiveIncome:N0}/sec");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($" DEMON WORKERS:      {demonWorkers}");
                Console.WriteLine($" SOUL PRINTERS:      {soulPrinters}");
                Console.WriteLine($" HELL HACKERS:       {hellHackers}");
                Console.WriteLine($" SOUL CONTRACTS:     {soulContracts}");
                Console.WriteLine("--------------------------------------");

                if (apocalypseUnlocked)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" [A]  INITIATE THE APOCALYPSE");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("-------------- SAVIOUR-CORP --------------");
                Console.ResetColor();

                Console.WriteLine($" AGENT FUNDS:       ${money:N0}");
                Console.WriteLine($" MONEY PER PRESS:   ${moneyPerPress:N0}");
                Console.WriteLine($" PASSIVE INCOME:    ${passiveIncome:N0}/sec");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($" RESCUE INTEL:      {rescueIntel}/10");
                Console.WriteLine("------------------------------------------");
            }

            Console.WriteLine(" [ENTER]  Print money");
            Console.WriteLine(" [M]      Headquarters");
            Console.WriteLine(" [R]      Rescue Roddy");
            Console.WriteLine(" [ESC]    Abandon mission");
            Console.WriteLine("------------------------------------------");

            ConsoleKey key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.Enter)
            {
                money += moneyPerPress;

                // DEVIL OFFER
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
                        TypeLine("You have potential.", 40);
                        TypeLine("Give me your soul...", 40);

                        Console.ResetColor();

                        Console.WriteLine("\n[1] ACCEPT THE DEAL");
                        Console.WriteLine("[2] REJECT THE DEAL");

                        string choice = Console.ReadLine() ?? "";

                        if (choice == "1")
                        {
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;

                            TypeLine("CONTRACT SIGNED.", 50);
                            TypeLine("YOUR SOUL IS NO LONGER YOURS.", 50);
                            TypeLine("WELCOME TO HELL.", 50);

                            Console.ResetColor();

                            Thread.Sleep(1500);

                            devilMode = true;

                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;

                            TypeLine("HELL MODE UNLOCKED.", 50);
                            TypeLine("NEW UPGRADES AVAILABLE.", 50);
                            TypeLine("THE DEVIL EXPECTS RESULTS.", 50);

                            Console.ResetColor();

                            Thread.Sleep(1500);

                            loop = false;
                        }
                        else if (choice == "2")
                        {
                            Console.Clear();

                            TypeLine("DEAL REJECTED.", 40);
                            TypeLine("The entity disappears.", 40);

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
                if (!devilMode && rescueIntel >= 10 && money >= 10000000)
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
                    Console.Clear();

                    if (devilMode)
                    {
                        TypeLine("THE DEVIL BLOCKS YOUR PATH.", 40);
                        TypeLine("YOU SOLD YOUR SOUL.", 40);
                        TypeLine("RODDY IS NO LONGER YOUR PRIORITY.", 40);
                    }
                    else
                    {
                        TypeLine("RESCUE FAILED.", 35);
                        TypeLine("You need $10,000,000 and 10 Rescue Intel.", 35);
                    }

                    Thread.Sleep(1500);
                }
            }
            else if (key == ConsoleKey.A && devilMode && apocalypseUnlocked)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkRed;

                TypeLine("APOCALYPSE ENGINE ACTIVATED.", 60);
                TypeLine("THE SKY IS BREAKING.", 60);
                TypeLine("THE WORLD IS BURNING.", 60);
                TypeLine("ALL SOULS BELONG TO THE DEVIL.", 60);

                Console.WriteLine(@"

             THE APOCALYPSE
     

           EARTH HAS FALLEN.

           YOU ARE THE DEVIL'S
           MOST POWERFUL EMPLOYEE.

             TRUE EVIL ENDING

");

                Console.ResetColor();
                Console.ReadKey(true);
                return;
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

            if (devilMode)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("       HELL CORPORATION HQ");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("       SAVIOUR-CORP HEADQUARTERS");
                Console.ResetColor();
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Funds: ${money:N0}");
            Console.WriteLine($"Income: ${passiveIncome:N0}/sec");
            Console.WriteLine($"Money Per Press: ${moneyPerPress:N0}");
            Console.WriteLine("--------------------------------");

            // NORMAL UPGRADES
            Console.WriteLine($"[1] Auto Printer - ${autoPrinterCost:N0} (Owned: {autoPrinters})");
            Console.WriteLine($"[2] Money Multiplier - ${multiplierCost:N0}");
            Console.WriteLine($"[3] Hacking Software - ${hackerCost:N0} (Owned: {hackers})");
            Console.WriteLine($"[4] Underground Contacts - ${contactsCost:N0} (Owned: {contacts})");
            Console.WriteLine($"[5] Rescue Intel - ${intelCost:N0}");

            // DEVIL UPGRADES
            if (devilMode)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine("--------------------------------");
                Console.WriteLine("[7] Soul Printer - $" + soulPrinterCost.ToString("N0")
                    + $" (Owned: {soulPrinters})");

                Console.WriteLine("[8] Demon Workers - $" + demonWorkerCost.ToString("N0")
                    + $" (Owned: {demonWorkers})");

                Console.WriteLine("[9] Hell Hacker - $" + hellHackerCost.ToString("N0")
                    + $" (Owned: {hellHackers})");

                Console.WriteLine("[10] Soul Contracts - $" + soulContractCost.ToString("N0")
                    + $" (Owned: {soulContracts})");

                if (!apocalypseUnlocked)
                {
                    Console.WriteLine("[11] Apocalypse Engine - $" + apocalypseEngineCost.ToString("N0"));
                }
                else
                {
                    Console.WriteLine("[11] Apocalypse Engine - UNLOCKED");
                }

                Console.ResetColor();
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("[6] Return to mission");
            Console.Write("\nPurchase upgrade: ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                // AUTO PRINTER
                case "1":
                    if (money >= autoPrinterCost)
                    {
                        money -= autoPrinterCost;
                        autoPrinters++;
                        passiveIncome += 5;
                        autoPrinterCost *= priceMultiplier;

                        TypeLine("AUTO PRINTER PURCHASED! +$5/SEC", 25);
                    }
                    else TypeLine("NOT ENOUGH MONEY.", 25);
                    break;

                // MULTIPLIER
                case "2":
                    if (money >= multiplierCost)
                    {
                        money -= multiplierCost;

                        // 2x money earned per press
                        moneyPerPress *= 2;

                        // Increase next upgrade price
                        multiplierCost *= priceMultiplier;

                        Console.WriteLine($"MONEY PER PRESS IS NOW ${moneyPerPress:N0}!");
                        TypeLine("MONEY PER PRESS DOUBLED!", 25);
                    }
                    else
                    {
                        TypeLine("NOT ENOUGH MONEY.", 25);
                    }
                    break;

                // HACKER
                case "3":
                    if (money >= hackerCost)
                    {
                        money -= hackerCost;
                        hackers++;
                        rescueIntel += 2;
                        hackerCost *= priceMultiplier;

                        TypeLine("SECURITY BREACHED! +2 RESCUE INTEL", 25);
                    }
                    else TypeLine("NOT ENOUGH MONEY.", 25);
                    break;

                // CONTACTS
                case "4":
                    if (money >= contactsCost)
                    {
                        money -= contactsCost;
                        contacts++;
                        passiveIncome += 25;
                        contactsCost *= priceMultiplier;

                        TypeLine("UNDERGROUND NETWORK ESTABLISHED! +$25/SEC", 25);
                    }
                    else TypeLine("NOT ENOUGH MONEY.", 25);
                    break;

                // RESCUE INTEL
                case "5":
                    if (money >= intelCost)
                    {
                        money -= intelCost;
                        rescueIntel += 2;
                        intelCost *= priceMultiplier;

                        TypeLine("RESCUE INTEL ACQUIRED!", 25);
                    }
                    else TypeLine("NOT ENOUGH MONEY.", 25);
                    break;

                // RETURN
                case "6":
                    return;

                // SOUL PRINTER
                case "7":
                    if (devilMode)
                    {
                        if (money >= soulPrinterCost)
                        {
                            money -= soulPrinterCost;
                            soulPrinters++;
                            passiveIncome += 100;
                            soulPrinterCost *= priceMultiplier;

                            TypeLine("SOUL PRINTER PURCHASED! +$100/SEC", 25);
                        }
                        else TypeLine("NOT ENOUGH SOUL CASH.", 25);
                    }
                    break;

                // DEMON WORKERS
                case "8":
                    if (devilMode)
                    {
                        if (money >= demonWorkerCost)
                        {
                            money -= demonWorkerCost;
                            demonWorkers++;
                            passiveIncome += 1000;
                            demonWorkerCost *= priceMultiplier;

                            TypeLine("DEMON WORKERS HIRED! +$1,000/SEC", 25);
                        }
                        else TypeLine("NOT ENOUGH SOUL CASH.", 25);
                    }
                    break;

                // HELL HACKER
                case "9":
                    if (devilMode)
                    {
                        if (money >= hellHackerCost)
                        {
                            money -= hellHackerCost;
                            hellHackers++;
                            moneyPerPress *= 10;
                            hellHackerCost *= priceMultiplier;

                            TypeLine("HELL HACKER INSTALLED! MONEY PER PRESS x10!", 25);
                        }
                        else TypeLine("NOT ENOUGH SOUL CASH.", 25);
                    }
                    break;

                // SOUL CONTRACTS
                case "10":
                    if (devilMode)
                    {
                        if (money >= soulContractCost)
                        {
                            money -= soulContractCost;
                            soulContracts++;
                            passiveIncome += 10000;
                            soulContractCost *= priceMultiplier;

                            TypeLine("SOUL CONTRACTS SIGNED! +$10,000/SEC", 25);
                        }
                        else TypeLine("NOT ENOUGH SOUL CASH.", 25);
                    }
                    break;

                // APOCALYPSE ENGINE
                case "11":
                    if (devilMode)
                    {
                        if (!apocalypseUnlocked)
                        {
                            if (money >= apocalypseEngineCost)
                            {
                                money -= apocalypseEngineCost;
                                apocalypseUnlocked = true;

                                TypeLine("APOCALYPSE ENGINE PURCHASED.", 40);
                                TypeLine("THE END IS NOW IN YOUR HANDS.", 40);
                                TypeLine("RETURN TO THE MISSION AND PRESS [A].", 40);
                            }
                            else TypeLine("NOT ENOUGH SOUL CASH.", 25);
                        }
                        else
                        {
                            TypeLine("APOCALYPSE ENGINE ALREADY UNLOCKED.", 25);
                        }
                    }
                    break;

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
