using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textadventur
{
    internal class Player
    {
       int playerHp;//int playerHP
        int playerAttack;//int playerattack
        
    
        public int playerAttackdamage()//method playerattackdamage start
        {
            playerAttack = 15;//zet playerattack naar 15

            return playerAttack;//returned playerattack
        }
        public int takedamage(int damage)//takedamage met een parameter damage
        {
            playerHp = 30;//zet playerhp naar 30
            playerHp  -= damage;//haalt de damage van de playerhp af
            return playerHp;//returned playerhp
        }
        public int playerhealth()//method playerhealth
        {
            return playerHp;//returned playerhp
        }

    }
}
