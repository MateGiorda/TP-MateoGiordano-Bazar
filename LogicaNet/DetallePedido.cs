using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNet
{
    public class DetallePedido
    {
        public int idDetallePedido { get; set; }
        public string direccion { get; set; }
        public string descripcion { get; set; }
        public int cantidadPedida { get; set; }
    }
}
