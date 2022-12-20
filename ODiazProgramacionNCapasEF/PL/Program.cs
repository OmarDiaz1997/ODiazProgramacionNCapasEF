using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch
            int opcion = 0;
            int opcionDos = 0;
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Menu");
            Console.WriteLine("1.-Opciones de Usuario");
            Console.WriteLine("2.-Opciones de Producto");
            Console.WriteLine("Seleccionar una opción");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                ///Opciones de Usuario
                case 1:
                    Console.WriteLine("Opciones de Usuario");
                    Console.WriteLine("1.-Agregar usuario");
                    Console.WriteLine("2.-Actualizar usuario");
                    Console.WriteLine("3.-Eliminar usuario del sistema");
                    Console.WriteLine("4.-Consultar lista de todos los usuarios");
                    Console.WriteLine("5.-Consultar usuario por ID");
                    Console.WriteLine("Seleccionar una opción");
                    opcionDos = int.Parse(Console.ReadLine());
                    switch (opcionDos)
                    {
                        case 1:
                            PL.Usuario.Add();
                            break;
                        case 2:
                            PL.Usuario.Update();
                            break;
                        case 3:
                            PL.Usuario.Delete();
                            break;
                        case 4:
                            PL.Usuario.GetAll();
                            break;
                        case 5:
                            PL.Usuario.GetById();
                            break;
                    }
                    break;



                case 2:
                    Console.WriteLine("Opciones de Producto");
                    Console.WriteLine("1.-Agregar Producto");
                    Console.WriteLine("2.-Actualizar Producto");
                    Console.WriteLine("3.-Eliminar Producto del sistema");
                    Console.WriteLine("4.-Consultar lista de todos los Productos");
                    Console.WriteLine("5.-Consultar Producto por ID");
                    opcionDos = int.Parse(Console.ReadLine());
                    switch (opcionDos)
                    {
                        case 1:
                            PL.Producto.Add();
                            break;
                        case 2:
                            PL.Producto.Update();
                            break;
                        case 3:
                            PL.Producto.Delete();
                            break;
                        case 4:
                            PL.Producto.GetAll();
                            break;
                        case 5:
                            PL.Producto.GetById();
                            break;
                    }
                    break;
            }





        }
    }
}
