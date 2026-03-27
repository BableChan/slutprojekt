using System.ComponentModel.DataAnnotations;
Character Phaquirr = new(
    name: "Phaquirr",
    hitPoints: 500,
    basicAttackDamage: 70,
    gimmickAttack: 70
);


Character Aryas = new(
    name: "Arya",
    hitPoints: 400,
    basicAttackDamage: Random.Shared.Next(65, 100),
    gimmickAttack: 20
);


CoinFlip();
Rounds(Phaquirr, Aryas);




// var characterOrderAssignment









static int CoinFlip()
{
    int coinFlipSleepAnimation = 30;
    Console.WriteLine("Flip a coin tetermine who starts");
    Console.ReadLine();
    for (int i = 0; i < coinFlipSleepAnimation; i++)
    {
        Thread.Sleep(10 * i);
        Console.Clear();
        int coinFlip = Random.Shared.Next(1, 3);
        string coinFlipName = "tails";
        if(coinFlip == 1)
        {
            coinFlipName = "Heads";
        }
        Console.WriteLine(coinFlipName);
    }

    var coinFlipResult = Random.Shared.Next(1, 3);
    Console.Clear();
    Console.WriteLine(coinFlipResult);
    Thread.Sleep(1000);
    if (coinFlipResult == 1)
    {

    }
    Console.WriteLine($"The coin has spoken. Player{coinFlipResult} starts.");
    Thread.Sleep(1000);
    Console.WriteLine("press enter to continue...");
    Console.ReadLine();
    Console.Clear();
    return coinFlipResult;
}

static void Rounds(Character Phaquirr, Character Aryas)
{
    Console.WriteLine(Phaquirr.Name);
    Console.ReadLine();
}
