using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговое_задание_ООП.Viewer
{
    internal class AdventureDescript
    {
        public static void ForestDesript()
        {
            Console.WriteLine("Вы входите в глухой лес. Повсюду полумрак, сырость и шорохи.");
        }

        public static void FieldDesript()
        {
            Console.WriteLine("Вы идёте через большое поле. Сколько видно глазу, нет ни единой возможности укрыться. К вам быстро приближается облако пыли.");
        }

        public static void WelcomeDesript()
        {
            Console.WriteLine("Добро пожаловать в Средиземье. Вы герой, которому предстоит множество сражений!");
        }
    }
}
