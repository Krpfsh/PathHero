public class Druid : Fighter
{
    public Druid(string name, int health, int armor, int attackPower, string specialAbility, int specialAbilityActivator) : base(name, health, armor, attackPower, specialAbility, specialAbilityActivator)
    {
    }

    public override void Ability()
    {
        Console.WriteLine($"Друид обращается за помощью к природе, хп увеливается с {Health} до {Health + Health * 0.3f}");
        Health += (int)(Health * 0.3f);
    }
}
