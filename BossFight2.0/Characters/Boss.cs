using BossFight2._0.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight2._0.Characters
{
    internal class Boss : Character
    {

        public Boss()
        {

            Name = "Boss";
            MaxHealth = 400;
            Health = MaxHealth;
            Strength = 10;
            MaxStamina = 40;
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
