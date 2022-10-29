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

        }
    }
}
