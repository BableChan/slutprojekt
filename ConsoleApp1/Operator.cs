public class Operator(string name, int hitPoints, int basicAttackDamage, int gimmickAttack)
{
    public string Name { get; } = name;
    public int HitPoints { get; set; } = hitPoints;
    public int BasicAttackDamage { get; set; } = basicAttackDamage;
    public int GimmickAttack { get; set; } = gimmickAttack;
}
