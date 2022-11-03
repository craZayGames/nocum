using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;


namespace nocum
{
    class Program
    {

        static void Main(string[] npcSex)
        {
            double v = 1.00, u = 0.01;
            npcSex = new string[2];
            npcSex[0] = "F";
            npcSex[1] = "M";
            List<string> npcs = new List<string> { "Mom", "Dad", "Dogs", "Cats", "Birds", "Reptiles", "Fishes", "Humanoids", "Spiders", "Insects", "BroSisr", "Horses", "Elaphants", "Dragons" };
            int done = -1, ioc, i, j, endnum = 0, max = 10, fert = 0, rer = 0;
            StringBuilder sb = new StringBuilder(npcs[9]);
            string sex = "", fob, hi;
            bool btf, ene, itp, Ps = true, ch;
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
                        while (done == -1)
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
                                    { Console.WriteLine("not one"); done++; }

                                }
                                else
                                {
                                    Console.WriteLine("I said number");
                                    done++;
                                }
                            }
                            else if (hi != "n")
                            {
                                Console.WriteLine("Y OR N");
                            }
                            else done++;
                        }
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
                btf = fob.StartsWith("y");
                if (fob.Contains(","))
                {
                    ioc = fob.IndexOf(",");
                    sex = fob.Substring(ioc + 1);
                    fob = fob.Remove(ioc);
                    if (sex.StartsWith("b"))
                    {
                        for (i = 0; i < npcs.Count; i++)
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
                    else if (sex.StartsWith("o"))
                    {
                        for (i = 0; i < npcs.Count; i++)
                        {
                            if (i >= 2)
                            {
                                if (i >= 2 && i != npcs.IndexOf("BroSisr"))
                                {
                                    npcs[i].Replace("s", " ").Trim();
                                    npcs.Add(npcSex[1] + npcs[i]);
                                    npcs[i] = npcSex[0] + npcs[i];
                                }
                                else
                                {
                                    sb.Insert(3, npcSex[0]);
                                    sb[8] = Convert.ToChar("");
                                    sb.Insert(0, npcSex[1]);
                                    npcs[9] = sb.ToString().Substring(0, 4);
                                    npcs.Add(sb.ToString().Substring(5));
                                }
                            }
                            else
                                npcs[i] = npcSex[i] + npcs[i];
                        }
                    }
                    else
                        for (i = 0; i < npcs.Count; i++)
                        {
                            if (i != 0)
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
                    ch = Stroub.Preg(fert == 1, v, u);
                }
                else if (max == 10 && fert == 0)
                {
                    Ps = Stroub.Ender(rer, max);
                    ch = Stroub.Preg(false, v, u);
                }
                else
                {
                    Ps = true;
                    ch = false;
                }
                Thegame.Game(Ps, ch, npcs, btf, sex);
                done++;
            }
        }
    }
    class Stroub
    {
        public static bool Ender(int saw, int max)
        {
            bool PS = saw < max;
            return PS;
        }
        public static bool Preg(bool yn, double fert, double chance)
        {
            bool check = (yn == true || fert >= 1.00 && chance == 1.00);
            return check;
        }

    }
    class Thegame
    {
        public static void Game(bool g, bool a, List<string> me, bool bt, string sex)
        {
            List<string> sexpo = new List<string> { "hand", "oral", "chits", "ass", "pSpot" };
            bool done = 1 == 0, homedone = done, exploredone = 0 == 0, pregcheck = done;
            Random r = new Random();
            string velp, bederh = "sleep", gred = "rest, back", malk = "0,0";
            if (a == true)
                velp = "100% chance";
            else
                velp = "chance";
            List<string> fel = new List<string> { "looks", velp, "relation", "arousal", "ycorrup", "tcorrup", "snwf%", "energy", "fert", "closedes", "pain" }, qiper = new List<string>();
            double delp, time = 8.00, ptime = 0.00, pime = 0;
            if (a == true)
                double.TryParse(velp.Substring(0, 3), out delp);
            else
                delp = 0.01;
            List<double> feelingd = new List<double> { 0.01, delp, 0.01, 0.00, 0.01, 0.01, 0.01, 1.00, 1.00, 0.00, 0.00 };
            int i = 0, rum = r.Next(me.Count), j = 1, preg = 0, who = 0, fas = Convert.ToInt32(feelingd[7]), m = 0, q, lastrum = 0, REE = 0, naked = 0, cuming = 0, cythwc = 0, saw = 0;
            int[] vergen = new int[6];
            List<bool> boolers = new List<bool> {feelingd[2]==1,feelingd[3]==1,feelingd[4]==1,feelingd[5]==1,feelingd[6]==1 }; bool bolo = (boolers[0] && boolers[1] && boolers[2] && boolers[3] && boolers[4] && boolers[5])==true;
            while (done != true)
            {
                Console.WriteLine("It's setptember 1st and its a new year for you because you just turned 18");
                Console.WriteLine("and your woundering what it's like being 18.");
                Console.WriteLine("");
                Console.WriteLine("Enter next to continue");
                velp = Console.ReadLine().Trim().ToLower();
                while (i == 0)
                {
                    if (velp == "next")
                    {
                        i = 1;
                    }
                    else if (velp == "lust filled")
                    {
                        feelingd[2] = 1.00;
                        feelingd[4] = 1.00;
                        feelingd[5] = 1.00;
                    }
                    else
                    {
                        Console.WriteLine("Entering next");
                        velp = "next";
                    }
                }
                Console.WriteLine("Starting in your room where do you go");
                Console.WriteLine("bed 1, wardrobe 2, living room 3, on phone 4 type the hole word or just the number");
                Console.WriteLine("then press enter");
                velp = Console.ReadLine().Trim().ToLower();
                while (homedone == done)
                    if (velp == "bed" | velp == "1")
                    {
                        m = 0;
                        Console.WriteLine("what you can do here");
                        if (time > 20.00 | time < 8.00)
                            gred = $"{bederh} {j}, {gred.Substring(0, 4)} {j++} {gred.Substring(5)} {j++}";
                        else
                            gred = $"{gred.Substring(0, 4)} {j} {gred.Substring(5)}";
                        Console.WriteLine(gred);
                        velp = Console.ReadLine().Trim().ToLower();
                        while (m == 0)
                            if (velp == bederh)
                            {
                                time = 8.00;
                                if (a == true && preg == 1)
                                {
                                    pime = Inol.Ptime(ptime, who, fas);
                                }
                                else if (preg == 1 && pime == 1.00)
                                    preg = 2;
                                else if (preg == 2)
                                {

                                }
                                m = 1;
                            }
                            else if (velp == "rest")
                            {
                                string y;
                                Console.WriteLine("#h and #m enter numbers were # are and type , were and");
                                malk = Console.ReadLine().Trim();
                                StringBuilder bloof = new StringBuilder(malk);
                                y = bloof[0].ToString();
                                int.TryParse(y, out q);
                                time = q + time;
                                y = bloof[2].ToString();
                                if (bloof[3] > 0)
                                    y = y + bloof[3];
                                else
                                    y = y + 0;
                                int.TryParse(y, out q);
                                time = (q / 100) + time;
                            }
                    }
                    else if (velp == "wardrobe" | velp == "2")
                    {

                    }
                    else if (velp == "living room" | velp == "3")
                    {
                        m = 0;
                        while (m == 0)
                        {
                            string kelp = $"{me[9].Substring(0, 1)}";
                            if (kelp == "F")
                                Console.WriteLine("parents room 1, sisters room 2, kitchen 3, bathroom 4, your room 5, leave 6");
                            else if (kelp == "M")
                                Console.WriteLine("parents room 1, brothers room 2, kitchen 3, bathroom 4, your room 5, leave 6");
                            else
                                Console.WriteLine("parents room 1, sisters room 2, brothers room 3, kitchen 4, bathroom 5, your room 6, leave 7");
                            velp = Console.ReadLine().Trim().ToLower();
                            if (velp == "1")
                            {

                            }
                            else if (velp == "2")
                            {
                                int dlb=sex.Length-3;
                                if (bolo == true)
                                {
                                    
                                }
                                else
                                {

                                }

                            }
                            else if (velp == "3")
                            {

                            }
                            else if (velp == "4")
                            {

                            }
                            else if (velp == "5")
                            {

                            }
                            else if (velp == "6" && sex == "o")
                            {

                            }
                            else
                            {
                                homedone = homedone == done;
                            }
                        }
                    }
                    else
                    {

                    }
                Console.WriteLine("home 1, Explore 2");
                bool relp = 1 == 0;
                velp = Console.ReadLine().ToLower().Trim();
                if (velp == "1")
                    homedone = done;
                else
                {
                    string qip = "", dext;
                    exploredone = done;
                    while (exploredone == done)
                    {
                        rum = r.Next(5);
                        if (rum == 0)
                        {
                            rum = r.Next(5);
                            if (rum == 0)
                                qip = ("N");
                            else if (rum == 1)
                                qip = ("E");
                            else if (rum == 2)
                                qip = ("S");
                            else
                                qip = ("W");
                        }
                        else if (rum == 1)
                        {
                            while (relp == done)
                            {
                                lastrum = rum = r.Next(5);
                                rum = r.Next(5);
                                if (lastrum == rum)
                                    rum = r.Next(5);
                                else
                                    relp = relp == done;
                            }
                            rum = rum + lastrum;
                            if (rum == 1)
                                qip = ("N, E");
                            else if (rum == 2)
                                qip = ("N, S");
                            else if (rum == 3)
                            {
                                if (lastrum == 0 | lastrum == 3)
                                    qip = ("N, W");
                                else
                                    qip = ("E, S");
                            }
                            else if (rum == 4)
                                qip = ("E ,W");
                            else
                                qip = ("S, W");
                        }
                        else if (rum == 2)
                        {
                            relp = done;
                            while (relp == done)
                            {
                                REE = lastrum = rum = r.Next(5);
                                rum = r.Next(5);
                                if (lastrum == rum)
                                    rum = r.Next(5);
                                else if (REE == lastrum)
                                    rum = r.Next(5);
                                else
                                    relp = relp == done;
                            }
                            rum = rum + lastrum + REE;
                            if (rum == 3)
                                qip = ("N, E, S");
                            else if (rum == 4)
                                qip = ("N, E, W");
                            else if (rum == 5)
                                qip = ("N, S, W");
                            else if (rum == 6)
                                qip = ("E, S, W");
                        }
                        else
                            qip = ("N, E, S, W");
                        Console.WriteLine(qip);
                        m = 0;
                        int qipount = +1; ;
                        double cumelp = +1 / 10;
                        while (m == 0)
                        {
                            velp = Console.ReadLine().Trim().ToUpper();
                            if (qip.Contains(velp))
                            {
                                string faal;
                                double qelpelp;
                                int qiped = r.Next(3), qelp = r.Next(12), sexr = r.Next(5) + 1, runr = r.Next(6), anly;
                                bool ob = bt;
                                anly = rum = r.Next(me.Count);
                                faal = me[rum];
                                qelpelp = r.Next(4);
                                qiper.Add(qip);
                                if(ob==true)
                                    while ( bt== true)
                                {
                                    if (qelp == 9 | (qelp == 3 && qelpelp == 3) | qelp == 10 | qelp == 11 && (sex == "g" | sex == "o"))
                                    {
                                        dext = $"You were walking allong when a {me[rum].Substring(1)}";
                                        if (qiped == 2)
                                        {
                                            dext = dext + "snuck up behind you and";
                                            if (sexr == 5)
                                            {
                                                dext = dext + "pushed you to the ground and where your chest was a log, so you belived you triped and you could not predic what happend next";
                                                sexpo[sexpo.Count] = "pussy";
                                                if (vergen[4] == 0)
                                                {
                                                    feelingd[feelingd.Count] = +0.25;
                                                    if (naked > 0)
                                                    {
                                                        rum = r.Next(2);
                                                        while (feelingd[feelingd.Count - 1] != 1)
                                                        {
                                                            if (rum == 1)
                                                            {
                                                                feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                                dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                            }
                                                            else
                                                            {
                                                                feelingd[feelingd.Count - 1] = +1 / naked;
                                                                dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                            }
                                                        }
                                                        feelingd[feelingd.Count] = +0.29;
                                                        vergen[4] = 1;
                                                        while (cuming != 1 && cythwc > 10)
                                                        {
                                                            rum = r.Next(100);
                                                            feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                            while (anly == 0)
                                                            { cythwc = +1; anly = 1; }
                                                            feelingd[3] = +0.12;
                                                            if (cumelp == 1)
                                                            {
                                                                cuming = 1;
                                                                if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                                {
                                                                    if (qipount <= 6)
                                                                    {
                                                                        rum = r.Next(2);
                                                                        if (rum == 0)
                                                                            saw = +1;

                                                                    }
                                                                    else
                                                                    {
                                                                        rum = r.Next(20) + 1;
                                                                        if (rum == 20)
                                                                        {
                                                                            rum = r.Next(2);
                                                                            if (rum == 0)
                                                                                saw = +1;

                                                                        }

                                                                    }
                                                                }
                                                                else feelingd[3] = +0.12;
                                                            }

                                                        }
                                                    }
                                                }
                                                else
                                                    if (naked > 0)
                                                {
                                                    rum = r.Next(2);
                                                    while (feelingd[feelingd.Count - 1] != 1)
                                                    {
                                                        if (rum == 1)
                                                        {
                                                            feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                            dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                        }
                                                        else
                                                        {
                                                            feelingd[feelingd.Count - 1] = +1 / naked;
                                                            dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                        }
                                                    }
                                                    feelingd[feelingd.Count] = +0.29;
                                                    vergen[4] = 1;
                                                    while (cuming != 1 && cythwc > 10)
                                                    {
                                                        rum = r.Next(100);
                                                        feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                        while (anly == 0)
                                                        { cythwc = +1; anly = 1; }
                                                        feelingd[3] = +0.12;
                                                        if (cumelp == 1)
                                                        {
                                                            cuming = 1;
                                                            if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                            {
                                                                if (qipount <= 6)
                                                                {
                                                                    rum = r.Next(2);
                                                                    if (rum == 0)
                                                                        saw = +1;

                                                                }
                                                                else
                                                                {
                                                                    rum = r.Next(20) + 1;
                                                                    if (rum == 20)
                                                                    {
                                                                        rum = r.Next(2);
                                                                        if (rum == 0)
                                                                            saw = +1;

                                                                    }

                                                                }
                                                            }
                                                            else feelingd[3] = +0.12;
                                                        }

                                                    }
                                                }
                                            }
                                            else if (sexr == 4)
                                            {
                                                dext = dext + "pushed you to the ground and where your chest was a log, so you belived you triped and you could not predic what happend next";
                                                if (vergen[3] == 0)
                                                {
                                                    feelingd[feelingd.Count] = +0.25;
                                                    if (naked > 0)
                                                    {
                                                        rum = r.Next(2);
                                                        while (feelingd[feelingd.Count - 1] != 1)
                                                        {
                                                            if (rum == 1)
                                                            {
                                                                feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                                dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                            }
                                                            else
                                                            {
                                                                feelingd[feelingd.Count - 1] = +1 / naked;
                                                                dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                            }
                                                        }
                                                        feelingd[feelingd.Count] = +0.29;
                                                        vergen[3] = 1;
                                                        while (cuming != 1 && cythwc > 10)
                                                        {
                                                            rum = r.Next(100);
                                                            feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                            while (anly == 0)
                                                            { cythwc = +1; anly = 1; }
                                                            feelingd[3] = +0.12;
                                                            if (cumelp == 1)
                                                            {
                                                                cuming = 1;
                                                                if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                                {
                                                                    if (qipount <= 6)
                                                                    {
                                                                        rum = r.Next(2);
                                                                        if (rum == 0)
                                                                            saw = +1;

                                                                    }
                                                                    else
                                                                    {
                                                                        rum = r.Next(20) + 1;
                                                                        if (rum == 20)
                                                                        {
                                                                            rum = r.Next(2);
                                                                            if (rum == 0)
                                                                                saw = +1;

                                                                        }

                                                                    }
                                                                }
                                                                else feelingd[3] = +0.12;
                                                            }

                                                        }
                                                    }
                                                }
                                                else
                                                    if (naked > 0)
                                                {
                                                    rum = r.Next(2);
                                                    while (feelingd[feelingd.Count - 1] != 1)
                                                    {
                                                        if (rum == 1)
                                                        {
                                                            feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                            dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                        }
                                                        else
                                                        {
                                                            feelingd[feelingd.Count - 1] = +1 / naked;
                                                            dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                        }
                                                    }
                                                    feelingd[feelingd.Count] = +0.29;
                                                    vergen[3] = 1;
                                                    while (cuming != 1 && cythwc > 10)
                                                    {
                                                        rum = r.Next(100);
                                                        feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                        while (anly == 0)
                                                        { cythwc = +1; anly = 1; }
                                                        feelingd[3] = +0.12;
                                                        if (cumelp == 1)
                                                        {
                                                            cuming = 1;
                                                            if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                            {
                                                                if (qipount <= 6)
                                                                {
                                                                    rum = r.Next(2);
                                                                    if (rum == 0)
                                                                        saw = +1;

                                                                }
                                                                else
                                                                {
                                                                    rum = r.Next(20) + 1;
                                                                    if (rum == 20)
                                                                    {
                                                                        rum = r.Next(2);
                                                                        if (rum == 0)
                                                                            saw = +1;

                                                                    }

                                                                }
                                                            }
                                                            else feelingd[3] = +0.12;
                                                        }

                                                    }
                                                }
                                            }
                                            else if (sexr == 3)
                                            {
                                                dext = $"You were walking allong when a {me[rum].Substring(1)} apeerd in front of you for a second and then charged at you and knocking you down to the ground and pinning you";
                                                sexpo[2] = "tits";
                                                if (vergen[2] == 0)
                                                {
                                                    feelingd[feelingd.Count] = +0.25;
                                                    if (naked > 0)
                                                    {
                                                        rum = r.Next(2);
                                                        while (feelingd[feelingd.Count - 1] != 1)
                                                        {
                                                            if (rum == 1)
                                                            {
                                                                feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                                dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                            }
                                                            else
                                                            {
                                                                feelingd[feelingd.Count - 1] = +1 / naked;
                                                                dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                            }
                                                        }
                                                        feelingd[feelingd.Count] = +0.29;
                                                        vergen[2] = 1;
                                                        while (cuming != 1 && cythwc > 10)
                                                        {
                                                            rum = r.Next(100);
                                                            feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                            while (anly == 0)
                                                            { cythwc = +1; anly = 1; }
                                                            feelingd[3] = +0.12;
                                                            if (cumelp == 1)
                                                            {
                                                                cuming = 1;
                                                                if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                                {
                                                                    if (qipount <= 6)
                                                                    {
                                                                        rum = r.Next(2);
                                                                        if (rum == 0)
                                                                            saw = +1;

                                                                    }
                                                                    else
                                                                    {
                                                                        rum = r.Next(20) + 1;
                                                                        if (rum == 20)
                                                                        {
                                                                            rum = r.Next(2);
                                                                            if (rum == 0)
                                                                                saw = +1;

                                                                        }

                                                                    }
                                                                }
                                                                else feelingd[3] = +0.12;
                                                            }

                                                        }
                                                    }
                                                }
                                                else
                                                    if (naked > 0)
                                                {
                                                    rum = r.Next(2);
                                                    while (feelingd[feelingd.Count - 1] != 1)
                                                    {
                                                        if (rum == 1)
                                                        {
                                                            feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                            dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                        }
                                                        else
                                                        {
                                                            feelingd[feelingd.Count - 1] = +1 / naked;
                                                            dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                        }
                                                    }
                                                    feelingd[feelingd.Count] = +0.29;
                                                    vergen[2] = 1;
                                                    while (cuming != 1 && cythwc > 10)
                                                    {
                                                        rum = r.Next(100);
                                                        feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                        while (anly == 0)
                                                        { cythwc = +1; anly = 1; }
                                                        feelingd[3] = +0.12;
                                                        if (cumelp == 1)
                                                        {
                                                            cuming = 1;
                                                            if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                            {
                                                                if (qipount <= 6)
                                                                {
                                                                    rum = r.Next(2);
                                                                    if (rum == 0)
                                                                        saw = +1;

                                                                }
                                                                else
                                                                {
                                                                    rum = r.Next(20) + 1;
                                                                    if (rum == 20)
                                                                    {
                                                                        rum = r.Next(2);
                                                                        if (rum == 0)
                                                                            saw = +1;

                                                                    }

                                                                }
                                                            }
                                                            else feelingd[3] = +0.12;
                                                        }

                                                    }
                                                }
                                            }
                                            else if (sexr == 2)
                                            {
                                                dext = $"You were walking allong when a {me[rum].Substring(1)} apeerd in front of you for a second and then charged at you and knocking you down to the ground and pinning you";
                                                if (vergen[1] == 0)
                                                {
                                                    feelingd[feelingd.Count] = +0.25;
                                                    if (naked > 0)
                                                    {
                                                        rum = r.Next(2);
                                                        while (feelingd[feelingd.Count - 1] != 1)
                                                        {
                                                            if (rum == 1)
                                                            {
                                                                feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                                dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                            }
                                                            else
                                                            {
                                                                feelingd[feelingd.Count - 1] = +1 / naked;
                                                                dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                            }
                                                        }
                                                        feelingd[feelingd.Count] = +0.29;
                                                        vergen[1] = 1;
                                                        while (cuming != 1 && cythwc > 10)
                                                        {
                                                            rum = r.Next(100);
                                                            feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                            while (anly == 0)
                                                            { cythwc = +1; anly = 1; }
                                                            feelingd[3] = +0.12;
                                                            if (cumelp == 1)
                                                            {
                                                                cuming = 1;
                                                                if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                                {
                                                                    if (qipount <= 6)
                                                                    {
                                                                        rum = r.Next(2);
                                                                        if (rum == 0)
                                                                            saw = +1;

                                                                    }
                                                                    else
                                                                    {
                                                                        rum = r.Next(20) + 1;
                                                                        if (rum == 20)
                                                                        {
                                                                            rum = r.Next(2);
                                                                            if (rum == 0)
                                                                                saw = +1;

                                                                        }

                                                                    }
                                                                }
                                                                else feelingd[3] = +0.12;
                                                            }

                                                        }
                                                    }
                                                }
                                                else
                                                    if (naked > 0)
                                                {
                                                    rum = r.Next(2);
                                                    while (feelingd[feelingd.Count - 1] != 1)
                                                    {
                                                        if (rum == 1)
                                                        {
                                                            feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                            dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                        }
                                                        else
                                                        {
                                                            feelingd[feelingd.Count - 1] = +1 / naked;
                                                            dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                        }
                                                    }
                                                    feelingd[feelingd.Count] = +0.29;
                                                    vergen[1] = 1;
                                                    while (cuming != 1 && cythwc > 10)
                                                    {
                                                        rum = r.Next(100);
                                                        feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                        while (anly == 0)
                                                        { cythwc = +1; anly = 1; }
                                                        feelingd[3] = +0.12;
                                                        if (cumelp == 1)
                                                        {
                                                            cuming = 1;
                                                            if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                            {
                                                                if (qipount <= 6)
                                                                {
                                                                    rum = r.Next(2);
                                                                    if (rum == 0)
                                                                        saw = +1;

                                                                }
                                                                else
                                                                {
                                                                    rum = r.Next(20) + 1;
                                                                    if (rum == 20)
                                                                    {
                                                                        rum = r.Next(2);
                                                                        if (rum == 0)
                                                                            saw = +1;

                                                                    }

                                                                }
                                                            }
                                                            else feelingd[3] = +0.12;
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                dext = $"You were walking allong when a {me[rum].Substring(1)} apeerd in front of you for a second and then charged at you and knocking you down to the ground and pinning you";
                                                sexpo[3] = "tits";
                                                if (vergen[0] == 0)
                                                {
                                                    feelingd[feelingd.Count] = +0.25;
                                                    if (naked > 0)
                                                    {
                                                        rum = r.Next(2);
                                                        while (feelingd[feelingd.Count - 1] != 1)
                                                        {
                                                            if (rum == 1)
                                                            {
                                                                feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                                dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                            }
                                                            else
                                                            {
                                                                feelingd[feelingd.Count - 1] = +1 / naked;
                                                                dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                            }
                                                        }
                                                        feelingd[feelingd.Count] = +0.29;
                                                        vergen[0] = 1;
                                                        while (cuming != 1 && cythwc > 10)
                                                        {
                                                            rum = r.Next(100);
                                                            feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                            while (anly == 0)
                                                            { cythwc = +1; anly = 1; }
                                                            feelingd[3] = +0.12;
                                                            if (cumelp == 1)
                                                            {
                                                                cuming = 1;
                                                                if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                                {
                                                                    if (qipount <= 6)
                                                                    {
                                                                        rum = r.Next(2);
                                                                        if (rum == 0)
                                                                            saw = +1;

                                                                    }
                                                                    else
                                                                    {
                                                                        rum = r.Next(20) + 1;
                                                                        if (rum == 20)
                                                                        {
                                                                            rum = r.Next(2);
                                                                            if (rum == 0)
                                                                                saw = +1;

                                                                        }

                                                                    }
                                                                }
                                                                else feelingd[3] = +0.12;
                                                            }

                                                        }
                                                    }
                                                }
                                                else
                                                    if (naked > 0)
                                                {
                                                    rum = r.Next(2);
                                                    while (feelingd[feelingd.Count - 1] != 1)
                                                    {
                                                        if (rum == 1)
                                                        {
                                                            feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                            dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                        }
                                                        else
                                                        {
                                                            feelingd[feelingd.Count - 1] = +1 / naked;
                                                            dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                        }
                                                    }
                                                    feelingd[feelingd.Count] = +0.29;
                                                    vergen[0] = 1;
                                                    while (cuming != 1 && cythwc > 10)
                                                    {
                                                        rum = r.Next(100);
                                                        feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                        while (anly == 0)
                                                        { cythwc = +1; anly = 1; }
                                                        feelingd[3] = +0.12;
                                                        if (cumelp == 1)
                                                        {
                                                            cuming = 1;
                                                            if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                            {
                                                                if (qipount <= 6)
                                                                {
                                                                    rum = r.Next(2);
                                                                    if (rum == 0)
                                                                        saw = +1;

                                                                }
                                                                else
                                                                {
                                                                    rum = r.Next(20) + 1;
                                                                    if (rum == 20)
                                                                    {
                                                                        rum = r.Next(2);
                                                                        if (rum == 0)
                                                                            saw = +1;

                                                                    }

                                                                }
                                                            }
                                                            else feelingd[3] = +0.12;
                                                        }
                                                    }
                                                }
                                            }

                                            Console.WriteLine(dext);
                                        }
                                        else if (qiped == 1)
                                        {
                                            dext = dext.Replace("when", "when you see") + "looking at you flusterd";
                                            Console.WriteLine(dext + " what do you do? out of let him have you or run");
                                            velp = Console.ReadLine().Trim().ToLower();
                                            if (velp == "run")
                                            {
                                                runr = runr + 1;
                                                if (runr <= 3)
                                                {
                                                    dext = dext + " but you got away";
                                                    if (runr == 3)
                                                        dext = dext.Replace("got", "bearly got");
                                                    else if (runr == 2)
                                                        dext = dext.Replace("got", "just got");
                                                }
                                                else
                                                {
                                                    dext = dext + "snuck up behind you and";
                                                    if (sexr == 5)
                                                    {
                                                        dext = dext + "pushed you to the ground and where your chest was a log, so you belived you triped and you could not predic what happend next";
                                                        sexpo[sexpo.Count] = "pussy";
                                                        if (vergen[4] == 0)
                                                        {
                                                            feelingd[feelingd.Count] = +0.25;
                                                            if (naked > 0)
                                                            {
                                                                rum = r.Next(2);
                                                                while (feelingd[feelingd.Count - 1] != 1)
                                                                {
                                                                    if (rum == 1)
                                                                    {
                                                                        feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                                        dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                                    }
                                                                    else
                                                                    {
                                                                        feelingd[feelingd.Count - 1] = +1 / naked;
                                                                        dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                                    }
                                                                }
                                                                feelingd[feelingd.Count] = +0.29;
                                                                vergen[4] = 1;
                                                                while (cuming != 1 && cythwc > 10)
                                                                {
                                                                    rum = r.Next(100);
                                                                    feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                                    while (anly == 0)
                                                                    { cythwc = +1; anly = 1; }
                                                                    feelingd[3] = +0.12;
                                                                    if (cumelp == 1)
                                                                    {
                                                                        cuming = 1;
                                                                        if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                                        {
                                                                            if (qipount <= 6)
                                                                            {
                                                                                rum = r.Next(2);
                                                                                if (rum == 0)
                                                                                    saw = +1;

                                                                            }
                                                                            else
                                                                            {
                                                                                rum = r.Next(20) + 1;
                                                                                if (rum == 20)
                                                                                {
                                                                                    rum = r.Next(2);
                                                                                    if (rum == 0)
                                                                                        saw = +1;

                                                                                }

                                                                            }
                                                                        }
                                                                        else feelingd[3] = +0.12;
                                                                    }

                                                                }
                                                            }
                                                        }
                                                        else
                                                            if (naked > 0)
                                                        {
                                                            rum = r.Next(2);
                                                            while (feelingd[feelingd.Count - 1] != 1)
                                                            {
                                                                if (rum == 1)
                                                                {
                                                                    feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                                    dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                                }
                                                                else
                                                                {
                                                                    feelingd[feelingd.Count - 1] = +1 / naked;
                                                                    dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                                }
                                                            }
                                                            feelingd[feelingd.Count] = +0.29;
                                                            vergen[4] = 1;
                                                            while (cuming != 1 && cythwc > 10)
                                                            {
                                                                rum = r.Next(100);
                                                                feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                                while (anly == 0)
                                                                { cythwc = +1; anly = 1; }
                                                                feelingd[3] = +0.12;
                                                                if (cumelp == 1)
                                                                {
                                                                    cuming = 1;
                                                                    if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                                    {
                                                                        if (qipount <= 6)
                                                                        {
                                                                            rum = r.Next(2);
                                                                            if (rum == 0)
                                                                                saw = +1;

                                                                        }
                                                                        else
                                                                        {
                                                                            rum = r.Next(20) + 1;
                                                                            if (rum == 20)
                                                                            {
                                                                                rum = r.Next(2);
                                                                                if (rum == 0)
                                                                                    saw = +1;

                                                                            }

                                                                        }
                                                                    }
                                                                    else feelingd[3] = +0.12;
                                                                }

                                                            }
                                                        }
                                                    }
                                                    else if (sexr == 4)
                                                    {
                                                        dext = dext + "pushed you to the ground and where your chest was a log, so you belived you triped and you could not predic what happend next";
                                                        if (vergen[3] == 0)
                                                        {
                                                            feelingd[feelingd.Count] = +0.25;
                                                            if (naked > 0)
                                                            {
                                                                rum = r.Next(2);
                                                                while (feelingd[feelingd.Count - 1] != 1)
                                                                {
                                                                    if (rum == 1)
                                                                    {
                                                                        feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                                        dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                                    }
                                                                    else
                                                                    {
                                                                        feelingd[feelingd.Count - 1] = +1 / naked;
                                                                        dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                                    }
                                                                }
                                                                feelingd[feelingd.Count] = +0.29;
                                                                vergen[3] = 1;
                                                                while (cuming != 1 && cythwc > 10)
                                                                {
                                                                    rum = r.Next(100);
                                                                    feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                                    while (anly == 0)
                                                                    { cythwc = +1; anly = 1; }
                                                                    feelingd[3] = +0.12;
                                                                    if (cumelp == 1)
                                                                    {
                                                                        cuming = 1;
                                                                        if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                                        {
                                                                            if (qipount <= 6)
                                                                            {
                                                                                rum = r.Next(2);
                                                                                if (rum == 0)
                                                                                    saw = +1;

                                                                            }
                                                                            else
                                                                            {
                                                                                rum = r.Next(20) + 1;
                                                                                if (rum == 20)
                                                                                {
                                                                                    rum = r.Next(2);
                                                                                    if (rum == 0)
                                                                                        saw = +1;

                                                                                }

                                                                            }
                                                                        }
                                                                        else feelingd[3] = +0.12;
                                                                    }

                                                                }
                                                            }
                                                        }
                                                        else
                                                            if (naked > 0)
                                                        {
                                                            rum = r.Next(2);
                                                            while (feelingd[feelingd.Count - 1] != 1)
                                                            {
                                                                if (rum == 1)
                                                                {
                                                                    feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                                    dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                                }
                                                                else
                                                                {
                                                                    feelingd[feelingd.Count - 1] = +1 / naked;
                                                                    dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                                }
                                                            }
                                                            feelingd[feelingd.Count] = +0.29;
                                                            vergen[3] = 1;
                                                            while (cuming != 1 && cythwc > 10)
                                                            {
                                                                rum = r.Next(100);
                                                                feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                                while (anly == 0)
                                                                { cythwc = +1; anly = 1; }
                                                                feelingd[3] = +0.12;
                                                                if (cumelp == 1)
                                                                {
                                                                    cuming = 1;
                                                                    if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                                    {
                                                                        if (qipount <= 6)
                                                                        {
                                                                            rum = r.Next(2);
                                                                            if (rum == 0)
                                                                                saw = +1;

                                                                        }
                                                                        else
                                                                        {
                                                                            rum = r.Next(20) + 1;
                                                                            if (rum == 20)
                                                                            {
                                                                                rum = r.Next(2);
                                                                                if (rum == 0)
                                                                                    saw = +1;

                                                                            }

                                                                        }
                                                                    }
                                                                    else feelingd[3] = +0.12;
                                                                }

                                                            }
                                                        }
                                                    }
                                                    else if (sexr == 3)
                                                    {
                                                        dext = $"You were walking allong when a {me[rum].Substring(1)} apeerd in front of you for a second and then charged at you and knocking you down to the ground and pinning you";
                                                        sexpo[2] = "tits";
                                                        if (vergen[2] == 0)
                                                        {
                                                            feelingd[feelingd.Count] = +0.25;
                                                            if (naked > 0)
                                                            {
                                                                rum = r.Next(2);
                                                                while (feelingd[feelingd.Count - 1] != 1)
                                                                {
                                                                    if (rum == 1)
                                                                    {
                                                                        feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                                        dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                                    }
                                                                    else
                                                                    {
                                                                        feelingd[feelingd.Count - 1] = +1 / naked;
                                                                        dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                                    }
                                                                }
                                                                feelingd[feelingd.Count] = +0.29;
                                                                vergen[2] = 1;
                                                                while (cuming != 1 && cythwc > 10)
                                                                {
                                                                    rum = r.Next(100);
                                                                    feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                                    while (anly == 0)
                                                                    { cythwc = +1; anly = 1; }
                                                                    feelingd[3] = +0.12;
                                                                    if (cumelp == 1)
                                                                    {
                                                                        cuming = 1;
                                                                        if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                                        {
                                                                            if (qipount <= 6)
                                                                            {
                                                                                rum = r.Next(2);
                                                                                if (rum == 0)
                                                                                    saw = +1;

                                                                            }
                                                                            else
                                                                            {
                                                                                rum = r.Next(20) + 1;
                                                                                if (rum == 20)
                                                                                {
                                                                                    rum = r.Next(2);
                                                                                    if (rum == 0)
                                                                                        saw = +1;

                                                                                }

                                                                            }
                                                                        }
                                                                        else feelingd[3] = +0.12;
                                                                    }

                                                                }
                                                            }
                                                        }
                                                        else
                                                            if (naked > 0)
                                                        {
                                                            rum = r.Next(2);
                                                            while (feelingd[feelingd.Count - 1] != 1)
                                                            {
                                                                if (rum == 1)
                                                                {
                                                                    feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                                    dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                                }
                                                                else
                                                                {
                                                                    feelingd[feelingd.Count - 1] = +1 / naked;
                                                                    dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                                }
                                                            }
                                                            feelingd[feelingd.Count] = +0.29;
                                                            vergen[2] = 1;
                                                            while (cuming != 1 && cythwc > 10)
                                                            {
                                                                rum = r.Next(100);
                                                                feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                                while (anly == 0)
                                                                { cythwc = +1; anly = 1; }
                                                                feelingd[3] = +0.12;
                                                                if (cumelp == 1)
                                                                {
                                                                    cuming = 1;
                                                                    if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                                    {
                                                                        if (qipount <= 6)
                                                                        {
                                                                            rum = r.Next(2);
                                                                            if (rum == 0)
                                                                                saw = +1;

                                                                        }
                                                                        else
                                                                        {
                                                                            rum = r.Next(20) + 1;
                                                                            if (rum == 20)
                                                                            {
                                                                                rum = r.Next(2);
                                                                                if (rum == 0)
                                                                                    saw = +1;

                                                                            }

                                                                        }
                                                                    }
                                                                    else feelingd[3] = +0.12;
                                                                }

                                                            }
                                                        }
                                                    }
                                                    else if (sexr == 2)
                                                    {
                                                        dext = $"You were walking allong when a {me[rum].Substring(1)} apeerd in front of you for a second and then charged at you and knocking you down to the ground and pinning you";
                                                        if (vergen[1] == 0)
                                                        {
                                                            feelingd[feelingd.Count] = +0.25;
                                                            if (naked > 0)
                                                            {
                                                                rum = r.Next(2);
                                                                while (feelingd[feelingd.Count - 1] != 1)
                                                                {
                                                                    if (rum == 1)
                                                                    {
                                                                        feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                                        dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                                    }
                                                                    else
                                                                    {
                                                                        feelingd[feelingd.Count - 1] = +1 / naked;
                                                                        dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                                    }
                                                                }
                                                                feelingd[feelingd.Count] = +0.29;
                                                                vergen[1] = 1;
                                                                while (cuming != 1 && cythwc > 10)
                                                                {
                                                                    rum = r.Next(100);
                                                                    feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                                    while (anly == 0)
                                                                    { cythwc = +1; anly = 1; }
                                                                    feelingd[3] = +0.12;
                                                                    if (cumelp == 1)
                                                                    {
                                                                        cuming = 1;
                                                                        if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                                        {
                                                                            if (qipount <= 6)
                                                                            {
                                                                                rum = r.Next(2);
                                                                                if (rum == 0)
                                                                                    saw = +1;

                                                                            }
                                                                            else
                                                                            {
                                                                                rum = r.Next(20) + 1;
                                                                                if (rum == 20)
                                                                                {
                                                                                    rum = r.Next(2);
                                                                                    if (rum == 0)
                                                                                        saw = +1;

                                                                                }

                                                                            }
                                                                        }
                                                                        else feelingd[3] = +0.12;
                                                                    }

                                                                }
                                                            }
                                                        }
                                                        else
                                                            if (naked > 0)
                                                        {
                                                            rum = r.Next(2);
                                                            while (feelingd[feelingd.Count - 1] != 1)
                                                            {
                                                                if (rum == 1)
                                                                {
                                                                    feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                                    dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                                }
                                                                else
                                                                {
                                                                    feelingd[feelingd.Count - 1] = +1 / naked;
                                                                    dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                                }
                                                            }
                                                            feelingd[feelingd.Count] = +0.29;
                                                            vergen[1] = 1;
                                                            while (cuming != 1 && cythwc > 10)
                                                            {
                                                                rum = r.Next(100);
                                                                feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                                while (anly == 0)
                                                                { cythwc = +1; anly = 1; }
                                                                feelingd[3] = +0.12;
                                                                if (cumelp == 1)
                                                                {
                                                                    cuming = 1;
                                                                    if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                                    {
                                                                        if (qipount <= 6)
                                                                        {
                                                                            rum = r.Next(2);
                                                                            if (rum == 0)
                                                                                saw = +1;

                                                                        }
                                                                        else
                                                                        {
                                                                            rum = r.Next(20) + 1;
                                                                            if (rum == 20)
                                                                            {
                                                                                rum = r.Next(2);
                                                                                if (rum == 0)
                                                                                    saw = +1;

                                                                            }

                                                                        }
                                                                    }
                                                                    else feelingd[3] = +0.12;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        dext = $"You were walking allong when a {me[rum].Substring(1)} apeerd in front of you for a second and then charged at you and knocking you down to the ground and pinning you";
                                                        sexpo[3] = "tits";
                                                        if (vergen[0] == 0)
                                                        {
                                                            feelingd[feelingd.Count] = +0.25;
                                                            if (naked > 0)
                                                            {
                                                                rum = r.Next(2);
                                                                while (feelingd[feelingd.Count - 1] != 1)
                                                                {
                                                                    if (rum == 1)
                                                                    {
                                                                        feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                                        dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                                    }
                                                                    else
                                                                    {
                                                                        feelingd[feelingd.Count - 1] = +1 / naked;
                                                                        dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                                    }
                                                                }
                                                                feelingd[feelingd.Count] = +0.29;
                                                                vergen[0] = 1;
                                                                while (cuming != 1 && cythwc > 10)
                                                                {
                                                                    rum = r.Next(100);
                                                                    feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                                    while (anly == 0)
                                                                    { cythwc = +1; anly = 1; }
                                                                    feelingd[3] = +0.12;
                                                                    if (cumelp == 1)
                                                                    {
                                                                        cuming = 1;
                                                                        if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                                        {
                                                                            if (qipount <= 6)
                                                                            {
                                                                                rum = r.Next(2);
                                                                                if (rum == 0)
                                                                                    saw = +1;

                                                                            }
                                                                            else
                                                                            {
                                                                                rum = r.Next(20) + 1;
                                                                                if (rum == 20)
                                                                                {
                                                                                    rum = r.Next(2);
                                                                                    if (rum == 0)
                                                                                        saw = +1;

                                                                                }

                                                                            }
                                                                        }
                                                                        else feelingd[3] = +0.12;
                                                                    }

                                                                }
                                                            }
                                                        }
                                                        else
                                                            if (naked > 0)
                                                        {
                                                            rum = r.Next(2);
                                                            while (feelingd[feelingd.Count - 1] != 1)
                                                            {
                                                                if (rum == 1)
                                                                {
                                                                    feelingd[feelingd.Count - 1] = +0.25 / naked;
                                                                    dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware just trying to get through to your {sexpo[sexpo.Count]} to fuck it";
                                                                }
                                                                else
                                                                {
                                                                    feelingd[feelingd.Count - 1] = +1 / naked;
                                                                    dext = dext + $" the {me[rum].Substring(1)} has you pinned to the ground so you can't get up and starts to destroy your pants and underware aiming for your {sexpo[sexpo.Count]}";
                                                                }
                                                            }
                                                            feelingd[feelingd.Count] = +0.29;
                                                            vergen[0] = 1;
                                                            while (cuming != 1 && cythwc > 10)
                                                            {
                                                                rum = r.Next(100);
                                                                feelingd[feelingd.Count] = feelingd[feelingd.Count] + rum / feelingd[feelingd.Count];
                                                                while (anly == 0)
                                                                { cythwc = +1; anly = 1; }
                                                                feelingd[3] = +0.12;
                                                                if (cumelp == 1)
                                                                {
                                                                    cuming = 1;
                                                                    if (feelingd[3] >= 88 || (feelingd[2] == feelingd[4] && feelingd[4] == feelingd[5]))
                                                                    {
                                                                        if (qipount <= 6)
                                                                        {
                                                                            rum = r.Next(2);
                                                                            if (rum == 0)
                                                                                saw = +1;

                                                                        }
                                                                        else
                                                                        {
                                                                            rum = r.Next(20) + 1;
                                                                            if (rum == 20)
                                                                            {
                                                                                rum = r.Next(2);
                                                                                if (rum == 0)
                                                                                    saw = +1;

                                                                            }

                                                                        }
                                                                    }
                                                                    else feelingd[3] = +0.12;
                                                                }
                                                            }
                                                        }
                                                    }

                                                }

                                                Console.WriteLine(dext);
                                            }
                                        }
                                    }
                                }
                                else
                                    while(bt==done)
                                    {

                                    }

                            }
                        }
                    }
                }

            }
        }
        class Inol
        {
            public static double Ptime(double time, int who, int fert)
            {
                return (who * 10 + (time * fert));
            }


       
            
        }
    }
}
