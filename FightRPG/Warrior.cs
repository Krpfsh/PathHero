public class Warrior : Fighter
{
    public Warrior(string name, int health, int armor, int attackPower, string specialAbility, int specialAbilityActivator) : base(name, health, armor, attackPower, specialAbility, specialAbilityActivator)
    {
    }

    public override void Ability()
    {
        Console.WriteLine("Воин воодушевляет себя криком, атака повышается с " + AttackPower + " до " + (AttackPower * 2));
        AttackPower *= 2;
    }
}
