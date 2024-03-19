public class Mage : Fighter
{
    public Mage(string name, int health, int armor, int attackPower, string specialAbility, int specialAbilityActivator) : base(name, health, armor, attackPower, specialAbility, specialAbilityActivator)
    {
    }

    public override void Ability()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 3);
        Console.WriteLine("Маг колдует нестабильную магию... в воздухе показывается число " + randomNumber);
        if (randomNumber == 0)
        {
            Console.WriteLine($"Маг залечивает свои раны, хп увеливается с {Health} до {Health +20}");
            Health += 20;
        }
        else if (randomNumber == 1) 
        {
            Console.WriteLine($"Маг создает сферу защиты, броня увеливается с {Armor} до {Armor + 10}");
            Armor += 10;
        }
        else if ( randomNumber == 2)
        {
            Console.WriteLine($"Маг создает сферу огня, атака увеливается с {AttackPower} до {AttackPower + 10}");
            AttackPower += 10;
        }
    }
}
