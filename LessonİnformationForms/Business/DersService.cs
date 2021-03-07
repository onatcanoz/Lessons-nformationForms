using LessonİnformationForms.DataAccess;
using LessonİnformationForms.DataAccess.Bases;
using LessonİnformationForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonİnformationForms.Business
{
    class DersService
    {
        MemoryOperations forkategori = new MemoryOperations();
        private readonly IOperations operations;
        public DersService(IOperations _operations)
        {
            operations = _operations;
        }
        
        
        public List<Dersler> GetList()
        {
            return operations.GetDersler();
        }

        public List<Kategoriler> GetCategories()
        {
            return forkategori.GetKategoriler();
        }

        internal void AddDers(Dersler dersler)
        {
            operations.AddDers(dersler);
        }

        internal Dersler GetDers(int id)
        {
            return operations.GetById(id);
        }

        internal void DeleteDers(int id)
        {
            operations.DeleteLesson(id);
        }
    }
}
