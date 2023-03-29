using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight2._0.Items
{
    internal class MixedPotion : Item
    {

        public MixedPotion(int healthValue, int strengthValue, int staminaValue)
        {
            HealthValue = healthValue / 3;
            StrengthValue = strengthValue / 2;
            StaminaValue = staminaValue / 3;
        }
    }
}
