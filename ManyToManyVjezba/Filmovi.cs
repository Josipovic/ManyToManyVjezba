using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyVjezba
{
    public class Filmovi
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual List<Glumci>Glumac { get; set; }

        public Filmovi()
        {
            Glumac = new List<Glumci>();
        }
    }
}
