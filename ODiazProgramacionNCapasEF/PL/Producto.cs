using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Producto
    {
        static public void Add()
        {
            ML.Producto producto = new ML.Producto();

            Console.WriteLine("Ingrese los datos del producto al sistema");
            Console.WriteLine("Ingrese el nombre del producto: ");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio unitario: ");
            producto.PrecioUnitario = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el stock actual: ");
            producto.Stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Descripcion del producto: ");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese el proveedor: ");
            producto.Proveedor = new ML.Proveedor();
            producto.Proveedor.IdProveedor = int.Parse(Console.ReadLine());
            producto.Departamento = new ML.Departamento();
            Console.WriteLine("Ingrese el departamento: ");
            producto.Departamento.IdDepartamento = int.Parse(Console.ReadLine());

            ML.Result result = BL.Producto.AddSPEF(producto);
            if (result.Correct)
            {
                Console.WriteLine("Producto Intsertado Correctamente");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ocurrio un error al instertar el Producto" + result.ErrorMessage);
                Console.ReadLine();
            }
        }




        static public void Delete()
        {

            Console.WriteLine("Eliminar producto del sistema");
            Console.WriteLine("Ingrese el ID del ususario: ");
            int IdProducto = int.Parse(Console.ReadLine());

            BL.Producto.DeleteSP(IdProducto);
        }




        static public void GetAll()
        {
            ML.Result result = BL.Producto.GetAllSP();

            if (result.Correct)
            {
                foreach (ML.Producto producto in result.Objects)
                {
                    Console.WriteLine("El ID del producto: " + producto.IdProducto);
                    Console.WriteLine("Producto: " + producto.Nombre);
                    Console.WriteLine("Precio unitario: " + producto.PrecioUnitario);
                    Console.WriteLine("Stock: " + producto.Stock);
                    Console.WriteLine("Descripcion: " + producto.Descripcion);
                    Console.WriteLine("-------------Proveedor-------------");
                    Console.WriteLine("Nombre: " + producto.Proveedor.Nombre);
                    Console.WriteLine("Telefono: " + producto.Proveedor.Telefono);
                    Console.WriteLine("------------Departamento------------");
                    Console.WriteLine("Nombre: " + producto.Departamento.Nombre);
                    Console.WriteLine("----------------Area----------------");
                    Console.WriteLine("Area: " + producto.Departamento.Area.Nombre);
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("Ocurrio un error " + result.ErrorMessage);
            }


        }




        static public void GetById()
        {
            Console.WriteLine("Buscar producto por ID");
            Console.WriteLine("Ingrese el ID del producto: ");
            int IdProducto = int.Parse(Console.ReadLine());

            ML.Result result = BL.Producto.GetByIdEF(IdProducto);

            if (result.Correct)
            {
                ML.Producto producto = (ML.Producto)result.Object;  //Unboxing
                Console.WriteLine("El ID del producto: " + producto.IdProducto);
                Console.WriteLine("Producto: " + producto.Nombre);
                Console.WriteLine("Precio unitario: " + producto.PrecioUnitario);
                Console.WriteLine("Stock: " + producto.Stock);
                Console.WriteLine("Descripción: " + producto.Descripcion);
                Console.WriteLine("Proveedor: " + producto.Proveedor.Nombre);
                Console.WriteLine("Telefono: " + producto.Proveedor.Telefono);
                Console.WriteLine("Departamento: " + producto.Departamento.Nombre);
                Console.WriteLine("Area: " + producto.Departamento.Area.Nombre);
                Console.WriteLine("--------------------------------------------------------------------");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ocurrio un error " + result.ErrorMessage);
            }
        }





        static public void Update()
        {
            ML.Producto producto = new ML.Producto();
            Console.WriteLine("Ingrese los datos a actualizar");
            Console.WriteLine("Ingrese el ID del producto: ");
            producto.IdProducto = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombre: ");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Precio unitario: ");
            producto.PrecioUnitario = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Stock: ");
            producto.Stock = int.Parse(Console.ReadLine());
            Console.WriteLine("Descripción: ");
            producto.Descripcion = Console.ReadLine();
            producto.Proveedor = new ML.Proveedor();
            Console.WriteLine("Proveedor: ");
            producto.Proveedor.IdProveedor = int.Parse(Console.ReadLine());
            producto.Departamento = new ML.Departamento();
            Console.WriteLine("Departamento: ");
            producto.Departamento.IdDepartamento = int.Parse(Console.ReadLine());

            ML.Result result = BL.Producto.UdateSPEF(producto);
            if (result.Correct)
            {
                Console.WriteLine("Usuario actualizado Correctamente");
            }
            else
            {
                Console.WriteLine("Ocurrio un error al actualizar el usuario" + result.ErrorMessage);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

    }
}
