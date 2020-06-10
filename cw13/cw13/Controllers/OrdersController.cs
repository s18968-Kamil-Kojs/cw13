using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw13.DTOs.Requests;
using cw13.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw13.Controllers {

    [Route("api/orders")]
    [ApiController]
    public class OrdersController :ControllerBase {
        private readonly DataBaseContext _context;

        public OrdersController(DataBaseContext context) {
            _context = context;
        }

        [HttpPost]
        public IActionResult getOrders(ClientRequest clientRequest) {
            if (clientRequest.Surname == null) {
                var wszystkieZamowienia = _context.Zamowienie.ToList();
                return Ok(wszystkieZamowienia);
            } else {
                var idKlienta = _context.Klient.Where(k => k.Nazwisko.Equals(clientRequest.Surname)).First();
                var zamowienia = _context.Zamowienie.Where(z => z.IdKlient == idKlienta.IdKlient).ToList();
                List<List<string>> listaWynikowa = new List<List<string>>();
                foreach(Zamowienie zamowienie in zamowienia) {
                    List<string> listaWyrobowWZamowieniu = new List<string>();
                    var wyroby = _context.Zamowienie_WyrobCukierniczy.Where(z_w => z_w.IdZamowienia == zamowienie.IdZamowienia).ToList();
                    foreach(Zamowienie_WyrobCukierniczy zamowienie_WyrobCukierniczy in wyroby){
                        string nazwaWyrobu = _context.WyrobCukierniczy.Where(w => w.IdWyrobuCukierniczego == zamowienie_WyrobCukierniczy.IdWyrobuCukierniczego).First().Nazwa;
                        listaWyrobowWZamowieniu.Add(nazwaWyrobu);
                    }
                    listaWynikowa.Add(listaWyrobowWZamowieniu);
                }
                return Ok(listaWynikowa);
            }
        }

        [HttpPut]
        public IActionResult postOrder(int id, OrderRequest orderRequest) {
            if (orderRequest == null || id == 0) {
                return BadRequest(300);
            }
            foreach (WyrobRequest wyrob in orderRequest.wyroby) {
                int doesExist = _context.WyrobCukierniczy.Where(w => w.Nazwa.Equals(wyrob.wyrob)).Count();
                if (doesExist == 0) return BadRequest(301);
            }
            int noweId = _context.Zamowienie.Max(z => z.IdZamowienia) + 1;
            _context.Zamowienie.Add(new Zamowienie { /*IdZamowienia = noweId,*/ DataPrzyjecia = Convert.ToDateTime(orderRequest.dataPrzyjecia), Uwagi = orderRequest.uwagi });

            foreach (WyrobRequest wyrob in orderRequest.wyroby) {
                int idWyrobu = _context.WyrobCukierniczy.Where(w => w.Nazwa.Equals(wyrob.wyrob)).First().IdWyrobuCukierniczego;
                _context.Zamowienie_WyrobCukierniczy.Add(new Zamowienie_WyrobCukierniczy { IdWyrobuCukierniczego = idWyrobu, IdZamowienia = noweId, Ilosc = Int32.Parse(wyrob.ilosc), Uwagi = wyrob.uwagi});
            }

            _context.SaveChanges();
            return Ok("Zamowienie dodane");
        }
    }
}
