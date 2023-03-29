using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using BossFight2._0.Items;
namespace BossFight2._0.Characters
{
    internal class Character
    {
        protected string? Name;
        protected int Health;
        protected int Strength;
        protected int Stamina;
        protected int MaxStamina;
        protected int MaxHealth;
        protected Item[] Potions;

        public Character()
        {

            
        }
        public void Fight(Character enemy)
        {
            if (Stamina <= 0){ ChangeStamina(20);
                return;
            }
            enemy.Health -= Strength;
            ChangeStamina(-10);
        }
        public void UsePotion(Item potion)
        {
           ChangeStamina(potion.StaminaValue);
            Strength += potion.StrengthValue;
            Health += potion.HealthValue;
            potion.UsedPotion();

        }

        public void ChoosePotion()
        {
            var index = 0;
            start: Console.WriteLine(@"Your options H:Health Potion, S: Strength Potion, Z:Ztamina Potion, M:Mixed potion");
            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.H:
                    index = 0;
                    break;
                case ConsoleKey.Z:
                    index = 1;
                    break;
                case ConsoleKey.S:
                    index = 2;
                    break;
                case ConsoleKey.M:
                    index = 3;
                    break;
                default:
                    Console.WriteLine("Press valid key");
                    goto start;
            }
            UsePotion(Potions[index]);

        }
        public void ChangeStamina(int StaminaValue)
        {
            if ((Stamina += StaminaValue) > MaxStamina) Stamina = MaxStamina;
            if (Stamina <= 0) Stamina = 0;
            else Stamina += StaminaValue;

        }
        public static void Battle(Character hero, Character boss) //Vi liker ikkje detta, men gidder ikkje skrive på nyt.
        {
            
            while (true)
            {
                
                start:
                Console.WriteLine(@"Your options F:Fight, I:Item, S:Recharge");
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.F:
                        hero.Fight(boss);
                        break;
                    case ConsoleKey.I:
                        hero.ChoosePotion();
                        break;
                    case ConsoleKey.S:
                        hero.ChangeStamina(20);
                        break;
                    default:
                        Console.WriteLine("Press valid key");
                        goto start;
                }
                if (boss.Health <= 0)
                {
                    Console.WriteLine($@"{hero.Name} is the winner!");
                    return;
                }
                boss.Fight(hero);
                if (hero.Health <= 0)
                {
                    Console.WriteLine($@"{boss.Name} is the winner!");
                    return;
                }
               
                
            }
        }

    }
}
