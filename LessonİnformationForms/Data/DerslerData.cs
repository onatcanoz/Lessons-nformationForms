using LessonİnformationForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonİnformationForms.Data
{
    public static class DerslerData
    {
        public static List<Dersler> DersListesi { get; set; }
        static DerslerData()
        {
            DersListesi = new List<Dersler>()
            {
                new Dersler()
                {
                    Id =1,
                    Adi = "Matematik",
                    Icerigi = "Sayılar",
                    Kategorisi = Enums.Kategori.Sayısal,
                    Kredisi = 5
                },
                new Dersler()
                {
                    Id = 2,
                    Adi = "Tarih",
                    Icerigi = "Kurtuluş Savaşı",
                    Kategorisi = Enums.Kategori.Sosyal,
                    Kredisi=3
                },
                new Dersler()
                {
                    Id=3,
                    Adi = "İngilizce",
                    Icerigi = "Prepositions",
                    Kategorisi = Enums.Kategori.Sosyal,
                    Kredisi =2
                }
            };
        }
    }
}
