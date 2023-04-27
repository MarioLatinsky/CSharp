using HomeworkClass4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass4
{
     public static class GenericDB<T> where T : BaseEntity
    {
        public static List<T> Db;
        static  GenericDB()
        {
            Db = new List<T>();
        }

        public static void Insert(T entity)
        {
            Db.Add(entity);

            Console.WriteLine($"The item {entity.GetType().Name} was added to GenericDb");

        }
        public static T GetById(int id) => Db.FirstOrDefault(x => x.Id == id);

        public static void PrintAll()
        {
            foreach (T item in Db) 
            {
                Console.WriteLine(item);
            }
        }
       
    }
}
