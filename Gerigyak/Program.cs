using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerigyak
{
    public class Alkalmazott
    {
       private string nev;
       private int kor;
       private int cicidb;

        public Alkalmazott(string nev, int cicidb) 
        {
            this.nev = nev;
            this.cicidb = cicidb;
        }

        public Alkalmazott(int kor) 
        {
            this.kor = kor;
        }
        
        static void Main(string[] args)
        {
            Alkalmazott a = new Alkalmazott("Józsi", 7);
            Alkalmazott b = new Alkalmazott(19);
            Console.WriteLine(a.nev + " " + a.cicidb);;
            Console.ReadKey();
        }


    }
}
