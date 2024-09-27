using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace textadventur
{
    internal class room
    {
        Random rd = new Random();// een nieuwe instance van Random
        battle toobattle = new battle();// een niewue instance van de battle class
        RoomDesign roomsdesign = new RoomDesign();//een niewe instance van de RoomDesign class
        information information = new information();//een niewe instance van de information class


        string patch = "ascii-art_viscachaV3.txt";// string voor mijn viscacha ascii art

        public int rooms;// public int rooms
        public int deathcount = -1;//public int deathcount
        public string input;//public string input
        public int roomcounter = 1;//public int roomcounter
        bool loop = true;//public bool loop dat op true
        public int Rooms()//Rooms method
        {
            while (loop)//while loop dat door blijft gaan tot loop op false staat
            {


                Console.Clear();//cleared de console

                rooms = rd.Next(1, 13);// kiest een willikeurig
                switch (rooms)//switch statement voor de int rooms
                {
                    case 1://case voor het getal
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        string[] counters = { $"amount of deaths {deathcount}", $"amount of room you have entered {roomcounter}", $"en dit is hoeveel sleutels jij hebt {roomsdesign.key}" };//string array dat de deathcount en roomcounter bevat
                        Console.WriteLine(counters[0]);//schrijf het eerste gedeelte van de counter array
                        Console.WriteLine(counters[1]);//schrijf het tweede gedeelte van de counter array
                        Console.WriteLine(counters[2]);// schrijf het derde gedeelte van de counter array
                        roomsdesign.design();//runt de design method in de roomdesign class
                        roomcounter++;//verhooght roomcounter met 1
                        break;
                    case 11:
                        if (roomcounter >= 5)// if statement voor als roomcounter gelijk of hoger dan 5 is
                        {

                            Console.WriteLine("Wow, you have found a secret room!");
                            Console.WriteLine("but do you have a key");
                            switch (roomsdesign.key)//switch statement dat kijk naar de int key in roomdesign
                            {
                                case 0://dit wordt gerunt als je nog geen sleutel heb
                                    Console.WriteLine("you dont have a key continue to search to find a key");
                                    break;
                                case 1://dit gebeurt er als je al wel hebt
                                    extrainfo();
                                    Console.WriteLine("you have found the secret viscacha and left the building");
                                    information.endstory();//runt de code in endstory van information class
                                    Console.WriteLine("press a key to end the adventure");
                                    Console.WriteLine("cause you have finished the adventure");
                                    Console.ReadKey();
                                    loop = false;
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("you are in room " + roomcounter);
                            roomcounter++;
                            break;
                        }
                        break;

                    case 12:
                        if (roomcounter >= 10)//if statement als roomcounter gelijk of hoger dan 10 is
                        {
                            Console.WriteLine("you have found a secret room but");
                            toobattle.TooBatlle();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("you are in room " + roomcounter);
                            break;
                        }


                    default:
                        Console.WriteLine("How did you get here?");
                        break;

                }
            }
            return rooms;


        }
        public string extrainfo()
        {
            string[] lines = File.ReadAllLines(patch);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
            return "Viscacha";

        }

    }
}
