using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirModel
{
    public class UtakmicaModel
    {
        
        /// <summary>
        /// Ovo je lista svih sudionika u toj jednoj utakmici
        /// </summary>
        public List<SudionikModel> Natjecatelji { get; set; } = new List<SudionikModel>();
        /// <summary>
        /// Pobjednik te utakmice koja se odigrala
        /// </summary>
        public EkipaModel Pobjednik { get; set; }
        /// <summary>
        /// Broj kola u kojoj se utakmica odrzava
        /// </summary>
        public int BrojRunde { get; set; }
    }
}
