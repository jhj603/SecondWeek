using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondWeek
{
    internal class Player
    {
        public int Level { get; }
        public string Name { get; }
        public string PlayerClass { get; }
        public int Attack { get; }
        public int Defense { get; }
        public int HP { get; }
        public int Gold { get; }

        public Player()
        {
            Level = 1;
            Name = "JHJ";
            PlayerClass = "전사";
            Attack = 10;
            Defense = 5;
            HP = 100;
            Gold = 1500;
        }
    }
}
