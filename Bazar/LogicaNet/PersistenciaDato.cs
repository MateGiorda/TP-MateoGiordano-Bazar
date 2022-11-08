using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace LogicaNet
{
    public class PersistenciaDato
    {
        /*//Rutas para notebook 
        readonly string RutaListaClientes = @"C:\Users\mateo\OneDrive\Documentos\tp-mateogiordano-bazar\ElBazar\archivosListas\ListaClientes.txt";
        readonly string RutaListaProveedor = @"C:\Users\mateo\OneDrive\Documentos\tp-mateogiordano-bazar\ElBazar\archivosListas\ListaProveedores.txt";
        readonly string RutaListaProductos = @"C:\Users\mateo\OneDrive\Documentos\tp-mateogiordano-bazar\ElBazar\archivosListas\ListaProductos.txt";
        readonly string RutaListaEmpleados = @"C:\Users\mateo\OneDrive\Documentos\tp-mateogiordano-bazar\ElBazar\archivosListas\ListaEmpleados.txt";
        */

        //Ruta para PC escritorio
        readonly string RutaListaClientes = @"C:\Users\Mateo\Desktop\Programacion\Copia codigo Bazar\archivosListas\ListaClientes.txt";
        readonly string RutaListaProveedor = @"C:\Users\Mateo\Desktop\Programacion\Copia codigo Bazar\archivosListas\ListaProveedores.txt";
        readonly string RutaListaProductos = @"C:\Users\Mateo\Desktop\Programacion\Copia codigo Bazar\archivosListas\ListaProductos.txt";
        readonly string RutaListaEmpleados = @"C:\Users\Mateo\Desktop\Programacion\Copia codigo Bazar\archivosListas\ListaEmpleados.txt";
        
        public void InicializarArchivo()
        {
            if (!File.Exists(RutaListaClientes))
            {
                File.Create(RutaListaClientes).Close();
            }

            if (!File.Exists(RutaListaProveedor))
            {
                File.Create(RutaListaProveedor).Close();
            }

            if (!File.Exists(RutaListaProductos))
            {
                File.Create(RutaListaProductos).Close();
            }

            if (!File.Exists(RutaListaEmpleados))
            {
                File.Create(RutaListaEmpleados).Close();
            }
        }

        public List<Cliente> LeerArchivoCliente()
        {
            string locationFile = RutaListaClientes;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Cliente> ListaClientes = JsonConvert.DeserializeObject<List<Cliente>>(content); 
                return ListaClientes;
            }
        }

        public List<Proveedor> LeerArchivoProveedor()
        {
            string locationFile = RutaListaProveedor;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Proveedor> ListaProveedor = JsonConvert.DeserializeObject<List<Proveedor>>(content);
                return ListaProveedor;
            }
        }

        public List<Producto> LeerArchivoProducto()
        {
            string locationFile = RutaListaProductos;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Producto> ListaProductos = JsonConvert.DeserializeObject<List<Producto>>(content);
                return ListaProductos;
            }
        }

        public List<Empleado> LeerArchivoEmpleado()
        {
            string locationFile = RutaListaEmpleados;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Empleado> ListaEmpleados = JsonConvert.DeserializeObject<List<Empleado>>(content);
                return ListaEmpleados;
            }
        }

        public void GuardarArchivoCliente(List<Cliente> ListaClientes)
        {
            string locationFile = RutaListaClientes;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaClientes);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoProveedor(List<Proveedor> ListaProveedor)
        {
            string locationFile = RutaListaProveedor;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaProveedor);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoProducto(List<Producto> ListaProductos)
        {
            string locationFile = RutaListaProductos;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaProductos);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoEmpleados(List<Empleado> ListaEmpleados)
        {
            string locationFile = RutaListaEmpleados;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaEmpleados);
                writer.Write(jsonContent);
            }
        }
    }
}
