using SEDC.Oop.Class08.Excercises.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class08.Excercises.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List <Song> FavoriteSongs { get; set; }

        public Person(int id, string firstName, string lastName, int age, Genre favoriteMusicType, List<Song> favoriteSongs)
        {

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
            FavoriteSongs = favoriteSongs;





        }

        public void getFavoriteSongs()
        {
            if (FavoriteSongs.Count == 0)
            {
                Console.WriteLine($"{FirstName} hates music!!");
                return;
            }
            Console.WriteLine($" {FirstName} {LastName} Favorite songs: {FavoriteSongs}");
            
        }
    }

    
}
