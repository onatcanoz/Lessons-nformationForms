using LessonİnformationForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonİnformationForms.Data
{
    public static class KategoriData
    {
        public static List<Kategoriler> kategoriListesi { get; set; }

        static KategoriData()
        {
            kategoriListesi = new List<Kategoriler>()
            {
                new Kategoriler
                {
                    Value = 1,
                    Text = "Sayisal"
                },
                new Kategoriler
                {
                    Value=2,
                    Text = "Sosyal"
                }
            };
        }

    }
}
