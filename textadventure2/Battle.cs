using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using textadventure2;

namespace textadventur
{
    internal class battle
    {
        string input;
        Player Player = new Player();
        enemy enemy = new enemy();
        StoryStarter st = new StoryStarter();
        bool loop = true;
        public int choice;
        int playerdamage = 15;
        int enemydamage = 10;

        public void TooBatlle()
        {
            while (loop)
            {
                Console.WriteLine("player HP " + Player.playerhealth());
                Console.WriteLine("player AttackDamage " + Player.playerAttackdamage());
                Console.WriteLine("enemy HP" + enemy.enemyhealth());
                Console.WriteLine("enemy AttackDamage " + enemy.EnemyAttackDamage());
                Battleoptions();
                if (Player.playerhealth() < 1 || enemy.enemyhealth() < 1)//runt de code in deze if statement als 1 van de waar is
                {
                    if (Player.playerhealth() < 1)//als playerhealth lager is dan 1 is runt deze code
                    {
                        loop = false;//zet bool loop naar false
                        Console.WriteLine("enemy won");
                        Console.WriteLine("youre dead");
                        Console.ReadKey();
                        st.Start();//gaat naar start method in StoryStarter
                    }
                    else if (enemy.enemyhealth() < 1)//als enemyhealth lager dan 1 is runt deze code
                    {
                        Console.WriteLine("you won continue");
                        Console.ReadKey();
                    }

                    loop = false;
                }
            }

        }
        void enemychoice()
        {
            choice = enemy.EnemyChoice();//gaat nnaar enemychoice method in enemy class

        }
        void Battleoptions()
        {
            Console.WriteLine("player choose what to do");
            input = Console.ReadLine();
            Console.WriteLine("enemy choice =");
            enemychoice();
            if (input == "attack" && choice != 2)//als input attack is en choice niet 2 dan doet de player damage aan de enemy
            {
                enemy.takedamage(playerdamage);
            }
            else if (input == "defend")
            {
                enemy.takedamage(0);// zet takedamgae naar 0 zodat hij geen health verliest
            }
            if (choice == 1 && input != "defend")//hier doet de enemy defend
            {
                Console.WriteLine("attack");
                Player.takedamage(enemydamage);
            }
            else if (choice == 2)
            {
                Console.WriteLine("defend");
                Player.takedamage(0);
            }


        }
    }
}
