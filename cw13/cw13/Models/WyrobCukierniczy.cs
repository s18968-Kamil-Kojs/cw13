using System;
namespace cw13.Models {
    public class WyrobCukierniczy {
        public int IdWyrobuCukierniczego { get; set; }
        public string Nazwa { get; set; }
        public float CenaZaSzt { get; set; }
        public string Typ { get; set; }

        public WyrobCukierniczy() {
        }
    }
}
