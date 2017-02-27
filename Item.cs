using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds
{
    public class Item
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public int BaseValue { get; set; }
        public int Rarity { get; set; }
        public bool IsEquipable{ get; set; }
        public condition Condition { get; set; }

        public int TrueValue
        {
            get { return BaseValue * Rarity * (int)Condition; }
        }

    public enum condition
        {
            broken = 0,
            damaged = 1,
            ordinary = 2,
            exquisite =3
        }

    }
}
