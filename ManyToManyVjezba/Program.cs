using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyVjezba
{
    class Program
    {
        static void Main(string[] args)
        {
            FilmContext db = new FilmContext();

            Filmovi f = new Filmovi();
            f.Naziv = "Terminator";

            Filmovi f1 = new Filmovi();
            f1.Naziv = "Terminator2";

            Filmovi f2 = new Filmovi();
            f2.Naziv = "Karate";

            Filmovi f3 = new Filmovi();

            f3.Naziv = "neki film";

            Glumci g = new Glumci();
            g.Ime = "svarceneger";

            Glumci g1 = new Glumci();
            g1.Ime = "jackie";

            g.Film.Add(f);
            g.Film.Add(f1);
            g.Film.Add(f3);
            g1.Film.Add(f2);
            g1.Film.Add(f3);

            db.Glumci.Add(g);
            db.Glumci.Add(g1);
            //db.SaveChanges();

            foreach (var a in db.Glumci) {
                Console.WriteLine(a.Ime);
                foreach (var l in a.Film) {
                    Console.WriteLine("    "  + l.Naziv);
                }

                Console.Read();
            }
        }
    }
}
