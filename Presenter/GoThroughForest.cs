using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Итоговое_задание_ООП.Model;
using Итоговое_задание_ООП.Viewer;

namespace Итоговое_задание_ООП.Presenter
{
    internal class GoThroughForest
    {
        public static void AtackInForest(Hero hero)
        {
            AdventureDescript.ForestDesript();
            Console.WriteLine("На вас напала стая орков!");
            int numbersOfAtackers = Service.RandomNumberA() ;
            Console.WriteLine($"Орки: {numbersOfAtackers} штук.");
            List<Ork> orklist = new List<Ork>();
            for (int i =0; i<numbersOfAtackers; i++)
            {
                Ork ork = Ork.ToCreateOrk();
                orklist.Add(ork);
            }
            if (hero.GetHP() <= 0) { }
            else
            {
                Fight.Battle<Ork>(orklist, hero);
                if (hero.GetHP() <= 0) { }
                else
                {
                    Console.WriteLine("====Вы прошли сквозь лес====");
                }
                
            }
            HeroAction.ChooseYourActionInTheTown(hero);

        }
    }
}
