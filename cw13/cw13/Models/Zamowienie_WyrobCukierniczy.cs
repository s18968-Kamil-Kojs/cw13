using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace cw13.Models {
    public class Zamowienie_WyrobCukierniczy {
        [ForeignKey("WyrobCukierniczy")]
        public int IdWyrobuCukierniczego { get; set; }
        [ForeignKey("Zamowienie")]
        public int IdZamowienia { get; set; }
        public int Ilosc { get; set; }
        public string Uwagi { get; set; }

        public Zamowienie_WyrobCukierniczy() {
        }
    }
}
