using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Итоговое_задание_ООП.Model;
using Итоговое_задание_ООП.Presenter;

namespace Итоговое_задание_ООП.Viewer
{
    internal class Ending
    {
        public static void Again()
        {
            Console.WriteLine("Хотите начать сначала?");
            Console.WriteLine("1 - Да!");
            Console.WriteLine("2 - Нет :~(");
            if (Console.ReadLine().Equals("1"))
            {
                Hero hero = new Hero(100, 50, 50);
                AdventureDescript.WelcomeDesript();
                PrintCreature.CreatureToPrint(hero);
                HeroAction.ChooseYourActionInTheTown(hero);
            }

        }
    }
}
