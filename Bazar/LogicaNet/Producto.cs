using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNet
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombreProd { get; set; }
        public float precio { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public string color { get; set; }
        public string material { get; set; }
    }
}
