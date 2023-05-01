using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Итоговое_задание_ООП.Model;
using Итоговое_задание_ООП.Presenter;

namespace Итоговое_задание_ООП.Viewer
{
    internal class PrintCreature 
    {
        public static void CreatureToPrint<T>(T creature) where T : Creature
        {
            Console.Out.WriteLine(creature.ToString());
        }
    }
}
