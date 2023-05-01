using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговое_задание_ООП.Model
{
    
    internal class Hero : Creature
    {
        protected string _className = "Ваш герой";

        
        public Hero(int health, int atackPower, int defensePower) : base(health, atackPower, defensePower)
        {
            
        }

        public override string? ToString()
        {
            return "====Ваш герой====" + '\n' + "Здоровье: " + this._healthPoints + '\n' + "Сила удара: " + this._atackPower + '\n' + "Защита: " + this._defensePower + '\n' + "";
        }

        public override string GetClasName()
        {
            return this._className; 
        }
    }
}
