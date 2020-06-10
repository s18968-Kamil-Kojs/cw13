using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace cw13.Models {
    public class Zamowienie {
        public int IdZamowienia { get; set; }
        public DateTime DataPrzyjecia { get; set; }
        public DateTime DataRealizacji { get; set; }
        public string Uwagi { get; set; }
        [ForeignKey("Klient")]
        public int IdKlient { get; set; }
        [ForeignKey("Pracownik")]
        public int IdPracownik { get; set; }

        public Zamowienie() {
        }
    }
}
