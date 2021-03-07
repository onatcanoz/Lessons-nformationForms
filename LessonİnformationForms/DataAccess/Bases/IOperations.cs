using LessonİnformationForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonİnformationForms.DataAccess.Bases
{
    interface IOperations
    {
        List<Dersler> GetDersler();

        void AddDers(Dersler dersler);

        Dersler GetById(int id);

        List<Kategoriler> GetKategoriler();

        int IncrementAndGetId(List<Dersler> dersler);

        void DeleteLesson(int id);
    }
}
