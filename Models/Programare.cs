using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Coptil_Ianc_Proiect2.Models
{
    public class Programare
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string NumePrenumeClient { get; set; }
        public string TelefonClient { get; set; }
        public string Email { get; set; }
        public DateTime DataSiOra { get; set; }
        public string NumePisica { get; set; }
        public int VarstaPisica { get; set; }
        public string RasaPisica { get; set; }
        public string SexPisica { get; set; }
        public string Observatii { get; set; }
        public string TipHrana { get; set; }
        public string TipCamera { get; set; }
        public string TipServiciu { get; set; }
    }
}
