using System;
using System.Collections.Generic;
using System.Linq;

namespace nocum
{
    class Program
    {

        static void Main(string[] npcSex)
        {
            double v=1.00, u=0.01;
            npcSex = new string[2];
            npcSex[0] = "F";
            npcSex[1] = "M";
            List<string> npcs = new List<string> { "Mom","Dad","Dogs","Cats","Birds","Reptiles","Fishes","Humanoids","Spiders","Insects","BroSis","Horses" };
            Random r = new Random();
            int done = -1, ioc, i,j,rum=r.Next(npcSex.Length),endnum=0,max=10,fert=0,rer=0;
            string sex, fob, hi;
            bool btf,ene,itp,Ps,ch;
            while (done == -1)
            {
                Console.WriteLine("WEL CUM to Choices and have you played befor y/n?");
                hi = Console.ReadLine();
                if (hi == "y")
                {
                    Console.WriteLine("Did you get to an ending y/n?");
                    hi = Console.ReadLine();
                    if (hi == "y")
                    {
                        Console.WriteLine("there was a number on the screen do you remeber it y/n?");
                        hi = Console.ReadLine();
                        if (hi == "y")
                        {
                            Console.WriteLine("Please enter it");
                            hi = Console.ReadLine().Trim();
                            itp = int.TryParse(hi, out endnum);
                            if (itp == true)
                            {
                                ene = endnum == 10;
                                if (ene == true)
                                {
                                    max = int.MaxValue;
                                }
                                else if (endnum == 5)
                                    fert = 1;
                                else
                                    Console.WriteLine("not one");
                                done++;
                            }
                            else
                                Console.WriteLine("I said number");
                            done++;
                        }
                        else if (hi != "n")
                        {
                            Console.WriteLine("Y OR N");
                        }
                        else done++;
                    }
                    else if (hi != "n")
                        Console.WriteLine("Y OR N");
                    else done++;
                }
                else if (hi != "n")
                    Console.WriteLine("Y OR N");
                else done++;
            }
            Console.WriteLine("Choose 1 of these choices");
            while (done == 0)
            {
                Console.WriteLine("beast y/n, boy/girl/other");
                fob = Console.ReadLine().ToLower().Trim();
                btf = fob == "y";
                if (fob.Contains(","))
                {
                    ioc = fob.IndexOf(",");
                    sex = fob.Substring(ioc + 1);
                    if(sex.StartsWith("b"))
                    {
                        for(i=0;i<npcs.Count;i++)
                        {
                            if (i == 0 | i > 1)
                            {
                                j = 0;
                                npcs[i] = npcSex[j] + npcs[i];
                            }
                            else
                            {
                                j = 1;
                                npcs[i] = npcSex[j] + npcs[i];
                            }
                        }
                    }
                    else if(sex.StartsWith("o"))
                    {
                        for (i = 0; i < npcs.Count; i++)
                        {
                            npcs[i] = npcSex[rum] + npcs[i];
                            rum = r.Next(npcSex.Length);
                        }
                    }
                    else
                        for (i = 0; i < npcs.Count; i++)
                        {
                            if (i !=0)
                            {
                                j = 1;
                                npcs[i] = npcSex[j] + npcs[i];
                            }
                            else
                            {
                                j = 0;
                                npcs[i] = npcSex[j] + npcs[i];
                            }
                        }
                }
                else
                    Console.WriteLine("You need a ,");
                Console.WriteLine();
                if (max == int.MaxValue && fert == 1)
                {
                    Ps = Stroub.Ender(rer, max);
                    ch = Stroub.Preg(v, u, fert == 1);
                }
                else
                { 
                    Ps = Stroub.Ender(rer, max);
                    ch = Stroub.Preg(v, u,false);
                }
                Thegame.Game(Ps, ch, npcs);
                done = 1;
            }
        }
    }
    class Stroub
    {
        public static bool Ender(int saw,int max)
        {
            bool PS = saw < max;
            return PS;
        }
        public static bool Preg(double fert,double chance,bool yn)
        {
            bool check=yn==true | fert == 1.00 && chance == 1.00;
            return check;
        }
        
    }
    class Thegame
    {
        public static void Game(bool g, bool a, List<string> me)
        {


       
            List<string> prefrences=new List<string>{"family","step_family","pregnace","boy","girl","ages_to_","energy","beast","customisation" };
            List<int> to100 = new List<int>();
            Console.WriteLine("Do you want to play choises?");
            string holo="",see1="",see2="",see3="",see4="";
            bool truse,didcus=false;
            Random rand = new Random();
            Checker lob = new Checker();
            lob.text = Console.ReadLine().ToLower().Trim();
            int i, yage=0, oage=0, off = 0, dall=0;
            for (i = 1; i < 101; i++)
                to100.Add(i);
            if (lob.text == "y" | lob.text == "yes")
            {
                see1 = lob.text;
                while (off == 0)
                {
                    int y=0;
                    Console.Write("Here are the prefrences ");
                    for (i = 0; i < prefrences.Count; i++)
                    {
                        if (i < prefrences.Count)
                            Console.Write($"{prefrences[i]} ");
                        else
                            Console.WriteLine(prefrences[i]);
                    }
                    Console.WriteLine("Enter witch you want on then enter play");
                    lob.text = Console.ReadLine().ToLower().Trim();
                    if (lob.text == "family")
                    {
                        see2 = lob.text;
                        dall = dall+1;
                        Console.WriteLine("Done");
                        y = 1;
                    }
                    else if (lob.text.Contains("step"))
                    {
                        see2 = lob.text;
                        dall =dall +10;
                        Console.WriteLine("Done");
                        y = 1;
                    }
                    if (lob.text == "boy")
                    { 
                        dall = +1; 
                        lob.sex = lob.text; 
                        Console.WriteLine("Done");
                        y = 1;
                    }
                    else if (lob.text == "girl")
                    { 
                        dall = dall+10;
                        lob.sex = lob.text;
                        Console.WriteLine("Done");
                        y = 1;
                    }
                    if (lob.text.Contains("preg"))
                    {
                        see3 = lob.text;
                        dall = dall + 1;
                        Console.WriteLine("Done");
                    }
                    else if (lob.text.Contains("ages"))
                    {
                        holo = lob.text.Substring(0, 6);
                        truse = Int32.TryParse(holo.Replace("ages", " ").Trim(), out yage);
                        if (truse == true)
                        {
                            Int32.TryParse(holo.Replace("ages", " ").Trim(), out yage);
                            holo = lob.text.Replace(holo, " ").Trim();
                            truse = Int32.TryParse(holo.Replace("to", " ").Trim(), out oage);
                            if (truse == true)
                            {
                                Int32.TryParse(holo.Replace("to", " ").Trim(), out oage);
                                dall = dall + 1;
                                Console.WriteLine("Done");
                            }
                            else
                                Console.WriteLine("Did not work");
                        }
                        else
                            Console.WriteLine("Did not work");
                    }
                    else if (lob.text == "beast")
                    {
                        dall = dall + 1;
                        Console.WriteLine("Done");
                        see4 = lob.text;
                    }
                    else if (lob.text == "energy")
                    {
                        Console.WriteLine("Type a number between 1-101");
                        lob.text = Console.ReadLine().Trim().ToLower();
                        for (i = 0; i < to100.Count; i++)
                            if (lob.text == i.ToString())
                                holo = lob.text.Replace(i.ToString(), " ").Trim();
                        holo = lob.text.Replace(holo, " ").Trim();
                        truse = Int32.TryParse(holo, out lob.enr);
                        if (truse == true)
                        {
                            lob.energy = lob.enr / 100;
                            dall = dall + 1;
                            Console.WriteLine("Done");
                        }
                        else
                            Console.WriteLine("You did not type a number");
                    }
                    else if (lob.text.Contains("custom"))
                    {
                        didcus = true;
                        dall = dall + 1;
                        Console.WriteLine("Done");
                    }
                    else if (lob.text == "play")
                    {
                        int play = 0;
                        lob.max = 25;
                        lob.min = 2;
                        while (play == 0)
                        {
                            if (dall <= lob.max && dall >= lob.min)
                            {
                                lob.hall = dall;
                                Console.WriteLine("Loading");
                                AllList(0, lob.hall, oage, yage);
                                play = 1;
                            }
                            else
                            {
                                Console.WriteLine("You didn't pick any but that's ok but now I get to chose");
                                dall = rand.Next(26);
                            }
                            off = 1;
                        }
                    }
                    else if (y == 0)
                        Console.WriteLine("Not an option");
                    else if (y == 1) ;
                    else
                        Console.WriteLine("Error");
                }

            }
        }
        class Checker
        {
            public string text,sex;
            public double time, pTime, energy;
            public int set, enr, max, min, hall;
        }
        static void AllList(int i, int take, int oge, int yge)
        {
            Checker lob = new Checker();
            List<int> b = new List<int>(10);
            double mon = 0.00;
            string[] things = new string[2];
            string size = "";
            int yelo = 0;
            for (i = 0; i < b.Count; i++)
                b[i] = yelo;
            for (i = 0; i < things.Length; i++)
            {
                if (i == 0)
                    things[i] = "dick";
                else things[i] = "boobs";
            }
            int h;
            Console.WriteLine("Hello and wel cum");
            take = lob.hall;
            if (take == lob.min)
            {
                Console.WriteLine($"Choose what size your {things[0]} is out of tiny,small,medium,large");
                size = Console.ReadLine().Trim().ToLower();
            }
            else if (take == lob.max)
            {
                Console.WriteLine($"Choose what size your {things[1]} are out of tiny,small,medium,large");
                size = Console.ReadLine().Trim().ToLower();
            }
            else if (take > lob.min && take < lob.max)
            {
                if (lob.sex == "boy")
                {
                    Console.WriteLine($"Choose what size your {things[0]} is out of tiny,small,medium,large");
                    size = Console.ReadLine().Trim().ToLower();
                }
                else if (lob.sex == "girl")
                {
                    Console.WriteLine($"Choose what size your {things[1]} are out of tiny,small,medium,large");
                    size = Console.ReadLine().Trim().ToLower();
                }
            }
            while (yelo == 0)
            { 
                if (size.StartsWith("t"))
                {

                }
                else if (size.StartsWith("s")&&size.EndsWith("l")) ;
                else if (size.StartsWith("m")) ;
                else if (size.StartsWith("l")) ;
                else
                    size = "t";
            }








            if (lob.text == "sleep" && lob.set == 0)
            {
                switch (lob.pTime)
                {
                    case 1.00:
                        lob.set = 1;
                        break;
                    default:
                        lob.pTime = lob.pTime + 0.01;
                        break;
                }
            }
            else if (lob.text == "nap")
            {
                bool on;
                Console.WriteLine("for _ hour and __ min or get up put a. for min");
                lob.text = Console.ReadLine();
                on = Int32.TryParse(lob.text, out h);
                if (on == true)
                {
                    lob.time = lob.time + h;
                }
                else if (on == false)
                {
                    on = double.TryParse(lob.text, out double nime);

                }
            }

        }
    }
}
