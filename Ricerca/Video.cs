using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricerca
{
    class Video
    {
        public string Soggetto { get; set; }
        public string Titolo { get; set; }
        public string Tag { get; set; }
        public string Autore { get; set; }
        public int Genere { get; set; }
        public string Durata { get; set; }
        public int Anno { get; set; }
        public string Note { get; set; }
        public string File { get; set; }

        public void Nuovo(string soggetto, string titolo)
        {
            Soggetto = soggetto;
            Titolo = titolo;
        }

    }
}
