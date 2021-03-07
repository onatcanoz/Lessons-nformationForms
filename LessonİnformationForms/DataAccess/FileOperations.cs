using LessonİnformationForms.Data;
using LessonİnformationForms.DataAccess.Bases;
using LessonİnformationForms.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonİnformationForms.DataAccess
{
    public class FileOperations : IOperations
    {
        private readonly string _path;
        private const char _seperator = '~';
        public FileOperations(string path)
        {
            _path = path;
        }

        public List<Dersler> GetDersler()
        {
            List<Dersler> dersListesi = new List<Dersler>();
            StreamReader sR = new StreamReader(_path);
            Dersler ders;
            string line;
            while ((line = sR.ReadLine()) != null)
            {
                var derslerData = line.Split(_seperator);
                ders = new Dersler()
                {
                    Id = Convert.ToInt32(derslerData[0]),
                    Adi = derslerData[1],
                    Icerigi = derslerData[2],
                    Kategorisi = (Enums.Kategori)Convert.ToInt32(derslerData[3]),
                    Kredisi = Convert.ToInt32(derslerData[4])
                };
                dersListesi.Add(ders);
            }
            sR.Close();
            return dersListesi;
        }

        public Dersler GetById(int id)
        {
            List<Dersler> dersler = GetDersler();
            Dersler ders = dersler.FirstOrDefault(dersItem => dersItem.Id == id);
            return ders;
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

        public void AddDers(Dersler dersler)
        {
            List<Dersler> ders = GetDersler();
            dersler.Id = IncrementAndGetId(ders);
            StreamWriter sW = new StreamWriter(_path, true, Encoding.UTF8);
            string line;
            if (ders.Count > 0)
            {
                line = "\n" + dersler.Id + _seperator.ToString() + dersler.Adi + _seperator.ToString() + dersler.Icerigi + _seperator.ToString() + (int)dersler.Kategorisi + _seperator.ToString() + dersler.Kredisi;
            }
            else
            {
                line =  dersler.Id + _seperator.ToString() + dersler.Adi + _seperator.ToString() + dersler.Icerigi + _seperator.ToString() + (int)dersler.Kategorisi + _seperator.ToString() + dersler.Kredisi;
            }
            sW.Write(line);
            sW.Close();

        }

        public void DeleteLesson(int id)
        {
            List<Dersler> dersler = GetDersler();
            Dersler silinecekogrenci = null;
            //Dersler ders = GetById(id);
            //if (ders != null)
            //{
            //    dersler.Remove(ders);
            //}
            foreach (var d in dersler)
            {
                if (d.Id == id)
                {
                    silinecekogrenci = d;
                    break;
                }
            }
            if (silinecekogrenci != null)
            {
                dersler.Remove(silinecekogrenci);
            }
            StreamWriter sW = new StreamWriter(_path, false, Encoding.UTF8);
            int i;
            string line = "";
            if (dersler.Count > 0)
            {
                for (i = 0; i < dersler.Count -1; i++)
                {
                    line = dersler[i].Id + _seperator.ToString() + dersler[i].Adi + _seperator.ToString() + dersler[i].Icerigi + _seperator.ToString() + (int)dersler[i].Kategorisi + _seperator.ToString() + dersler[i].Kredisi;
                    sW.WriteLine(line);
                }
                line = dersler[i].Id + _seperator.ToString() + dersler[i].Adi + _seperator.ToString() + dersler[i].Icerigi + _seperator.ToString() + (int)dersler[i].Kategorisi + _seperator.ToString() + dersler[i].Kredisi;
            }
            sW.Write(line);
            sW.Close();
        }
    }
}
