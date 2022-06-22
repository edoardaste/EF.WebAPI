using System.Collections.Generic;

namespace EF.WebAPI.Models
{
    public class HeroBatle
    {
        public int HeroId { get; set; } 
        public Hero Hero { get; set; }
        public int BatleId { get; set; }
        public Batle Batle { get; set; }    
        
    }
}
