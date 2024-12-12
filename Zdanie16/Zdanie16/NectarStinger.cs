using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdanie16
{
    class NectarStinger : Worker, INectarCollector, IStingPatrol
    {
        public int AlterLevel { get; private set; }
        public int StingerLength { get; set; }
        public int Nectar {  get; set; }



        public bool LookForEnemies()
        {
            return true;
        }

        public int SharpenStinger(int Length)
        {
            return 0;
        }



        public void FindFlowers()
        {

        }

        public void GatherNectar()
        {

        }

        public void ReturnToHive()
        {

        }
    }
}
