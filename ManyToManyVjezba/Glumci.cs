using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyVjezba
{
   public class Glumci
    {
        public int Id { get; set; }
        public string Ime { get; set; }

        public virtual List<Filmovi>Film { get; set; }

        public Glumci()
        {
            Film = new List<Filmovi>();
        }
    }
}
