public class Tank : Fighter
{
    public Tank(string name, int health, int armor, int attackPower, string specialAbility, int specialAbilityActivator) : base(name, health, armor, attackPower, specialAbility, specialAbilityActivator)
    {
    }

    public override void Ability()
    {
        Console.WriteLine($"Танк повышает уровень лат, броня увеливается с {Armor} до {Armor + 5}");
        Armor += 5;
    }
}
