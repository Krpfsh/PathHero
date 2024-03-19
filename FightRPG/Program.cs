using System;
class Program
{
    static List<Fighter> fighters = new List<Fighter>
        {
            new Warrior("Warrior", 100, armor: 20,20,"Double Damage",4),
            new Rogue("Rogue", 90, armor : 20, 10, "Dodge", 2),
            new Druid("Druid", 110, armor : 20, 20, "Heal",3),
            new Tank("Tank", 120, armor : 500, 20, "Defense",4),
            new Mage("Mage", 90, armor : 20, 15, "Mana", 2)
        };
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Fighter Battle Game!");


        // Здесь пользователь может выбрать двух бойцов для боя
        Console.WriteLine("Choose your fighters:");
        for (int i = 0; i < fighters.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {fighters[i].Name}");
        }

        Console.WriteLine("Enter the number of the first fighter:");
        int fighterIndex1 = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter the number of the second fighter:");
        int fighterIndex2 = int.Parse(Console.ReadLine());

        Fight(  fighterIndex1,  fighterIndex2);
    }
    private static Fighter CreateHero(int value)
    {
        switch (value)
        {
            case 1:
                return new Warrior("Warrior", 100, armor: 20, 20, "Double Damage", 4);
            case 2:
                return new Rogue("Rogue", 90, armor: 20, 10, "Dodge", 2);
            case 3:
                return new Druid("Druid", 110, armor: 20, 20, "Heal", 3);
            case 4:
                return new Tank("Tank", 120, armor: 500, 20, "Defense", 4);
            case 5:
                return new Mage("Mage", 90, armor: 20, 15, "Mana", 2);
            default:
                return new Warrior("Warrior", 100, armor: 20, 20, "Double Damage", 4);
        }
    }
    public static void Fight( int x, int y)
    { 
        Fighter selectedFighter1Copy = CreateHero(x);
        Fighter selectedFighter2Copy = CreateHero(y);
        int Round = 1;
        Console.WriteLine($"Начинается бой между {selectedFighter1Copy.Name} и {selectedFighter2Copy.Name}. \n_________________________________________________\nРаунд - {Round}");
        while (selectedFighter1Copy.Health > 0 && selectedFighter2Copy.Health > 0)
        {
            if((Round % selectedFighter1Copy.SpecialAbilityActivator) ==0)
            {
                selectedFighter1Copy.Ability();
            }
            if((Round % selectedFighter2Copy.SpecialAbilityActivator )== 0)
            {
                selectedFighter2Copy.Ability();
            }


            float damageMultiplayerFighter1 = (float)selectedFighter1Copy.AttackPower / (selectedFighter1Copy.AttackPower + selectedFighter2Copy.Armor);
            selectedFighter2Copy.Health -= (int)(selectedFighter1Copy.AttackPower * damageMultiplayerFighter1);
            Console.WriteLine($"{selectedFighter1Copy.Name} + ударил {selectedFighter2Copy.Name}, хп {selectedFighter2Copy.Name}: " + selectedFighter2Copy.Health);


            float damageMultiplayerFighter2 = (float)selectedFighter2Copy.AttackPower / (selectedFighter2Copy.AttackPower + selectedFighter1Copy.Armor);
            selectedFighter1Copy.Health -= (int)(selectedFighter2Copy.AttackPower * damageMultiplayerFighter2);
            Console.WriteLine($"{selectedFighter2Copy.Name} ударил {selectedFighter1Copy.Name}, хп {selectedFighter1Copy.Name}: " + selectedFighter1Copy.Health);


            Round++;
            Console.WriteLine($"Раунд - {Round}");
        }

        if(selectedFighter1Copy.Health <=0  && selectedFighter2Copy.Health <= 0)
        {
            Console.WriteLine("В бою никто не выжил");
            return;
        }
        // Вывод результата боя
        Console.WriteLine("Winner: " + (selectedFighter1Copy.Health > 0 ? selectedFighter1Copy.Name : selectedFighter2Copy.Name));


    }

}