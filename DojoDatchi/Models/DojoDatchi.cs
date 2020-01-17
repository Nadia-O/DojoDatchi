using System;

namespace DojoDatchi.Models
{
    public class Datchi
    {
        public int Happiness {get; set;}
        public int Fullness {get; set;}
        public int Energy {get; set;}
        public int Meals {get; set;} 


        public Datchi()
        {
            Happiness = 20;
            Fullness = 20;
            Energy = 50;
            Meals = 3;
        }
    }

    
}