
// Добавьте других бойцов по аналогии
public class Rogue : Fighter
{
    public Rogue(string name, int health, int armor, int attackPower, string specialAbility, int specialAbilityActivator) : base(name, health, armor, attackPower, specialAbility, specialAbilityActivator)
    {
    }

    public override void Ability()
    {

        Console.WriteLine("Разбойник затачивает клинки, атака повышается c " + AttackPower + " до " + (AttackPower+20));
        AttackPower += 20;
    }
}
