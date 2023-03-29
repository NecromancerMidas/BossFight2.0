using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BossFight2._0.Characters;

namespace BossFight2._0.Items
{
    internal class StaminaPotion : Item
    {


        public StaminaPotion(int value)
        {
            StaminaValue = value / 2;
        }
    }
}
