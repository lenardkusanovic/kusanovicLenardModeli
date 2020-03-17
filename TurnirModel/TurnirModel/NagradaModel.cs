using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirModel
{
    public class NagradaModel
    {
        /// <summary>
        /// Tu smo deklarirali neko mjesto ekipe 
        /// odnosno koje mjesto je ekipa osvojila
        /// </summary>
        public int OsvojenoMjesto { get; set; }
        /// <summary>
        /// Ovo je naziv tog osvojenog mjesta
        /// </summary>
        public string NazivMjesta { get; set; }
        /// <summary>
        /// Ovdje smo deklarirali koliki je iznos osvojenih nagrada
        /// </summary>
        public decimal IznosNagrade { get; set; }
        /// <summary>
        /// Ovo je postotak nagrade koji izracunavamo pomocu ukupnog postotka od kotizacije
        /// </summary>
        public double PostotakNagrade { get; set; }
    }
}
