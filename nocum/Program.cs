using System;
using System.Collections.Generic;
using System.Linq;

namespace nocum
{
    class Program
    {
        static void Main(string[] args)
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
