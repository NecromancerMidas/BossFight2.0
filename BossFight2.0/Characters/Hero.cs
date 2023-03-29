using BossFight2._0.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight2._0.Characters
{
    internal class Hero : Character
    {
        public Hero()
        {
            Name = "Hero";
            MaxHealth = 100;
            Health = MaxHealth;
            Strength = 20;
            MaxStamina = 60;
            Stamina = MaxStamina;
            Potions = new Item[] {
                new HealthPotion(MaxHealth),
                new StaminaPotion(MaxStamina),
                new StrengthPotion(Strength),
                new MixedPotion(MaxHealth,Strength,Stamina)
            };
        }

    }



}
