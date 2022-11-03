using System;
using System.Collections.Generic;
using System.Text;

namespace nocum
{
    class Family
    {
        public static List<string> FACSR(string s, string rem)
        {
            s = s.Replace(rem, ""); int q;
            List<string> h = new List<string> { s.Remove(4) }; q = 0;
            h.Add(s.Replace(h[q], "").Remove(4)); q++;
            h.Add(s.Replace(h[q], "").Remove(4)); q++;
            h.Add(s.Replace(h[q], ""));
            return h;
        }
        public static string FamFeel(double arousel, double corruption, double synwf, double relation, string fammem)
        {
            return fammem + arousel + corruption + synwf + relation;
        }
        public static List<double> Dacsr(List<string>bob)
        {
            int i,dib=bob.Count;
            double bid;
            
            List<double> dod = new List<double>();
            for (i = 0; i < dib; i++)
            { 
                double.TryParse(bob[i], out bid); 
                dod.Add(bid); 
            }
            return dod;
        }
        public static void Remmer(string fem)
        {
            double a = 0.01, b = 0.00;
            string ger =FamFeel(b,b,b,a,fem);
            List<string> reg = FACSR(ger, fem);
            List<double> mef = Dacsr(reg);
            
        }
        
    }
}
