using LessonİnformationForms.Data;
using LessonİnformationForms.DataAccess.Bases;
using LessonİnformationForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonİnformationForms.DataAccess
{
    public class MemoryOperations : IOperations
    {

        public void AddDers(Dersler dersler)
        {
            dersler.Id = IncrementAndGetId(DerslerData.DersListesi);
            DerslerData.DersListesi.Add(dersler);
        }

        public void DeleteLesson(int id)
        {
            Dersler ders = GetById(id);
            if (ders != null)
            {
                DerslerData.DersListesi.Remove(ders);
            }
        }

        public Dersler GetById(int id)
        {
            Dersler dersler = null;
            foreach (var ders in DerslerData.DersListesi)
            {
                if (ders.Id == id)
                {
                    dersler = ders;
                    break;
                }
            }
            return dersler;
        }

        public List<Dersler> GetDersler()
        {
            return DerslerData.DersListesi;
        }

        public List<Kategoriler> GetKategoriler()
        {
            return KategoriData.kategoriListesi;
        }

        public int IncrementAndGetId(List<Dersler> dersler)
        {
            int id;
            if (dersler != null && dersler.Count > 0)
            {
                Dersler ders;
                ders = dersler.LastOrDefault();
                id = ders.Id + 1;
            }
            else
            {
                id = 1;
            }
            return id;
        }
    }
}
