using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirModel
{
    public class EkipaModel
    {
        /// <summary>
        /// Ovjde smo deklarirali koliko ce clanova ekipa imati 
        /// </summary>
        public List<OsobaModel> ClanoviEkipe { get; set; } = new List<OsobaModel>();
        /// <summary>
        /// Ovdje smo deklarirali ime ekipa koje ce se ili su se prijavili
        /// </summary>
        public string ImeEkipe { get; set; }
    }
}
