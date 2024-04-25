using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondWeek
{
    internal abstract class Map
    {
        protected Player player = null;

        public Map()
        { 
        }

        public abstract void Update(Player _player);
    }
}
