using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirModel
{
    public class TurnirModel
    {
        /// <summary>
        /// Ovo je naziv trenutnog turnira 
        /// </summary>
        public string NazivTurnira { get; set; }
        /// <summary>
        /// Ovo je iznos kotizacije potrebne da se jedan tim ukljuci u turnir
        /// </summary>
        public decimal Kotizacija { get; set; }
        /// <summary>
        /// Ovo je lista svih prijavljenih timova u turniru
        /// </summary>
        public List<EkipaModel> PrijavljeniTimovi { get; set; } = new List<EkipaModel>();
        /// <summary>
        /// Ovo je lista svih mogucih dobitaka odnosno nagrada
        /// </summary>
        public List<NagradaModel> Nagrade { get; set; } = new List<NagradaModel>();
        /// <summary>
        /// Ovo je lista kola koja se odvijaju
        /// </summary>
        public List<List<UtakmicaModel>> Kola { get; set; } = new List<List<UtakmicaModel>>();

    }
}
