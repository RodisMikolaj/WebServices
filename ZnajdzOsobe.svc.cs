using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebServices.Controllers;
using System.Collections;

namespace WebServices
{
   
    public class ZnajdzOsobe : IZnajdzOsobe
    {
        public string WgNazwiska(string nazwisko)
        {
            List<DaneOsobowe> osoby = new List<DaneOsobowe>();
            osoby.Add(new DaneOsobowe() { imie = "Mikołaj",  nazwisko = "Sidor", adres = "Pepowo" });
            osoby.Add(new DaneOsobowe() { imie = "Oskar", nazwisko = "Adamiec", adres = "Bydgoszcz" });
            osoby.Add(new DaneOsobowe() { imie = "Joanna", nazwisko = "Silacz", adres = "Koronowo" });
            osoby.Add(new DaneOsobowe() { imie = "Bartek", nazwisko = "Plachecki", adres = "Kijow" });
            osoby.Add(new DaneOsobowe() { imie = "Marcel", nazwisko = "Tupak", adres = "Warszawa" });
            try
            {
                DaneOsobowe wynik = osoby.Find(x => x.nazwisko.Contains(nazwisko));
                if (wynik == null) return "Nie odnaleziono nikogo o podanym nazwisku";
                else return string.Format("{0} {1} {2}", wynik.imie, wynik.nazwisko, wynik.adres);
            }
            catch (ArgumentNullException)
            {
                return "Wpisz nazwe";
            }
        }
    }
}
