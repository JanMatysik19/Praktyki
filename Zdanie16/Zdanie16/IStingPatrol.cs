using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdanie16
{
    public interface IStingPatrol
    {
        int AlterLevel { get; }
        int StingerLength { get; }
        bool LookForEnemies();
        int SharpenStinger(int Length);
    }
}
