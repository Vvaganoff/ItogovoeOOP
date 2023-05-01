using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговое_задание_ООП.Model
{
    internal abstract class Creature : ICreature
    {
        protected int _healthPoints;
        protected int _atackPower;
        protected int _defensePower;
        public int GetHP()
        {
            return this._healthPoints;
        }

        public int GetAtackPower ()
        {
            return this._atackPower;
        }

        public int GetDefensePower()
        {
            return this._defensePower;
        }

        public void SetHP (int HP)
        {
            this._healthPoints = HP;
        }

        public void SetAtackPower (int AP)
        {
            this._atackPower = AP;
        }

        public void SetDefenePower (int DP)
        {
            this._defensePower = DP;
        }

        protected Creature(int health, int atackPower, int defensePower)
        {
            _healthPoints = health;
            _atackPower = atackPower;
            _defensePower = defensePower;
        }

        

        

        public int Atack<T>(T atacker) where T : Creature
        {
            return atacker._atackPower;
        }
        public abstract override string? ToString();
        public string ShowHealth<T>(T creature) where T:Creature
        {
            return creature._healthPoints.ToString();
        }
        public bool IsDead<T>(T creature) where T : Creature
        {
            if (creature._healthPoints <= 0) { return true; }
            return false;
        }
        public abstract string GetClasName();

    }
}
