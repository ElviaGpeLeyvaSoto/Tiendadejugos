using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaJugos.Core.Entidades
{
    public class Venta
    {
        public int Id { get; set; }
        public string Folio { get; set; }
        public Jugo Jugo { get; set; }
        public Usuario Usuario { get; set; }
        public double Total { get; set; }
    }
}
