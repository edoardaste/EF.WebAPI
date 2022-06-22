using System.Collections.Generic;

namespace EF.WebAPI.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecretIdentity SecretIdentity { get; set; }
        public List<Gun>Guns { get; set; }
        public List<HeroBatle> HeroBatles { get; set; }
    }
}
