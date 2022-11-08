using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNet
{
    public class Principal
    {
        //Listas
        List<Cliente> ListaClientes = new List<Cliente>();
        List<Proveedor> ListaProveedor = new List<Proveedor>();
        List<Producto> ListaProductos = new List<Producto>();
        List<Empleado> ListaEmpleados = new List<Empleado>();

        PersistenciaDato persistencia = new PersistenciaDato();
        //Metodos

        //Alta cliente
        public void AltaCliente(Cliente clienteNuevo, int idcliente)
        {
            ListaClientes = ValidarCliente();

            Cliente nuevoCliente = new Cliente();
            nuevoCliente.dni = clienteNuevo.dni;
            nuevoCliente.cuil = clienteNuevo.cuil;
            nuevoCliente.nombre = clienteNuevo.nombre;
            nuevoCliente.apellido = clienteNuevo.apellido;
            nuevoCliente.direccion = clienteNuevo.direccion;
            nuevoCliente.email = clienteNuevo.email;
            nuevoCliente.idCliente = idcliente;

            ListaClientes.Add(nuevoCliente);
            InstanciaPersistenciaDatos.GuardarArchivoCliente(ListaClientes);
        }

        
        //Alta proveedor  

        public void AltaProveedor(Proveedor proveedorNuevo, int idproveedor)
        {
            ListaProveedor = ValidarProveedor();

            Proveedor nuevoProveedor = new Proveedor();
            nuevoProveedor.dni = proveedorNuevo.dni;
            nuevoProveedor.cuil = proveedorNuevo.cuil;
            nuevoProveedor.nombre = proveedorNuevo.nombre;
            nuevoProveedor.apellido = proveedorNuevo.apellido;
            nuevoProveedor.direccion = proveedorNuevo.direccion;
            nuevoProveedor.email = proveedorNuevo.email;
            nuevoProveedor.idProveedor = idproveedor;

            ListaProveedor.Add(nuevoProveedor);
            InstanciaPersistenciaDatos.GuardarArchivoProveedor(ListaProveedor);
        }

        //Alta producto        
        public void AltaProducto(Producto productoNuevo, int idproducto)
        {
            ListaProductos = ValidarProducto();

            Producto nuevoProducto = new Producto();
            nuevoProducto.precio = productoNuevo.precio;
            nuevoProducto.nombreProd = productoNuevo.nombreProd;
            nuevoProducto.cantidad = productoNuevo.cantidad;
            nuevoProducto.descripcion = productoNuevo.descripcion;
            nuevoProducto.color = productoNuevo.color;
            nuevoProducto.material = productoNuevo.material;
            nuevoProducto.idProducto = idproducto;

            ListaProductos.Add(nuevoProducto);
            InstanciaPersistenciaDatos.GuardarArchivoProducto(ListaProductos);
        }

        //Alta empleado       
        public void AltaEmpleado(Empleado empleadoNuevo, int idempleado)
        {
            ListaEmpleados = ValidarEmpleado();

            Empleado nuevoEmpleado = new Empleado();
            nuevoEmpleado.dni = empleadoNuevo.dni;
            nuevoEmpleado.cuil = empleadoNuevo.cuil;
            nuevoEmpleado.nombre = empleadoNuevo.nombre;
            nuevoEmpleado.apellido = empleadoNuevo.apellido;
            nuevoEmpleado.direccion = empleadoNuevo.direccion;
            nuevoEmpleado.email = empleadoNuevo.email;
            nuevoEmpleado.sueldo = empleadoNuevo.sueldo;
            nuevoEmpleado.idEmpleado = idempleado;

            ListaEmpleados.Add(nuevoEmpleado);
            InstanciaPersistenciaDatos.GuardarArchivoEmpleados(ListaEmpleados);
        }

        //Baja cliente
        public void BajaCliente(int idCliente)
        {
            ListaClientes = ValidarCliente();
            var clienteEliminado = ListaClientes.Find(x => idCliente == x.idCliente);
            ListaClientes.Remove(clienteEliminado);
            InstanciaPersistenciaDatos.GuardarArchivoCliente(ListaClientes);
        }

        //Baja proveedor
        public void BajaProveedor(int idProveedor)
        {
            ListaProveedor = ValidarProveedor();
            var proveedorEliminado = ListaProveedor.Find(x => idProveedor == x.idProveedor);
            ListaProveedor.Remove(proveedorEliminado);
            InstanciaPersistenciaDatos.GuardarArchivoProveedor(ListaProveedor);
        }

        //Baja producto
        public void BajaProducto(int idProducto)
        {
            ListaProductos = ValidarProducto();
            var productoEliminado = ListaProductos.Find(x => idProducto == x.idProducto);
            ListaProductos.Remove(productoEliminado);
            InstanciaPersistenciaDatos.GuardarArchivoProducto(ListaProductos);
        }

        //Baja empleado 
        public void BajaEmpleado(int idEmpleado)
        {
            ListaEmpleados = ValidarEmpleado();
            var empleadoEliminado = ListaEmpleados.Find(x => idEmpleado == x.idEmpleado);
            ListaEmpleados.Remove(empleadoEliminado);
            InstanciaPersistenciaDatos.GuardarArchivoEmpleados(ListaEmpleados);
        }

        //Modificar cliente
        public void ModificarCliente(Cliente nuevoCliente, int idCliente)
        {
            var ClienteModificado = ListaClientes.Find(x => idCliente == x.idCliente);


            ClienteModificado.dni = nuevoCliente.dni;
            ClienteModificado.cuil = nuevoCliente.cuil;
            ClienteModificado.nombre = nuevoCliente.nombre;
            ClienteModificado.apellido = nuevoCliente.apellido;
            ClienteModificado.direccion = nuevoCliente.direccion;
            ClienteModificado.email = nuevoCliente.email;
            ClienteModificado.idCliente = idCliente;

            var clienteEliminado = ListaClientes.Find(x => idCliente == x.idCliente);
            ListaClientes.Remove(clienteEliminado);
            ListaClientes.Add(ClienteModificado);
            InstanciaPersistenciaDatos.GuardarArchivoCliente(ListaClientes);
        }

        //Modificar proveedor
        public void ModificarProveedor(Proveedor nuevoProveedor, int idProveedor)
        {
            var ProveedorModificado = ListaProveedor.Find(x => idProveedor == x.idProveedor);


            ProveedorModificado.dni = nuevoProveedor.dni;
            ProveedorModificado.cuil = nuevoProveedor.cuil;
            ProveedorModificado.nombre = nuevoProveedor.nombre;
            ProveedorModificado.apellido = nuevoProveedor.apellido;
            ProveedorModificado.direccion = nuevoProveedor.direccion;
            ProveedorModificado.email = nuevoProveedor.email;
            ProveedorModificado.idProveedor = idProveedor;

            var proveedorEliminado = ListaProveedor.Find(x => idProveedor == x.idProveedor);
            ListaProveedor.Remove(proveedorEliminado);
            ListaProveedor.Add(ProveedorModificado);
            InstanciaPersistenciaDatos.GuardarArchivoProveedor(ListaProveedor);
        }

        //Modificar producto
        public void ModificarProducto(Producto nuevoProducto, int idProducto)
        {
            var ProductoModificado = ListaProductos.Find(x => idProducto == x.idProducto);


            ProductoModificado.precio = nuevoProducto.precio;
            ProductoModificado.nombreProd = nuevoProducto.nombreProd;
            ProductoModificado.cantidad = nuevoProducto.cantidad;
            ProductoModificado.descripcion = nuevoProducto.descripcion;
            ProductoModificado.color = nuevoProducto.color;
            ProductoModificado.material = nuevoProducto.material;
            ProductoModificado.idProducto = idProducto;

            var productoEliminado = ListaProductos.Find(x => idProducto == x.idProducto);
            ListaProductos.Remove(productoEliminado);
            ListaProductos.Add(ProductoModificado);
            InstanciaPersistenciaDatos.GuardarArchivoProducto(ListaProductos);
        }

        //Modificar empleado
        public void ModificarEmpleado(Empleado nuevoEmpleado, int idEmpleado)
        {
            var EmpleadoModificado = ListaEmpleados.Find(x => idEmpleado == x.idEmpleado);


            EmpleadoModificado.dni = nuevoEmpleado.dni;
            EmpleadoModificado.cuil = nuevoEmpleado.cuil;
            EmpleadoModificado.nombre = nuevoEmpleado.nombre;
            EmpleadoModificado.apellido = nuevoEmpleado.apellido;
            EmpleadoModificado.direccion = nuevoEmpleado.direccion;
            EmpleadoModificado.email = nuevoEmpleado.email;
            EmpleadoModificado.sueldo = nuevoEmpleado.sueldo;
            EmpleadoModificado.idEmpleado = idEmpleado;

            var empleadoEliminado = ListaEmpleados.Find(x => idEmpleado == x.idEmpleado);
            ListaEmpleados.Remove(empleadoEliminado);
            ListaEmpleados.Add(EmpleadoModificado);
            InstanciaPersistenciaDatos.GuardarArchivoEmpleados(ListaEmpleados);
        }

        //Persistencia de datos
        PersistenciaDato InstanciaPersistenciaDatos = new PersistenciaDato();
        public void RellenarLista()
        {
            ListaClientes = InstanciaPersistenciaDatos.LeerArchivoCliente();
            ListaProveedor = InstanciaPersistenciaDatos.LeerArchivoProveedor();
            ListaProductos = InstanciaPersistenciaDatos.LeerArchivoProducto();
            ListaEmpleados = InstanciaPersistenciaDatos.LeerArchivoEmpleado();
        }

        //Validacion cliente
        public List<Cliente> ValidarCliente()
        {
            ListaClientes = InstanciaPersistenciaDatos.LeerArchivoCliente();
            if (ListaClientes == null)
            {
                ListaClientes = new List<Cliente>();
            }

            return ListaClientes;

        }

        //Validacion producto
        public List<Producto> ValidarProducto()
        {
            ListaProductos = InstanciaPersistenciaDatos.LeerArchivoProducto();
            if (ListaProductos == null)
            {
                ListaProductos = new List<Producto>();
            }

            return ListaProductos;

        }

        //Validacion proveedor
        public List<Proveedor> ValidarProveedor()
        {
            ListaProveedor = InstanciaPersistenciaDatos.LeerArchivoProveedor();
            if (ListaProveedor == null)
            {
                ListaProveedor = new List<Proveedor>();
            }

            return ListaProveedor;

        }

        //Validacion empleado
        public List<Empleado> ValidarEmpleado()
        {
            ListaEmpleados = InstanciaPersistenciaDatos.LeerArchivoEmpleado();
            if (ListaEmpleados == null)
            {
                ListaEmpleados = new List<Empleado>();
            }

            return ListaEmpleados;

        }

        //Busqueda

        // Proveedor por ID

        public List<Proveedor> BuscarProveedorPorID(int idproveedor)
        {
            ListaProveedor = ValidarProveedor();
            List<Proveedor> NuevaListaProveedor = new List<Proveedor>();

            if (ListaProveedor == null)
            {
                return NuevaListaProveedor;
            }
            else
            {
                var ProveedorObtenido = ListaProveedor.Find(x => idproveedor == x.idProveedor);
                NuevaListaProveedor.Add(ProveedorObtenido);
                return NuevaListaProveedor;
            }
        }

        //Empleado por ID
        public List<Empleado> BuscarEmpleadoPorID(int idempleado)
        {
            ListaEmpleados = ValidarEmpleado();
            List<Empleado> NuevaListaEmpleado = new List<Empleado>();

            if (ListaEmpleados == null)
            {
                return NuevaListaEmpleado;
            }
            else
            {
                var EmpleadoObtenido = ListaEmpleados.Find(x => idempleado == x.idEmpleado);
                NuevaListaEmpleado.Add(EmpleadoObtenido);
                return NuevaListaEmpleado;
            }
        }

        // Cliente por ID

        public List<Cliente> BuscarClientePorID(int idcliente)
        {
            ListaClientes = ValidarCliente();
            List<Cliente> NuevaListaCliente = new List<Cliente>();

            if (ListaClientes == null)
            {
                return NuevaListaCliente;
            }
            else
            {
                var ClienteObtenido = ListaClientes.Find(x => idcliente == x.idCliente);
                NuevaListaCliente.Add(ClienteObtenido);
                return NuevaListaCliente;
            }
        }

        // producto por ID

        public List<Producto> BuscarProductoPorID(int idproducto)
        {
            ListaProductos = ValidarProducto();
            List<Producto> NuevaListaProducto = new List<Producto>();

            if (ListaProductos == null)
            {
                return NuevaListaProducto;
            }
            else
            {
                var ProductoObtenido = ListaProductos.Find(x => idproducto == x.idProducto);
                NuevaListaProducto.Add(ProductoObtenido);
                return NuevaListaProducto;
            }
        }

        //Busqueda por Nombre

        // Proveedor por Nombre

        public List<Proveedor> BuscarProveedorPorDNI(string nombreproveedor)
        {
            ListaProveedor = ValidarProveedor();
            List<Proveedor> NuevaListaProveedor = new List<Proveedor>();

            if (ListaProveedor == null)
            {
                return NuevaListaProveedor;
            }
            else
            {
                var ProveedorObtenido = ListaProveedor.Find(x => nombreproveedor == x.nombre);
                NuevaListaProveedor.Add(ProveedorObtenido);
                return NuevaListaProveedor;
            }
        }

        //Empleado por Nombre
        public List<Empleado> BuscarEmpleadoPorDNI(string nombreempleado)
        {
            ListaEmpleados = ValidarEmpleado();
            List<Empleado> NuevaListaEmpleado = new List<Empleado>();

            if (ListaEmpleados == null)
            {
                return NuevaListaEmpleado;
            }
            else
            {
                var EmpleadoObtenido = ListaEmpleados.Find(x => nombreempleado == x.nombre);
                NuevaListaEmpleado.Add(EmpleadoObtenido);
                return NuevaListaEmpleado;
            }
        }

        // Cliente por Nombre

        public List<Cliente> BuscarClientePorDNI(string nombrecliente)
        {
            ListaClientes = ValidarCliente();
            List<Cliente> NuevaListaCliente = new List<Cliente>();

            if (ListaClientes == null)
            {
                return NuevaListaCliente;
            }
            else
            {
                var ClienteObtenido = ListaClientes.Find(x => nombrecliente == x.nombre);
                NuevaListaCliente.Add(ClienteObtenido);
                return NuevaListaCliente;
            }
        }

        // producto por Nombre

        public List<Producto> BuscarProductoPorNombre(string nombreprod)
        {
            ListaProductos = ValidarProducto();
            List<Producto> NuevaListaProducto = new List<Producto>();

            if (ListaProductos == null)
            {
                return NuevaListaProducto;
            }
            else
            {
                var ProductoObtenido = ListaProductos.Find(x => nombreprod == x.nombreProd);
                NuevaListaProducto.Add(ProductoObtenido);
                return NuevaListaProducto;
            }
        }
    }
}
