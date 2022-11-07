using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar
{
    public class DetalleCompra
    {
        public int idDetalleCompra { get; set; }
        public DateTime fechaCompra { get; set; }
        public DateTime fechaVenta { get; set; }
        public string metodoPago { get; set; }
        public float precioTotal { get; set; }
    }
}
