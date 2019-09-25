using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyVjezba
{
    class FilmContext:DbContext
    {
        public  DbSet<Glumci>Glumci { get; set; }
        public  DbSet<Filmovi>Filmovi { get; set; }
    }
}
