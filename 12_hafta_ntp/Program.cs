using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_hafta_ntp
{


    class Database
    {
        public virtual void add()
        {
            Console.WriteLine("added by default");
        }

    }

    class sqlserver : Database
    {
        public override void add()
        {
            Console.WriteLine("added by sql code");
        }
        
    }

    abstract class database
    {
        public abstract void add();
        public string name { get; set; }
    }

    class sql : database
    {

        public override void add()
        {
            Console.WriteLine(name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Database d = new Database();
            sqlserver d2 = new sqlserver();

            // database dw = new database(); //abstact class newlenmez!

            sql s = new sql();
            s.name = "zehra";

            s.add();

            d.add();
            d2.add();


            #region 
            //DateTime ile örnek

            DateTime baslangıc = new DateTime();
            baslangıc = DateTime.Now;

            for(int i = 0; i < 10000000; i++)
            {

            }

            DateTime bitis = new DateTime();
            bitis = DateTime.Now;

            TimeSpan geçenzaman = bitis - baslangıc;

            Console.WriteLine("geçen zaman " + geçenzaman);
            Console.ReadKey();
            #endregion
        }
    }
}
