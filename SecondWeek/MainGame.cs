using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace SecondWeek
{
    internal class MainGame
    {
        Player player = null;
        Map currentMap = null;      // 마을, 던전

        public bool Initialize()
        {
            if (null == player)
                player = new Player();             
            
            if (null == currentMap)
                currentMap = new Town(player);

            return true;
        }

        public void Update()
        {
            while (true)
            {
                currentMap.Draw();

                
            }
        }
    }
}
