using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight2._0.Items
{
    internal class Item
    {
        public int HealthValue { get; protected set; }
        public int StrengthValue {get; protected set; }
        public int StaminaValue { get; protected set; }
        public bool Used { get; protected set; }

        public void UsedPotion()
        {
            Used = true;
        }
    }
}
