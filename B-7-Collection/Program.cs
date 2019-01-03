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
            //ArrayListExample();
            //GenericListOfNeighborSearch();
            //DictionaryOfNeighborSearchh();
            //ArrayListPoemSort();
            //ArrayListOfSongsSort();
            GenericListOfSongsSort();

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
            public string Lyrics;

            public override string ToString()
            {
                return this.Lyrics;
            }
        }

        public static void GenericListOfNeighborSearch()
        {
            List<Neighbor> floorNeighbors = new List<Neighbor>();

            floorNeighbors.Add(new Neighbor() { FullName = "Igor Petrov", FlatNumber = 65, PhoneNumber = 2787734 });
            floorNeighbors.Add(new Neighbor() { FullName = "Sasha Ivanov", FlatNumber = 66, PhoneNumber = 2786531 });
            floorNeighbors.Add(new Neighbor() { FullName = "Vasya Sidorov", FlatNumber = 67, PhoneNumber = 2783324 });

            Console.WriteLine("Write flat number: ");
            var flatNum = int.Parse(Console.ReadLine());

            foreach (var neighbor in floorNeighbors)
            {
                if (neighbor.FlatNumber == flatNum)
                {
                    Console.WriteLine("Name: " + neighbor.FullName + "\nPhone number: " + neighbor.PhoneNumber);
                }
            }
        }
        public static void DictionaryOfNeighborSearchh()
        {
            Dictionary<int, Neighbor> floorNeighbors = new Dictionary<int, Neighbor>();

            floorNeighbors.Add(65, new Neighbor() { FullName = "Igor Petrov", FlatNumber = 65, PhoneNumber = 2787734 });
            floorNeighbors.Add(66, new Neighbor() { FullName = "Sasha Ivanov", FlatNumber = 66, PhoneNumber = 2786531 });
            floorNeighbors.Add(67, new Neighbor() { FullName = "Vasya Sidorov", FlatNumber = 67, PhoneNumber = 2783324 });

            Console.WriteLine("Write flat number: ");
            var flatNum = int.Parse(Console.ReadLine());

            if (floorNeighbors.ContainsKey(flatNum))
            {
                string name = floorNeighbors[flatNum].FullName;
                int number = floorNeighbors[flatNum].PhoneNumber;
                Console.WriteLine("Name: " + name + "\nPhone number: " + number);
            }
        }

        public static void ArrayListPoemSort()
        {
            ArrayList poem = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Write a line of poem:");
                string text = Console.ReadLine();
                poem.Add(text);
            }

            poem.Sort();
            poem.RemoveAt(4);
            object[] poemArray = poem.ToArray();

            Array.ForEach(poemArray, Console.WriteLine);
        }

        public static void ArrayListOfSongsSort()
        {
            ArrayList poem = new ArrayList();
            Song song = new Song();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Write a line of poem:");
                string text = Console.ReadLine();
                song.Lyrics += text + "\n";

            }

            //poem.Sort();
            poem.RemoveAt(4);
            object[] poemArray = poem.ToArray();

            Console.WriteLine(song.Lyrics);

        }

        public static void GenericListOfSongsSort()
        {
            List<Song> poem = new List<Song>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Write a line of poem:");
                string text = Console.ReadLine();
                poem.Add(new Song() { Lyrics = text });

            }

            //poem.Sort();
            poem.RemoveAt(4);
            poem.ForEach(Console.WriteLine);
        }

    }
}
