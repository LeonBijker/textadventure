using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using textadventure2;

namespace textadventur
{
    internal class RoomDesign
    {
        StoryStarter st = new StoryStarter();
        Random rd = new Random();//maakt een nieuwe instance van random
        List<string> items = new List<string>();//maakt een nieuwe list aan met de naam items
        List<string> contacts = new List<string>();//maakt een nieuwe list aan met de naam contacts
        List<string> names = new List<string>();//maakt een nieuwe list aan met de naam names
        Games games = new Games();//maakt een nieuwe instance aan van de games class
        int RoomId = 0;//maakt een niewe int aan met de naam room_id
        string input;//maakt een niewe string aan met de naam input
        public int key = 0;//maakt een nieuwe int aan met de naam key
        bool inputloop = true;// maakt een nieuwe bool aan met de naam inputloop
        bool inputloop2 = true;//maakt een nieuwe bool aan met de naam inputloop2
        bool inputloop3 = true;//maakt een nieuwe bool aan met de naam inputloop3
        battle Battle = new battle();//maakt een nieuwe instance aan van de battle class
        string patch1 = "toothless.asciiv4.txt";//maakt een nieuwe string aan met de naam patch1
        string patch2 = "stormfly.asciiv2.txt";//maakt een nieuwe string aan met de naam patch2
        string patch3 = "skullcrusher.asciiv1.txt";//maakt een nieuwe string aan met de naam patch3
       // room Room = new room();

        public void design()
        {
            names.Add("leon");//voegt de naam toe aan de names list
            names.Add("daniël");
            names.Add("hiccup");
            names.Add("astrid");
            names.Add("tom");
            names.Add("june");
            names.Add("eugene");
            names.Add("stoick");
            names.Add("john");
            names.Add("stewy");
            int person = rd.Next(names.Count);// kiest een willekeurig uit de names list
            int person2 = rd.Next(names.Count) ;// kiest een willekeurig uit de names list
            if (person == person2)//kijkt of het niet de zelfde naam is
            {
                person2++;// verhoogt de person2 int met 1
            }
            RoomId = /*rd.Next(1, 6)*/4;//kiest een getal tussen de 1 en 6
            Console.WriteLine();
            Console.WriteLine("you can always ones you have some contacts/friends");//stuurt de text naar de console
            Console.WriteLine("you can view them with 'view contacts");
            Console.WriteLine("and when you collect items you can view them with 'view items'");
            Console.WriteLine("you can always type 'help' for help in the options you have");
            Console.WriteLine("you enter the room");
            Console.WriteLine();
            if (items.Contains("a golden note with visca on it") && (items.Contains("a golden note with acha on it")))// if statement voor als in de items list een item met de naam a golden note with visca ont it en een item met the naam a golden note with acha on it
            {
                Console.WriteLine("you have found the two golden notes and lay them next to eachtoghter and they suddenly fuse togheter into 1 note");
                items.Remove("a golden note with visca on it");
                items.Remove("a golden note with acha on it");
                items.Add("a golden note with viscacha on it");
                Console.WriteLine($"then suddenly {(names[person])} comes and he sees that you have the golden note and he says i will give you this key for that golden note");// stuurt text en 1 naam van de names list naar de console
                Console.WriteLine("so are you gonna give the note or keep the note");
                Console.WriteLine("what are you gonna do");
                input = Console.ReadLine();// zet de input in de string met de naam input
                if (input.Contains("help"))// als input help is
                {

                    Console.Write("options: \n give the note \n keep the note");
                }
                switch (input.ToLower())//een switch statement met een input
                {
                    case "give the note"://case voor give the note
                        Console.WriteLine("you give the note and he gives you the key");
                        IncreaseKeyCount();//runt IncreaseKeyCount method
                        break;
                    case "keep the note"://case voor keep the note
                        Console.WriteLine("you keep the note and it turns to a normal note and its useless to you and you throw it away");
                        items.Remove("a golden note with viscacha on it");// haalt de item uit de list
                        break;
                }
            }

            switch (RoomId)//swith voor int roomID
            {
                case 1:
                    
                    Console.WriteLine("and you see a bed,closet and table");
                    Console.WriteLine("what are you gonna do");
                    while (inputloop)//while loop voor bool inputloop
                    {
                        input = Console.ReadLine();
                        if (input == "view contacts")

                        {
                            DisplaycontactsList();//runt de DisplaycontactsList
                            Console.ReadKey();
                        }
                        if (input.Contains("view items"))
                        {
                            displayitemsList();//runt de displayitemsList
                            Console.ReadKey();
                        }
                        else if (input.Contains("quit"))
                        {
                            Environment.Exit(0);// sluit het programma af
                        }
                        if (input.Contains("help"))
                        {

                            Console.Write("options: \n go to the closet\n go to the bed\n go to the table\n");
                        }


                        switch (input)//switch voor input
                        {

                            case "go to the closet"://case voot go to the closet
                                inputloop = false;//zet de inputloop naar false
                                Console.WriteLine("you go to the closet and open it and see some old clothes you take them with you");
                                Console.ReadKey();
                                items.Add("clothes");//voegt item toe aan de items list
                                break;
                            case "go to the bed":
                                inputloop = false;
                                Console.WriteLine("you go to the bed and grab de blanket and pull it of the bed and see a dead body and get scared what are you gonna do now");
                                while (inputloop2)//while loop voor inputloop2
                                {

                                    input = Console.ReadLine();
                                    if (input.Contains("help"))
                                    {
                                        Console.Write("options are \n stay\n run\n");

                                    }

                                    switch (input)
                                    {
                                        case "run":
                                            inputloop2 = false;//zet inputloop2 naar false
                                            Console.WriteLine("you ran out of the room");
                                            break;
                                        case "stay":
                                            inputloop2 = false;
                                            Console.WriteLine("you stayed and investigate the body and found a note with the text 8329 on it and take it with you");
                                            Console.ReadKey();
                                            items.Add("note with 8329 on it");
                                            break;
                                    }
                                }
                                break;
                            case "go to the table":
                                inputloop = false;
                                Console.WriteLine("you go to the table and see something carved in the table what are you gonna do");
                                while (inputloop2)
                                {
                                    input = Console.ReadLine();
                                    if (input.Contains("help"))
                                    {
                                        Console.Write("options: \n going in for a closer look \n dont think anything of it\n");

                                    }


                                    switch (input)
                                    {
                                        case "going in for a closer look":
                                            inputloop2 = false;
                                            Console.WriteLine("you go in for a closer look and can see a bit of what there has been carved in and see the number 2 and 5");
                                            Console.WriteLine("you also see on the ground a blank paper with a pen you grab that and write the number down");
                                            Console.ReadKey();
                                            items.Add("a note with the number 2 and 5 on it");
                                            break;
                                        case "dont think anything of it ":
                                            inputloop2 = false;
                                            Console.WriteLine("you dont think much of it and go and leave the room");
                                            Console.ReadKey();
                                            break;
                                    }

                                }
                                break;
                        }
                    }
                    break;
                case 2:
                    inputloop = true;//zet inputloop naar true
                    inputloop2 = true;//zet inputloop naar true

                    Console.WriteLine("and see a kingsize bed, a rotten closet and another door which you suspect to be the door to the bathroom");
                    Console.WriteLine("what are you gonna do");
                    while (inputloop)
                    {
                        input = Console.ReadLine();
                        if (input == "view contacts")

                        {
                            DisplaycontactsList();
                            Console.ReadKey();
                        }
                        if (input.Contains("view items"))
                        {
                            displayitemsList();
                            Console.ReadKey();
                        }
                        else if (input.Contains("quit"))
                        {
                            Environment.Exit(0);
                        }
                        if (input.Contains("help"))
                        {
                            Console.Write("options:\n go to the kingsize bed\ngo to the rotten closet\n go to the door\n");
                        }
                        switch (input)
                        {
                            case "go to the kingsize bed":
                                inputloop = false;
                                Console.WriteLine("you go to the bed and see absolutely nothing");
                                Console.WriteLine("so you decide to leave the room");
                                Console.ReadKey();
                                break;
                            case "go to the rotten closet":
                                inputloop = false;
                                Console.WriteLine("you go to the closet and you can see it is not in a good state but still go and look inside of it");
                                Console.WriteLine("you open the door and it falls off and you put it on the ground and look inside");
                                Console.WriteLine("you see a ");
                                Thread.Sleep(1000);//wacht 1 seconde voor dat het naar de volgende regel van code runt
                                Console.WriteLine("Hole");
                                Console.WriteLine("what are you gonna do");
                                do//do gedeelte van een do while loop
                                {
                                    input = Console.ReadLine();
                                    if (input.Contains("help"))
                                    {
                                        Console.Write("options:\n go into the hole \ndont go in to the hole\n");
                                        Console.ReadKey();

                                    }
                                    switch (input)
                                    {
                                        case "go into the hole":
                                            inputloop2 = false;
                                            Console.WriteLine("you go and go into the hole");
                                            Console.WriteLine("and when you are at the bottom of the hole you suddenly see a");
                                            Console.WriteLine("Troll");
                                            Battle.TooBatlle();
                                            break;
                                        case "dont go in to the hole":
                                            inputloop2 = false;
                                            Console.WriteLine("you stayed out the hole and you go and leave the room");
                                            Console.ReadKey();
                                            break;
                                    }

                                }
                                while (inputloop2);//het while gedeelt van de do while loop dat er voor zorgt dat dat in de do gedeelt blijft runnen todat inputloop2 naar false wordt gezet
                                break;
                            case "go to the door":
                                inputloop = false;
                                Console.WriteLine("you go to the door and you open it and you expect that you are going to the bathroom");
                                Console.WriteLine("but when you open the door you see a staircase and you go down the stairs");
                                Console.WriteLine("you are downstairs and see three difrent rooms");
                                Console.WriteLine("choose between the three rooms");
                                Console.WriteLine("please put only the number in");
                                while (inputloop2)
                                {
                                    input = Console.ReadLine();
                                    if (input.Contains("help"))
                                    {
                                        Console.Write("your options are \n1 \n 2 \n 3");
                                    }
                                    int IntInput = 0;
                                    int.TryParse(input, out IntInput);//kijkt of de input naar cijfer omgezet kan worden
                                    switch (IntInput)
                                    {
                                        case 1:
                                            inputloop2 = false;
                                            Console.WriteLine("in this room you see gold at the end of the room and you see a lot of glass platforms to get to there");
                                            Console.WriteLine("but if you fall you die");
                                            games.game1();
                                            items.Add("a golden note with visca on it");
                                            Console.ReadKey();
                                            break;
                                        case 2:
                                            inputloop2 = false;
                                            Console.WriteLine("in this room you see a giant boulder and you stepped into the room and the door closes and you see the boulder coming towards you ");
                                            Console.WriteLine("and you start running if you dont make it you die");
                                            games.game2();
                                            items.Add("a golden note with acha on it");
                                            Console.ReadKey();
                                            break;
                                        case 3:
                                            inputloop2 = false;
                                            Console.WriteLine("in this room you see a hole that is like 6 feet deep and its start to fill with coins");
                                            Console.WriteLine("you go into the room the door closes and you see on a screen that says try to escape");
                                            Console.WriteLine("you try to escape but you cant and die from the weight of the coins cause they keep filling and you just gave up");
                                            Console.ReadKey();
                                           
                                            st.Start();//gaat naar de start method in StoryStarter
                                            break;
                                    }
                                    break;
                                }
                                break;
                        }
                    }
                    break;

                case 3:
                    inputloop = true;
                    inputloop2 = true;

                    Console.WriteLine("you take a look inside and see matress on the ground with some perfect new closet and table which confuses you");
                    Console.WriteLine("you ask your self am i the first person to search for the secret viscacha or not");
                    Console.WriteLine("and then you see behind the door another door were you take a look in and see dead bodys some fresh some ");
                    Console.WriteLine("some have lied there for probaly some decades");
                    Console.WriteLine("so what are you gonna do ");
                    Console.WriteLine("your first gonna choose what room after that the rest");
                    while (inputloop)
                    {
                        input = Console.ReadLine();
                        if (input == "view contacts")

                        {
                            DisplaycontactsList();
                            Console.ReadKey();
                        }
                        if (input.Contains("view items"))
                        {
                            displayitemsList();
                            Console.ReadKey();
                        }
                        else if (input.Contains("quit"))
                        {
                            Environment.Exit(0);
                        }
                        if (input.Contains("help"))
                        {
                            Console.Write("your options are \n room 1 \n room 2 \n");
                        }


                        switch (input)
                        {
                            case "room 1":
                                inputloop = false;
                                Console.Clear();
                                Console.WriteLine("now you choose what to do ");
                                Console.WriteLine("just as a reminder of what there is in this room");
                                Console.WriteLine("a matress on the ground a closet and a table");
                                while (inputloop2)
                                {
                                    input = Console.ReadLine();
                                    if (input.Contains("help"))
                                    {
                                        Console.Write("your options are\n go to the matress on the ground\n go to the closet \n go to the table\n");
                                    }

                                    switch (input)
                                    {
                                        case "go to the matress on the ground":
                                            inputloop2 = false;
                                            Console.WriteLine("you go to the matress and see that it wasn't empty at all that someone has slept in there and proably left like a couple hours ago");
                                            Console.WriteLine("so you wait a couply hours and someone comes in the room and you talk to him and go and contiue the trip togheter");
                                            Console.WriteLine($"and you find out that his/her name is {(names[person])} and they come with you on your adventure ");
                                            contacts.Add((names[person]));//voegt naam toe aan de contacts list
                                            Console.ReadKey();
                                            break;
                                        case "go to the closet":
                                            inputloop2 = false;
                                            Console.WriteLine("you open the closet and see clothes hanging and the look new so you think should i wait or not");
                                            while (inputloop3)//blijft loopen todat inputloop3 naar false wordt gezet
                                            {
                                                input = Console.ReadLine();
                                                if (input.Contains("help"))
                                                {
                                                    Console.Write("your options are: to wait or\n leave\n");
                                                }
                                                switch (input)
                                                {
                                                    case "wait":
                                                        inputloop3 = false;//zet inputloop3 naar false
                                                        Console.WriteLine("you wait and after a couple of hours you see someone coming and you and him go and talk");
                                                        Console.WriteLine("and you find out that he is also looking for the secret viscacha");
                                                        Console.WriteLine("you travel further toghter and his name is " + (names[person]));
                                                        Console.ReadKey();
                                                        contacts.Add(names[person]);
                                                        break;
                                                    case "leave":
                                                        inputloop3 = false;
                                                        Console.WriteLine("you left the room");
                                                        Console.ReadKey();
                                                        break;
                                                }
                                            }
                                            break;

                                        case "go to the table":
                                            inputloop2 = false;
                                            Console.WriteLine("you go to the table and see food on it and grab it");
                                            Console.WriteLine($"but then {(names[person])} apears ");
                                            Console.WriteLine("and he yells WHAT ARE YOU DOING WITH MY FOOD");
                                            Console.WriteLine("and kills you with his weapon");
                                            st.Start();
                                            break;
                                    }
                                }
                                break;
                            case "room 2":
                                inputloop = false;
                                Console.WriteLine("just as a reminder you are in a room with dead body's");
                                Console.WriteLine("you can either inspect them or run");
                                while (inputloop2)
                                {

                                    input = Console.ReadLine();
                                    if (input.Contains("help"))
                                    {
                                        Console.Write("options are \ninspect the body's\n run\n");
                                    }
                                    switch (input)
                                    {
                                        case "inspect the body's":
                                            inputloop2 = false;
                                            Console.WriteLine("you go and see the body's");
                                            for (int i = 0; i < 10; i++)//een for loop dat tot 10 gaat
                                            {
                                                Console.WriteLine($"you see {i} body's");// en deze code wordt gerunt todat het 10 keer heeft gerunt
                                            }
                                            Console.WriteLine("but suddenly the door closes and you evenualy die of hunger");
                                            Console.ReadKey();
                                            
                                            st.Start();
                                            break;
                                        case "run":
                                            inputloop2 = false;
                                            Console.WriteLine("you run out of the room and go back to the hallway");
                                            Console.WriteLine("and you find ad the door of the room a key and you take it with you");
                                            items.Add("key");
                                            if (items.Contains("key"))
                                            {
                                                IncreaseKeyCount();//runt de IncreaseKeyCount method
                                            }
                                            Console.ReadKey();
                                            break;


                                    }
                                    break;
                                }
                                break;
                        }

                    }
                    break;



                case 4:
                    inputloop = true;
                    inputloop2 = true;
                    inputloop3 = true;

                    Console.WriteLine("you see a fully empty room and dont know what to do here");
                    Console.WriteLine("so you decide to explore the room");
                    Console.WriteLine("but then you suddenly see in the corner of the room a chair");
                    Console.WriteLine("and you go and sit on the chair but suddenly a sleeping gas gets released in the room");
                    Console.WriteLine("you get knocked out when you wake up and find out you are tied up");
                    Console.WriteLine("you also cant talk cause they have put tape around your mouth");
                    Console.WriteLine("and then you suddenly see " + (names[person]) + " and " + (names[person2]));
                    Console.WriteLine("and you are really scared");
                    Console.WriteLine("they ask you why are you here and say we found your id card");
                    Console.WriteLine("they remove the tape that is covering your mouth");
                    Console.WriteLine($"so say up why are you here {information.nickname}");//haalt je nickname op dat jij hebt gegeven en als je dat niet wordt dan is het nameless
                    if (information.nickname == "toothless" && (names[person] == "hiccup" || names[person2] == "hiccup"))//kijkt of 2 van deze statement of 2 van deze 2 true zijn
                    {
                        string[] lines1 = File.ReadAllLines(patch1);//string array dat mijn ascii art laat zient
                        foreach (string line in lines1)//leest elkse lijn van mijn ascii art
                        {
                            Console.WriteLine(line);//displayed die lijn
                        }
                        Console.WriteLine("wait why is your name toothless?");
                        Console.WriteLine("you say that that is your worker card and that they gave you it cause your boss likes httyd(how to train your dragon) and names personel after characters and you got that name");
                        Console.ReadKey();
                    }
                    else if (information.nickname == "stormfly" && (names[person] == "astrid" || names[person2] == "astrid"))
                    {
                        string[] lines1 = File.ReadAllLines(patch2);
                        foreach (string line in lines1)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("wait why is your name stormfly");
                        Console.WriteLine("you say that that is your worker card and that they gave you it cause your boss likes httyd(how to train your dragon) and names personel after characters and you got that name");
                        Console.ReadKey();
                    }
                    else if (information.nickname == "skullcrusher" && (names[person] == "stoick" || names[person2] == "stoick"))
                    {
                        string[] lines2 = File.ReadAllLines(patch3);
                        foreach (string line in lines2)
                        {
                            Console.Write(line);
                        }
                        Console.WriteLine("wait why is your name skullcrusher");
                        Console.WriteLine("you say that that is your worker card and that they gave you it cause your boss likes httyd(how to train your dragon) and names personel after characters and you got that name");
                        Console.ReadKey();
                    }


                    Console.WriteLine("you explain why you are here and that you are searching for the secret viscacha");
                    Console.WriteLine("there is no secret viscacha in here you are wasting your time they say");
                    Console.WriteLine("so what are you going to do");
                    Console.Write("are you going to believe them and leave or continue to search");

                    while (inputloop)
                    {


                        input = Console.ReadLine();
                        if (input.Contains("help"))
                        {
                            Console.Write("options: \n believe and leave. or \n continue to search\n");
                        }
                        if (input == "view contacts")

                        {

                            DisplaycontactsList();
                            Console.ReadKey();
                        }
                        if (input.Contains("view items"))
                        {
                            displayitemsList();
                            Console.ReadKey();
                        }
                        else if (input.Contains("quit"))
                        {
                            Environment.Exit(0);
                        }
                        switch (input)

                        {
                            case "believe and leave":
                                inputloop = false;
                                Console.WriteLine("you leave the hotel and tell your boss that there is no viscacha");
                                Console.WriteLine("your boss says well then your fired");
                                st.Start();
                                Console.ReadKey();
                                break;
                            case "continue to search":
                                inputloop = false;
                                Console.WriteLine("you continue to search and leave the room");
                                Console.WriteLine("you tell them that you are gonna continue to search");
                                Console.WriteLine("and they say well i geuss we could try and help you");
                                Console.WriteLine("and they come with you on the journey");
                                Console.ReadKey();
                                contacts.Add((names[person]));
                                contacts.Add((names[person2]));
                                break;
                        }
                    }
                    break;
                case 5:
                    inputloop = true;
                    Console.WriteLine("and you see hangmat that hangs off two long treetrunks and see a treetrunk that is put right side to be used as a table and other tree trunk that has been cut into a chair and you see a closet made out off branches");
                    Console.WriteLine("and the room has all in the room a lot off leaves coming from the ceiling");
                    Console.WriteLine("you enter the room and suddenly the door closes on you and it disapears");
                    Console.WriteLine("so what are you gonna do");
                    Console.WriteLine("explore or wait around");
                    while (inputloop)
                    {
                        input = Console.ReadLine();
                        if (input == "view contacts")

                        {
                            DisplaycontactsList();
                            Console.ReadKey();
                        }
                        if (input.Contains("view items"))
                        {
                            displayitemsList();
                            Console.ReadKey();
                        }
                        else if (input.Contains("quit"))
                        {
                            Environment.Exit(0);
                        }
                        if (input.Contains("help"))
                        {
                            Console.Write("your options are\n wait \n explore\n");
                        }
                        switch (input)
                        {
                            case "explore":
                                inputloop = false;
                                Console.WriteLine("you go explore the 'room'");
                                Console.WriteLine("and you find out that you are no longer in a room cause you are in a jungle");
                                Console.WriteLine("you try to get out off the jungle but its seems to be endless and you keep going");
                                Console.WriteLine("but you eventaully die of thirst and hunger cause you didn't care about that cause you wanted to get out off there");
                                st.Start();

                                break;
                            case "wait":
                                inputloop = false;
                                Console.WriteLine("you wait and eventually");
                                Console.WriteLine(names[person], "appears");
                                Console.WriteLine("and he says how did you get here");
                                Console.WriteLine("you explain that you came thru a door and that it disappeared");
                                Console.WriteLine("and then he explains the exact same thing to you and that he has been trapped here for 20 years and that there is no way out");
                                Console.WriteLine("so what are you gonna do trust him/her and live your life here or search for a way out");
                                while (inputloop2)
                                {


                                    input = Console.ReadLine();
                                    if (input.Contains("help"))
                                    {
                                        Console.Write("your options are\n trust and live your life out\nsearch for a way out\n");
                                        continue;
                                    }
                                    switch (input)
                                    {
                                        case "trust and live your life out":
                                            inputloop2 = false;
                                            Console.WriteLine($"you trust{names[person]} and live youre life there and eventually you die cause off old age ");
                                            st.Start();
                                            break;
                                        case "search for a way out":
                                            inputloop2 = false;
                                            Console.WriteLine($"you say that you search for a way out but {names[person]} says there is no way and say he will accompany you");
                                            contacts.Add(names[person]);
                                            Console.WriteLine($"you search for a way out and suddenly find {names[person2]} he says why are you here and you explain that you are searching for a way out off here");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("he says well there is a way out off here but its very difficult and you can die");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("you well i am going to go for that cause i want to get out off here");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("and he say well then come and follow me");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("many hours later");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("he says here is the start off the obstacle");
                                            Console.WriteLine("but you see nothing but jungle and suddenly native people come out off the bushes");
                                            Console.WriteLine("and you and youre friend/friends gets captured");
                                            Console.WriteLine($"why are you all here{information.nickname}");
                                            foreach (var contact in contacts)
                                            {
                                                Console.WriteLine("and" + contact);

                                            }
                                            Console.WriteLine("you say that you got here thru a door and that you are trying to find a way out off here");
                                            Console.WriteLine("and they say get out off here that is impossible");
                                            Console.WriteLine("you quickly said sorry and said we will leave");
                                            Console.WriteLine("they untied them and they said NOW LEAVE AND NEVER COMEBACK HERE");
                                            Console.WriteLine("they left and now they were scared off the native people cause they can comeback and kill you");
                                            Console.WriteLine("so they decide too get the going and find a diffrent way to get back");
                                            Console.WriteLine($"then they suddenly see Robert and he says want to get out off here");
                                            Console.WriteLine("they all say yes ofcourse cause they indeed want to get out off here");
                                            Console.WriteLine("well robert says come and follow me");
                                            Console.WriteLine("you all follow him and he leads you to a portal");
                                            Console.WriteLine("and he says go thru this portal to go back to the place were you first came to here");
                                            Console.WriteLine("you all go thru the portal and end up back in the room and immediately leave the room");
                                            break;

                                    }


                                }
                                break;
                        }
                        Console.ReadKey();
                    }
                    break;
            }
            void DisplaycontactsList()
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact);
                }
            }
            void displayitemsList()
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void IncreaseKeyCount()
        {
            key++;
        }
    }
}

