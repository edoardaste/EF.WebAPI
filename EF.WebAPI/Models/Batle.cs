using System;
using System.Collections.Generic;

namespace EF.WebAPI.Models
{
    public class Batle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtFinish {get; set; }
        public List<HeroBatle> HeroBatles { get; set; }

    }
}
