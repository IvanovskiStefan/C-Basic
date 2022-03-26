using SEDC.Oop.Class08.Excercises.Models;
using System;
using System.Collections.Generic;

namespace SEDC.Oop.Class08.Excercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Please enter your name");
            //string name = Console.ReadLine();

            //Dictionary<string, int> phoneBook = new Dictionary<string, int>

            //{
            //    { "Stefan" , 123455},
            //{ "Aneta" , 1234455},
            //{ "ALeksandar" , 123445565},
            //{ "Igor" , 1234412314},
            //{ "Bojan" , 123355}};

            //foreach(KeyValuePair<string,int> pEntry in phoneBook)
            //{
            //    if(pEntry.Key == name  )
            //    {
            //        Console.WriteLine($"The number for {name} is : {pEntry.Value }");

            //    }
            //    else 
            //    { 
            //        Console.WriteLine("Error, wrong name. We cannot find this name in the phonebook");

            //    }

            //}
            Song boom = new Song("Boom", 3, Enums.Genre.Rock);
            List<Song> songList1 = new List<Song>
            {
               new Song ("Boom", 3,Enums.Genre.Rock),
               new Song ("Oxia", 3,Enums.Genre.Techno)
            };
            Person person = new Person(123,"Stefan", "ivanovski",33,Enums.Genre.Rock, songList1);
            person.getFavoriteSongs();

        }

       
    }
}
