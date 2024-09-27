using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textadventur
{
    internal class information
    {
        string input;
       public static string nickname = "";//maakt een public string met de naam nickname
       public void backstory()
        {
            Console.Clear();//cleared de console
            Console.WriteLine("some backstory to why you are exporing the abandoned viscacha hotel\n");
            Console.WriteLine("you are a historian that likes to explore old buildings for youre research you are tasked to find the secret viscacha");
             Console.WriteLine("in the viscacha hotel\n");
            Console.ReadKey();
            Console.WriteLine("do you want a nickname in the game");
            input = Console.ReadLine();
            if (input == "yes") //kijkt of je yes zegt in input
            { 
                Console.WriteLine("oke what do you want youre name to be");
                nickname =Console.ReadLine();//leest wat je typt en slaat het op in nickname string
                
            }
            else
            {
                Console.WriteLine("well i geuss you are gonna be name less");
                nickname = "nameless";
            }
            Console.WriteLine("press a key to continue");
            Console.ReadKey();
        }
        public void endstory()
        {
            Console.Clear();
            Console.WriteLine("you have found the secret viscacha and you grab it and get out of the building and then suddenly the whole building collapse but you and  youre friends you made along the way are savely outside");
        }
        
    }
}
