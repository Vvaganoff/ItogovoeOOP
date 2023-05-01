using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговое_задание_ООП.Model
{
    internal class Goblin : Creature
    {
        public Goblin(int health, int atackPower, int defensePower) : base(health, atackPower, defensePower)
        {
        }
        public static Goblin ToCreateGoblin()
        {
            return new Goblin(10, 8, 8);
        }

        public override string GetClasName()
        {
            return "Гоблин";
        }

        public override string? ToString()
        {
            return $"====Гоблин====" + '\n' +
                $"Здоровье: {this._healthPoints}" + '\n' +
                $"Сила удара: {this._atackPower}" + '\n' +
                $"Защита: {this._defensePower}";
        }
    }
}
