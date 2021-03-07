using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonİnformationForms.Models
{
    public class Dersler
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Icerigi { get; set; }
        public Enums.Kategori Kategorisi { get; set; }
        public int Kredisi { get; set; }
    }
}
