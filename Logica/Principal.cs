using Bazar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {
        //Listas
        List<Cliente> ListaClientes = new List<Cliente>();
        List<Proveedor> ListaProveedor = new List<Proveedor>();
        List<Producto> ListaProducto = new List<Producto>();
        List<Empleado> ListaEmpleado = new List<Empleado>();

        //Metodos

        //Alta cliente
        public void AltaCliente(Cliente clienteNuevo, int idcliente)
        {
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.dni = clienteNuevo.dni;
            nuevoCliente.cuil = clienteNuevo.cuil;
            nuevoCliente.nombre = clienteNuevo.nombre;
            nuevoCliente.apellido = clienteNuevo.apellido;
            nuevoCliente.direccion = clienteNuevo.direccion;
            nuevoCliente.email = clienteNuevo.email;
            nuevoCliente.idCliente = idcliente;
            ListaClientes.Add(nuevoCliente);
        }

        //Alta proveedor  
        
        public void AltaProveedor(Proveedor proveedorNuevo, int idproveedor)
        {
            Proveedor nuevoProveedor = new Proveedor();
            nuevoProveedor.dni = proveedorNuevo.dni;
            nuevoProveedor.cuil = proveedorNuevo.cuil;
            nuevoProveedor.nombre = proveedorNuevo.nombre;
            nuevoProveedor.apellido = proveedorNuevo.apellido;
            nuevoProveedor.direccion = proveedorNuevo.direccion;
            nuevoProveedor.email = proveedorNuevo.email;
            nuevoProveedor.idProveedor = idproveedor;
            ListaProveedor.Add(nuevoProveedor);
        }

        //Alta producto        
        public void AltaProducto(Producto productoNuevo, int idproducto)
        {
            Producto nuevoProducto = new Producto();
            nuevoProducto.precio = productoNuevo.precio;
            nuevoProducto.cantidad = productoNuevo.cantidad;
            nuevoProducto.descripcion = productoNuevo.descripcion;
            nuevoProducto.color = productoNuevo.color;
            nuevoProducto.material = productoNuevo.material;
            nuevoProducto.idProducto = idproducto;
            ListaProducto.Add(nuevoProducto);
        }

        //Alta empleado       
        public void AltaEmpleado(Empleado empleadoNuevo, int idempleado)
        {
            Empleado nuevoEmpleado = new Empleado();
            nuevoEmpleado.dni = empleadoNuevo.dni;
            nuevoEmpleado.cuil = empleadoNuevo.cuil;
            nuevoEmpleado.nombre = empleadoNuevo.nombre;
            nuevoEmpleado.apellido = empleadoNuevo.apellido;
            nuevoEmpleado.direccion = empleadoNuevo.direccion;
            nuevoEmpleado.email = empleadoNuevo.email;
            nuevoEmpleado.sueldo = empleadoNuevo.sueldo;
            nuevoEmpleado.idEmpleado = idempleado;
            ListaEmpleado.Add(nuevoEmpleado);
        }

        //Baja cliente
        public void BajaCliente(int idCliente)
        {
            var clienteEliminado = ListaClientes.Find(x => idCliente == x.idCliente);
            ListaClientes.Remove(clienteEliminado); 
        }

        //Baja proveedor
        public void BajaProveedor(int idProveedor)
        {
            var proveedorEliminado = ListaProveedor.Find(x => idProveedor == x.idProveedor);
            ListaProveedor.Remove(proveedorEliminado);
        }

        //Baja producto
        public void BajaProducto(int idProducto)
        {
            var productoEliminado = ListaProducto.Find(x => idProducto == x.idProducto);
            ListaProducto.Remove(productoEliminado);
        }

        //Baja empleado 
        public void BajaEmpleado(int idEmpleado)
        {
            var empleadoEliminado = ListaEmpleado.Find(x => idEmpleado == x.idEmpleado);
            ListaEmpleado.Remove(empleadoEliminado);   
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
        }

        //Modificar producto
        public void ModificarProducto(Producto nuevoProducto, int idProducto)
        {
            var ProductoModificado = ListaProducto.Find(x => idProducto == x.idProducto);


            ProductoModificado.precio = nuevoProducto.precio;
            ProductoModificado.cantidad = nuevoProducto.cantidad;
            ProductoModificado.descripcion = nuevoProducto.descripcion;
            ProductoModificado.color = nuevoProducto.color;
            ProductoModificado.material = nuevoProducto.material;
            ProductoModificado.idProducto = idProducto;

            var productoEliminado = ListaProducto.Find(x => idProducto == x.idProducto);
            ListaProducto.Remove(productoEliminado);
            ListaProducto.Add(ProductoModificado);
        }

        //Modificar empleado
        public void ModificarEmpleado(Empleado nuevoEmpleado, int idEmpleado)
        {
            var EmpleadoModificado = ListaEmpleado.Find(x => idEmpleado == x.idEmpleado);


            EmpleadoModificado.dni = nuevoEmpleado.dni;
            EmpleadoModificado.cuil = nuevoEmpleado.cuil;
            EmpleadoModificado.nombre = nuevoEmpleado.nombre;
            EmpleadoModificado.apellido = nuevoEmpleado.apellido;
            EmpleadoModificado.direccion = nuevoEmpleado.direccion;
            EmpleadoModificado.email = nuevoEmpleado.email;
            EmpleadoModificado.sueldo = nuevoEmpleado.sueldo;
            EmpleadoModificado.idEmpleado = idEmpleado;

            var empleadoEliminado = ListaEmpleado.Find(x => idEmpleado == x.idEmpleado);
            ListaEmpleado.Remove(empleadoEliminado);
            ListaEmpleado.Add(EmpleadoModificado);
        }
    }
}

