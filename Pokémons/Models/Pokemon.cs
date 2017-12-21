
namespace Pokémons.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pokemon
    {
        public string numero { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string categoria { get; set; }
        public string descripcion { get; set; }
        public string altura { get; set; }
        public string peso { get; set; }
        public string sexo { get; set; }
        public string ataques { get; set; }
        public string habilidad { get; set; }
        public string debilidad { get; set; }
        public string evoluciones { get; set; }
    }
}
