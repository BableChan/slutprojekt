using System.ComponentModel.DataAnnotations;
Operator Phaquirr = new(
    name: "Phaquirr",
    hitPoints: 500,
    basicAttackDamage: 70,
    gimmickAttack: 70
);


Operator Aryas = new(
    name: "Arya",
    hitPoints: 400,
    basicAttackDamage: Random.Shared.Next(65, 100),
    gimmickAttack: 20
);


// CoinFlip();
Rounds(Phaquirr, Aryas);
OperatorSelection();




static void OperatorSelection()
{
    string[] operatorInformationArray = { "Phaquirr - Technician, Damage Specialist", "Arya - Ranger, Dissruptor" };
    Console.WriteLine("Choose your Operator by entering the displayed number.");
    Thread.Sleep(1000);
    for (int i = 0; i < operatorInformationArray.Count(); i++)
    {
        Console.WriteLine($"({i}) {operatorInformationArray[i]}");
    }
    Console.ReadLine();


    string operatorSelected = Console.ReadLine();
    while (int.TryParse(operatorSelected, out int operatorSelectedInt) == false || 0 < operatorSelectedInt || operatorSelectedInt < operatorSelected.Count())
    {
        Console.WriteLine("invalid answer, try again.");
        operatorSelected = Console.ReadLine();
    }
}



static int CoinFlip()
{
    string playerStarts = Random.Shared.Next(2) == 0 ? "left" : "right";


    int coinFlipSleepAnimation = 30;
    Console.WriteLine("Flip a coin tetermine who starts");
    Console.ReadLine();
    for (int i = 0; i < coinFlipSleepAnimation; i++)
    {
        Thread.Sleep(10 * i);
        Console.Clear();
        int coinFlip = Random.Shared.Next(2);
        string coinFlipName = "tails";
        if (coinFlip == 1) coinFlipName = "Heads";

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

static void Rounds(Operator Phaquirr, Operator Aryas)
{
    Console.WriteLine(Phaquirr.Name);
    Console.ReadLine();
}
