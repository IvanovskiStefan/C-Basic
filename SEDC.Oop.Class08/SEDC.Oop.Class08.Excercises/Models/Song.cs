using SEDC.Oop.Class08.Excercises.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class08.Excercises.Models
{
    public class Song 
    {
        public string Title { get; set; }
        public int Lenght { get; set; }
        public Genre Genre { get; set; }

        

       

        public Song(string title, int lenght, Genre genre)
        {
            Title = title;
            Lenght = lenght;
            Genre = genre;
           

        }
        
        


        

    }

   
}
