using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Итоговое_задание_ООП.Model;
using Итоговое_задание_ООП.Viewer;

namespace Итоговое_задание_ООП.Presenter
{
    internal class GoThroughField
    {
        public static void AtackInField(Hero hero)
        {
            AdventureDescript.FieldDesript();
            Console.WriteLine("На вас напала банда гоблинов!");
            int numbersOfAtackers = Service.RandomNumberA();
            Console.WriteLine($"Гоблины: {numbersOfAtackers} штук.");
            List<Goblin> goblinlist = new List<Goblin>();
            for (int i = 0; i < numbersOfAtackers; i++)
            {
                Goblin Goblin = Goblin.ToCreateGoblin();
                goblinlist.Add(Goblin);
            }
            if (hero.GetHP() <= 0)
            {
                
            } 
            else
            {
                Fight.Battle<Goblin>(goblinlist, hero);
                if (hero.GetHP() <= 0)
                {

                }
                else 
                {
                    Console.WriteLine("====Вы прошли через поле====");
                }
                    
            }
            HeroAction.ChooseYourActionInTheTown(hero);
        }
    }
}
