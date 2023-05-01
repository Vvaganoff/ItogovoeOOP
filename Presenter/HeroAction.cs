using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Итоговое_задание_ООП.Model;
using Итоговое_задание_ООП.Viewer;

namespace Итоговое_задание_ООП.Presenter
{
    internal class HeroAction
    {
        public static string ChooseYourAction()
        {
            Console.WriteLine("Ваши действия?" + "\n" +
                "1 - Атака" + "\n" +
                "2 - Защита");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    return "atack";
                case "2":
                    return "defense";
            }
            return "";

        }

        public static void ToHeal(Hero hero)
        {
            if (hero.GetHP() < 100) 
            {
                hero.SetHP(hero.GetHP() + 10);
            } else
            {
                Console.WriteLine("У вас максимальное здоровье");
            }
            
        }

        public static void ToRepair(Hero hero)
        {
            if (hero.GetDefensePower() < 50)
            {
                hero.SetDefenePower(hero.GetDefensePower() + 5);
            }
            else
            {
                Console.WriteLine("Доспехи уже отремонтированы.");
            }
        }

        public static void ChooseYourActionInTheTown(Hero hero)
        {   
            if (hero.GetHP() <= 0)
            {
                Ending.Again();
            }
            else
            {
                PrintCreature.CreatureToPrint(hero);
                string Choice = TownDisplay.TownAction();
                switch (Choice)
                {
                    case "1":
                        ToHeal(hero);
                        PrintCreature.CreatureToPrint(hero);
                        ChooseYourActionInTheTown(hero);
                        break;
                    case "2":
                        ToRepair(hero);
                        PrintCreature.CreatureToPrint(hero);
                        ChooseYourActionInTheTown(hero);
                        break;
                    case "3":
                        PrintCreature.CreatureToPrint(hero);
                        GoThroughField.AtackInField(hero);
                        break;
                    case "4":
                        PrintCreature.CreatureToPrint(hero);
                        GoThroughForest.AtackInForest(hero);
                        break;
                    case "5":
                        Console.WriteLine("Жаль, что вы уходите! До новых встреч!");
                        break;
                    default:
                        Console.WriteLine("Не верный выбор. Повторите ввод.");
                        ChooseYourActionInTheTown(hero);
                        break;
                }
            }
        }
    }
}
