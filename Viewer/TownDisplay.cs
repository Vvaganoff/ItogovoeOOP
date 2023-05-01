using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговое_задание_ООП.Viewer
{
    internal class TownDisplay
    {
        public static string TownAction() 
        {
            Console.WriteLine("Вы пришли в маленький захолустный городок." + '\n' +
                " Здесь есть травник, чтобы вас полечить и кузнец, чтобы отремонтировать ваши доспехи");
            Console.WriteLine("Какой будет ваш выбор?");
            Console.WriteLine("1 - Лечиться");
            Console.WriteLine("2 - Ремонтировать доспехи");
            Console.WriteLine("3 - Идти дальше через поле");
            Console.WriteLine("4 - Идти даль через лес");
            Console.WriteLine("5 - Выход");
            return Console.ReadLine();
        }
    }
}
