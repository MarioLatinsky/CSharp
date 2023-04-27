using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6Homework.Entities
{
    public static class Helper

    {
        public static void PrintEntities<T>(this List<T> list) where T : BaseEntity
        {
            
            foreach (T item in list)
            {
                item.Print();
            }
        }

        public static void PrintItems<T>(this List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine("HHH");
            }
        }

    }
}
