Metod();


Console.WriteLine("Hello, World!");
static void Metod()

{
    string[] characters = { "SpiderMan", "GreenGoblin" };
    Console.WriteLine(characters[0]);
    int SpiderManHp = 100;
    int GreenGoblinHp = 100;

    string name = "";

    while (name != "SpiderMan")
    {
        Console.WriteLine("Skriv in SpiderMan och tryck enter för att fortsätta spelet!");
        name = Console.ReadLine();
        Console.WriteLine("Fortsätt klicka enter till spelet är avslutat");
        Console.ReadLine();
}


    Random generator = new Random();
    
    string SpiderManName = "HERO";
    string GreenGoblinName = "Villain";

    while (SpiderManHp > 0 && GreenGoblinHp > 0)
    {
        Console.WriteLine("\n----- ===== NY OMGÅNG ===== -----");
        Console.WriteLine($"{SpiderManName}: {SpiderManHp}  {GreenGoblinName}: {GreenGoblinHp}\n");

        int heroDamage = generator.Next(20);
        if (SpiderManHp > 50)
        {
            int tal = generator.Next(20);



        }

        GreenGoblinHp -= heroDamage;
        GreenGoblinHp = Math.Max(0, GreenGoblinHp);
        Console.WriteLine($"{SpiderManName} gör {heroDamage} skada på {GreenGoblinName}");

        int GreenGoblinDamage = generator.Next(20);
        SpiderManHp -= GreenGoblinDamage;
        SpiderManHp = Math.Max(0, SpiderManHp);
        Console.WriteLine($"{GreenGoblinName} gör {GreenGoblinDamage} skada på {SpiderManName}");

        Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
        Console.ReadKey();
    }

    Console.WriteLine("\n----- ===== FIGHTEN ÄR SLUT ===== -----");

    if (SpiderManHp == 0 && GreenGoblinHp == 0)
    {
        Console.WriteLine("OAVGJORT");
    }
    else if (SpiderManHp == 0)
    {
        Console.WriteLine($"{GreenGoblinHp} vann!");
    }
    else
    {
        Console.WriteLine($"{SpiderManName} vann!");
    }
    if (SpiderManHp > 20)
{
  Console.WriteLine("Utklassning av SpiderMan");
}

if (SpiderManName == "SpiderMan")
{
  Console.WriteLine("Utklassning av SpiderMan");
}

if (GreenGoblinHp > 20)
{
  Console.WriteLine("Utklassning av GreenGoblin");
}

if (GreenGoblinName == "GreenGoblin")

  Console.WriteLine("Utklassning av SpiderMan");
{
    Console.WriteLine("Tryck på enter för att avsluta.");
    Console.ReadKey(true);

    
    int r = generator.Next(5);

}

}
