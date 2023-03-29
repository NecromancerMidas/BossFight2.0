using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BossFight2._0.Characters;

namespace BossFight2._0.Items
{
    internal class HealthPotion : Item
    {
        public HealthPotion(int value)
        {
            HealthValue = value / 2;

        }
    }
}
