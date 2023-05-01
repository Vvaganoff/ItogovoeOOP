using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговое_задание_ООП.Model
{
    internal class Ork : Creature
    {
        protected string _className = "Орк";

        
        public Ork(int health, int atackPower, int defensePower) : base(health, atackPower, defensePower)
        {
        }

        public static Ork ToCreateOrk() 
        {
            return new Ork(10, 8, 8);
        }

        public override string? ToString()
        {
            return $"====Орк====" + '\n' +
                $"Здоровье: {this._healthPoints}" + '\n' +
                $"Сила удара: {this._atackPower}" + '\n' +
                $"Защита: {this._defensePower}";
        }

        public override string GetClasName()
        {
            return this._className;
        }
    }
}
