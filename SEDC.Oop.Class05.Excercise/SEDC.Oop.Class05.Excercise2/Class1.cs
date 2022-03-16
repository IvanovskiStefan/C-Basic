using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class05.Excercise2
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string  Color { get; set; }
        
        
        
        
        string DogIsEating()
               
        {
            return ($"The dog {Name} is now Eating");
        }

        public string DogIsPlaying()
        {
           return ($"The dog {Name} is now Playing");

        }

        public string ChaseTail()
        {
            return ($"The dog {Name} is now Chaising his tail");

        }

    }

    
}
