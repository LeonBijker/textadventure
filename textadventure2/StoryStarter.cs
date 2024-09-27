using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using textadventur;

namespace textadventure2
{
    internal class StoryStarter
    {
        public void Start()
        {
            room rooms = new room();//maakt een niewe instance van room class
            RoomDesign roomdesign = new RoomDesign();//maakt een nieuwe instance van RoomDesign class
            information information = new information();//maakt een nieuwe instance van information class
            rooms.deathcount++;//verhoogt deathcount met 1 van room class
            Console.WriteLine("please only use english in this adventure");
            Console.WriteLine("press any key to start");
            Console.ReadKey();
            information.backstory();//runt de code in de backstory method van information class
            rooms.Rooms();//run de code van de rooms method in room class

        }
    }
}
