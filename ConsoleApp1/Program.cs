using System.Security.AccessControl;
using Microsoft.VisualBasic;

List<Operator> operatorList = new();
int randomPlayerSelector = Random.Shared.Next(2);

Operator Phaquirr = new(
    name: "Phaquirr",
    hitPoints: 500,
    basicAttackDamage: 70,
    gimmickAttack: 70,
    operatorList,
    operatorDescription: "Phaquirr - Damage Specialist, Technician"
);


Operator Aryas = new(
    name: "Arya",
    hitPoints: 400,
    basicAttackDamage: Random.Shared.Next(65, 100),
    gimmickAttack: 20,
    operatorList,
    operatorDescription: "Arya - Ranger, Dissruptor"
);


Operator MrBigRed = new(
    name: "Mr. Big Red",
    hitPoints: 1000,
    basicAttackDamage: 45,
    gimmickAttack: 70,
    operatorList,
    operatorDescription: "Mr. Big Red - Tank, Stalwart"
);
operatorList = [Phaquirr, Aryas, MrBigRed];









Operator player1Operator = OperatorSelection(operatorList, randomPlayerSelector);
Rounds(player1Operator, Aryas);

Console.WriteLine("Press ENTER to close");
Console.ReadLine();










static Operator OperatorSelection(List<Operator> operatorList, int randomPlayerSelector)
{
    randomPlayerSelecting(randomPlayerSelector);
    Thread.Sleep(1000);
    for (int i = 0; i < operatorList.Count(); i++)
    {
        Console.WriteLine($"({i}) {operatorList[i].OperatorDescription}");
    }


    string operatorSelected = Console.ReadLine();
    int operatorSelectedInt;
    while (int.TryParse(operatorSelected, out operatorSelectedInt) == false || operatorSelectedInt < 0 || operatorSelectedInt >= operatorList.Count)
    {
        Console.WriteLine("invalid answer, try again.");
        operatorSelected = Console.ReadLine();
    }
    return operatorList[operatorSelectedInt];
    
}

static void randomPlayerSelecting(int randomPlayerSelector)
{
    List<string> playerPositionList = ["left", "right"];



    string randomPlayerSelectorPosition = "left";
    if (randomPlayerSelector == 1) 
    {
        randomPlayerSelectorPosition = "right";
        playerPositionList.RemoveAt(1);
    }
    Console.WriteLine($"Player to the {randomPlayerSelectorPosition}, choose your Operator by entering the displayed number.");
}

// CoinFlip 
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