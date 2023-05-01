using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Итоговое_задание_ООП.Presenter;

namespace Итоговое_задание_ООП.Model
{
    internal class Fight
    {
        public static void FightRound <AT,DT> (string action, AT atacker, DT defender) where AT : Creature where DT:Creature
        {
               
                    if (atacker.IsDead(atacker))
                    {
                      Console.WriteLine($"{atacker.GetClasName()} мёртв");
                      
                    } 
                    else 
                     {
                         Console.WriteLine($"{atacker.GetClasName()} нападает на {defender.GetClasName()}");
                         WasAtacked (defender, atacker.GetAtackPower(), action);
                     }
        
        }

        public static void WasAtacked<DT>(DT defender, int atackPower = 0, String defenderAction = "") where DT : Creature
        {
            int isAtack = 0;
            int isDefense = 0;
            if (defenderAction.Equals("atack")) { isAtack = 3; } else if (defenderAction.Equals("defense")) { isDefense = 5; }
            int damage = Defense(atackPower + isAtack, defender.GetDefensePower() + isDefense);
            Console.WriteLine($"Урон: {damage}");
            defender.SetHP(defender.GetHP() - damage);
            if (defender.GetDefensePower() > 0)
            {
                defender.SetDefenePower(defender.GetDefensePower() - 5);
            }
            
        }

        public static int Defense(int atackPower = 0, int defensePower = 1)
        {
            return (int)Math.Round(atackPower / (defensePower>0 ? defensePower : 1) * 1.9);
        }

        public static void Battle <AT>(List<AT> creatureList, Hero hero) where AT : Creature
        {
            while (creatureList.Count > 0)
            {
                if (hero.GetHP() <= 0)
                {
                    break;
                }
                string heroAction = HeroAction.ChooseYourAction();
                if (heroAction.Equals("atack"))
                {
                    foreach (AT creature in creatureList)
                    {


                        if (hero.GetHP() <= 0)
                        {
                            break;
                        }
                        if (creature.GetHP() <= 0)
                        {

                        }
                        else
                        {
                            Fight.FightRound<Hero, AT>(heroAction, hero, creature);
                            foreach (AT creature1 in creatureList)
                            {
                                if (hero.GetHP() <= 0)
                                {
                                    break;
                                }
                                if (creature1.GetHP() <= 0)
                                {

                                }
                                else { Fight.FightRound<AT, Hero>(heroAction, creature1, hero); }

                            }
                        }

                    }
                }
                else if (heroAction.Equals("defense"))
                {
                    foreach (AT creature2 in creatureList)
                    {
                        Fight.FightRound<AT, Hero>(heroAction, creature2, hero);
                        if (hero.GetHP() <= 0)
                        {
                            break;
                        }

                    }
                    Fight.FightRound<Hero, AT>(heroAction, hero, (AT)creatureList[creatureList.Count - 1]);
                }
                List<AT> liveCreatureList = new List<AT>();
               
                foreach (AT item in creatureList)
                {
                    if (item.GetHP() > 0)
                    {
                        liveCreatureList.Add(item);
                        Console.WriteLine($"В живых остался орк со здоровьем: {item.GetHP()}");
                    }
                }
                Console.WriteLine($"Ваше здоровье: {hero.GetHP()}, ваша броня: {hero.GetDefensePower()}");
                creatureList = liveCreatureList;
                if (hero.GetHP() <= 0)
                {
                    Console.WriteLine("Ваш герой мертв!");
                    break;
                }
            }
        }
    }
}
