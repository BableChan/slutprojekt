using Microsoft.VisualBasic;

public class Operator
{

    public Operator(string name, int hitPoints, int basicAttackDamage, int gimmickAttack, List<Operator> operatorList, string operatorDescription)
    {
        
        Name = name;
        HitPoints = hitPoints;
        BasicAttackDamage = basicAttackDamage;
        GimmickAttack = gimmickAttack;
        operatorList.Add(this);
        OperatorDescription = operatorDescription;
    }
    public string Name { get; }
    public int HitPoints { get; set; }
    public int BasicAttackDamage { get; set; }
    public int GimmickAttack { get; set; }
    public string OperatorDescription { get; }
}
