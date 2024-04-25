using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SecondWeek
{
    public enum ItemType
    {
        WEAPON,
        ARMOR
    }

    internal class Item
    {
        public float Attack { get; set; }
        public int Defense { get; set; }
        public ItemType ItemType { get; set; }
        public int Gold { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsEquip { get; set; }

        public Item()
        {

        }

        public Item(float _attack, int _defense, ItemType _type, int _gold, string _name, string _desc, bool _isEquip = false)
        {
            Attack = _attack;
            Defense = _defense;
            IsEquip = _isEquip;
            ItemType = _type;
            Gold = _gold;
            Name = _name;
            Description = _desc;
        }
    }
}
