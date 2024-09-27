using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textadventur
{
    internal class enemy
    {
        Random rd = new Random();//maakt een nieuwe instance van random
        int enemyHP = 100;//maakt een int met de naam enemyHP en zet een value van 100
        int enemyAttack;//maakt een int aan met de naam enemyAttack
      
        public int EnemyAttackDamage()//method voor de attackdamage
        {
            enemyAttack = 10;//zet enemyAttack naar een value van 10
            return enemyAttack;//returned enemyAttacks
        }
        public int EnemyChoice()//method voor enemychoice
        {
            int choice = rd.Next(1,3);//maakt een nieuwe int aan met de naam choice dat een willekeurig getal kiest tussen de 1 en 3
            switch (choice)//swithc voor in choice
            {
                case 1:
                    Console.WriteLine("attack");
                    break;
                case 2:
                    Console.WriteLine("defend");
                    break;
            }
            return choice;
        }
        public int takedamage(int damage)//method takedamage met parameter damage
        {
            enemyHP -= damage;//haalt damage van enemyHP af
            return enemyHP;//returned enemHP
        }
        public int enemyhealth()//method enemyhelath
        {
            return enemyHP;//returned enemyHP
        }
    }
}
