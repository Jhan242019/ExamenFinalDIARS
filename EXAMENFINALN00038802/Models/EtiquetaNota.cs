using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXAMENFINALN00038802.Models
{
    public class EtiquetaNota
    {
        public int Id { set; get; }
        public int IdEtiqueta { set; get; }
        public int IdNota { set; get; }
        public Etiqueta Etiqueta { set; get; }
    }
}
