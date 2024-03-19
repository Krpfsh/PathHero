public class Fighter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Armor { get; set; }
    public int AttackPower { get; set; }
    public string SpecialAbility { get; set; }
    public int SpecialAbilityActivator { get; set; }

    public Fighter(string name, int health, int armor, int attackPower, string specialAbility, int specialAbilityActivator)
    {
        Name = name;
        Health = health;
        Armor = armor;
        AttackPower = attackPower;
        SpecialAbility = specialAbility;
        SpecialAbilityActivator = specialAbilityActivator;
    }
    public virtual void Ability()
    {

    }
}
