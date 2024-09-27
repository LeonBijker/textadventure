using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace textadventure2
{
    internal class Games
    {
        int time = 0;//int met de naam time 
        string input;//string met de naam input
        int tile;//int met de naam tile
        StoryStarter st = new StoryStarter();
        public void game1()//method game1 
        {
            Console.WriteLine("so you enter the room and the door closes behind you there is no way back");
            Console.WriteLine("you go forward and you see on a screen welcome to golden bridge");
            Console.WriteLine("to get to the other side and recieve the prize you have to jump on the platforms");
            Console.WriteLine("but be carefull if you jump on a damaged platform you fall and die");
            Console.WriteLine("give a number from 1 thru 3");
            Console.WriteLine("the last twoo are only two options");
            Console.WriteLine("1/5");
            input = Console.ReadLine();
            tile = Convert.ToInt32(input);
            switch (tile)//swith voor tile int
            {
                case 1://case voor het getal
                    Console.WriteLine("save platform");
                    break;
                case 2:
                    Console.WriteLine("not save platform");
                    st.Start();
                    break;
                case 3:
                    Console.WriteLine("save platform");
                    break;
            }
            Console.WriteLine("2/5");
            input = Console.ReadLine();
            tile = Convert.ToInt32(input);
            switch (tile)
            {
                case 1:
                    Console.WriteLine("not save");
                    st.Start();
                    break;
                case 2:
                    Console.WriteLine("save");
                    break;
                case 3:
                    Console.WriteLine("save");
                    break;
            }
            Console.WriteLine("3/5");
            input = Console.ReadLine();
            tile = Convert.ToInt32(input);
            switch (tile)
            {
                case 1:
                    Console.WriteLine("save");
                    break;
                case 2:
                    Console.WriteLine("save");
                    break;
                case 3:
                    Console.WriteLine("not save");
                    st.Start();
                    break;
            }
            Console.WriteLine("4/5");
            input = Console.ReadLine();
            tile = Convert.ToInt32(input);
            switch (tile)
            {
                case 1:
                    Console.WriteLine("save");
                    break;
                case 2:
                    Console.WriteLine("not save");
                    st.Start();
                    break;
            }
            Console.WriteLine("5/5");
            input = Console.ReadLine();
            tile = Convert.ToInt32(input);
            switch (tile)
            {
                case 1:
                    Console.WriteLine("not save");
                    st.Start();
                    break;
                case 2:
                    Console.WriteLine("save");
                    break;
            }
            Console.WriteLine("you have made it take this reward a golden note " +
                "with" +
                "" +
                "visca on it");
        }
        public void game2()//method voor game2
        {
            Console.WriteLine("welcome to the reaction game");
            Console.WriteLine("you have to type the word that is shown before the time runs out");
            Console.WriteLine("you get 5 seconds every time");
            Console.WriteLine("press a key to continue");
            Console.ReadKey();
            Console.WriteLine("youre first word is rock");
            Console.WriteLine("1/6");
            recordTime();//runt de recordtime method
            string input = Console.ReadLine();
            Console.WriteLine($"you took  {time} seconds to start writeting {input}");
            if (time > 5)//als time groter is dan 5 runt deze code
            {
                Console.WriteLine("you got smushed by a boudler cause you took to long");
                st.Start();//gaat na de start method van storystarter
            }
            time = 0;
            Console.WriteLine("word two is bush");
            Console.WriteLine("2/6");
            recordTime();
            input = Console.ReadLine();
            Console.WriteLine($"you took {time} to write {input}");
            if (time > 5)
            {
                Console.WriteLine("you got smushed by a boudler cause you took to long");
                st.Start();
            }
            time = 0;
            Console.WriteLine("word three is trucker");
            Console.WriteLine("3/6");
            recordTime();
            input = Console.ReadLine();
            Console.WriteLine($"you took {time} to write {input}");
            if (time > 5)
            {
                Console.WriteLine("you got smushed by a boudler cause you took to long");
                st.Start();
            }
            Console.WriteLine("your fourth word is truckdriver");
            Console.WriteLine("4/6");
            recordTime();
            input = Console.ReadLine();
            Console.WriteLine($"you took {time} to write {input}");
            if (time > 5)
            {
                Console.WriteLine("you got smushed by a boudler cause you took to long");
                st.Start();
            }
            time = 0;
            Console.WriteLine("your fifth word is Photosynthesis");
            Console.WriteLine("5/6");
            recordTime();
            input = Console.ReadLine();
            Console.WriteLine($"you took {time} to write {input}");
            if (time > 5)
            {
                Console.WriteLine("you got smushed by a boudler cause you took to long");
                st.Start();
            }
            time = 0;
            Console.WriteLine("your sixth word is Antidisestablishmentarianism");
            Console.WriteLine("for this word you get 10 seconds");
            Console.WriteLine("6/6");
            recordTime();
            input = Console.ReadLine();
            Console.WriteLine($"you took {time} to write {input}");
            if (time > 10)
            {
                Console.WriteLine("you got smushed by a boudler cause you took to long");
                st.Start();
            }
            Console.WriteLine("you have completed it have this as a reward");
            Console.WriteLine("a golden not with cha on it");





        }
        void recordTime()
        {
            while (!Console.KeyAvailable)
            {
                Thread.Sleep(1000);
                time++;

            }
        }
    }
}
