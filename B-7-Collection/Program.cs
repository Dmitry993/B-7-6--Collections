using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayListExample();
            
            Console.ReadLine();
        }

        public static void ArrayListExample()
        {
            var list = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nest row please");
                list.Add(Console.ReadLine());
            }

            foreach (var row in list)
            {
                Console.WriteLine(row);
            }
        }

       
        public class Song
        {
            
        }
                          
    }
}
