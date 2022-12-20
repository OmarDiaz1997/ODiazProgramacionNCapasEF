using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        static public void Add()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingrese los datos del usuario al sistema");
            Console.WriteLine("Ingrese el nombre de usuario: ");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del usuario: ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido paterno del usuario: ");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido materno del usuario: ");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingrese el email: ");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Ingrese password: ");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de nacimiento: ");
            usuario.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("Ingrese su sexo: ");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono: ");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Ingrese su celular: ");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("Ingrese CURP: ");
            usuario.CURP = Console.ReadLine();
            //Inicializar metodo Rol con el objeto usuario
            usuario.Rol = new ML.Rol();
            Console.WriteLine("Ingrese Rol: ");
            usuario.Rol.IdRol = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su direccion completa ");
            //Inicializar metodo Direccion con el objeto usuario
            usuario.Direccion = new ML.Direccion();
            Console.WriteLine("Nombre de la calle: ");
            usuario.Direccion.Calle = Console.ReadLine();
            Console.WriteLine("Numero interior: ");
            usuario.Direccion.NumeroInterior = Console.ReadLine();
            Console.WriteLine("Numero exterior: ");
            usuario.Direccion.NumeroExterior = Console.ReadLine();
            //Inicializar metodo Colonia con el objeto usuario
            usuario.Direccion.Colonia = new ML.Colonia();
            Console.WriteLine("Id colonia: ");
            usuario.Direccion.Colonia.IdColonia = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.AddSPEF(usuario);
            if (result.Correct == true)
            {
                Console.WriteLine("Usuario Intsertado Correctamente");
            }
            else
            {
                Console.WriteLine("Ocurrio un error al instertar el usuario" + result.ErrorMessage);
            }
        }




        static public void Update()
        {
            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Ingrese los datos a actualizar");
            Console.WriteLine("Ingrese el ID del usuario: ");
            usuario.IdUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo nombre de usuario: ");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo nomnre del usuario: ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo apellido paterno del usuario: ");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo apellido materno del usuario: ");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo Email: ");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva password: ");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva fecha de nacimiento: ");
            usuario.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo sexo: ");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo telefono: ");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo celular: ");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo CURP: ");
            usuario.CURP = Console.ReadLine();
            usuario.Rol = new ML.Rol();
            Console.WriteLine("Ingrese el ID del rol: ");
            usuario.Rol.IdRol = int.Parse(Console.ReadLine());
            usuario.Direccion = new ML.Direccion();
            Console.WriteLine("Ingrese la calle: ");
            usuario.Direccion.Calle = Console.ReadLine();
            Console.WriteLine("Ingrese numero interior: ");
            usuario.Direccion.NumeroInterior = Console.ReadLine();
            Console.WriteLine("Ingrese numero exterior: ");
            usuario.Direccion.NumeroExterior = Console.ReadLine();
            usuario.Direccion.Colonia = new ML.Colonia();
            Console.WriteLine("Ingrese la IdColonia: ");
            usuario.Direccion.Colonia.IdColonia = int.Parse(Console.ReadLine());

            //BL.Usuario.UdateSPEF(usuario);

            ML.Result result = BL.Usuario.UdateSPEF(usuario);
            if (result.Correct == true)
            {
                Console.WriteLine("Usuario actualizado Correctamente");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ocurrio un error al actualizar el usuario" + result.ErrorMessage);
                Console.ReadLine();
            }
        }




        static public void Delete()
        {

            Console.WriteLine("Eliminar ususario del sistema");
            Console.WriteLine("Ingrese el ID del ususario: ");
            int IdUsuario = int.Parse(Console.ReadLine());

            BL.Usuario.DeleteSP(IdUsuario);
        }



        static public void GetAll()
        {
            ML.Result result = BL.Usuario.GetAllSP();

            if (result.Correct)
            {
                foreach (ML.Usuario usuario in result.Objects)
                {
                    Console.WriteLine("El ID del usuario es: " + usuario.IdUsuario);
                    Console.WriteLine("El nombre de usuario es: " + usuario.UserName);
                    Console.WriteLine("El nombre del usuario es: " + usuario.Nombre);
                    Console.WriteLine("El apellido paterno del usuario es: " + usuario.ApellidoPaterno);
                    Console.WriteLine("El apellido materno del usuario es: " + usuario.ApellidoMaterno);
                    Console.WriteLine("El Email es: " + usuario.Email);
                    Console.WriteLine("El password es: " + usuario.Password);
                    Console.WriteLine("El fecha de nacimiento es: " + usuario.FechaNacimiento);
                    Console.WriteLine("El sexo es: " + usuario.Sexo);
                    Console.WriteLine("El Telefono es: " + usuario.Telefono);
                    Console.WriteLine("El Telefono celular es: " + usuario.Celular);
                    Console.WriteLine("El CURP es: " + usuario.CURP);
                    Console.WriteLine("El rol es: " + usuario.Rol.Nombre);
                    Console.WriteLine("------ Direción -------");
                    Console.WriteLine("Calle: " + usuario.Direccion.Calle);
                    Console.WriteLine("Numero interior: " + usuario.Direccion.NumeroInterior);
                    Console.WriteLine("Numero exterior: " + usuario.Direccion.NumeroExterior);
                    Console.WriteLine("Colonia: " + usuario.Direccion.Colonia.Nombre);
                    Console.WriteLine("Municipio: " + usuario.Direccion.Colonia.Municipio.Nombre);
                    Console.WriteLine("Estado: " + usuario.Direccion.Colonia.Municipio.Estado.Nombre);
                    Console.WriteLine("Pais: " + usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre);
                    Console.WriteLine("-----------------------------------------------------------------------");
                }

            }
            else
            {
                Console.WriteLine("Ocurrio un error " + result.ErrorMessage);
            }


        }




        static public void GetById()
        {
            Console.WriteLine("Buscar Usuario por ID");
            Console.WriteLine("Ingrese el ID del ususario: ");
            int IdProducto = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.GetByIdEF(IdProducto);

            if (result.Correct)
            {
                ML.Usuario usuario = (ML.Usuario)result.Object;  //Unboxing
                Console.WriteLine("El ID del usuario es: " + usuario.IdUsuario);
                Console.WriteLine("El nombre de usuario es: " + usuario.UserName);
                Console.WriteLine("El nombre del usuario es: " + usuario.Nombre);
                Console.WriteLine("El apellido paterno del usuario es: " + usuario.ApellidoPaterno);
                Console.WriteLine("El apellido materno del usuario es: " + usuario.ApellidoMaterno);
                Console.WriteLine("El Email es: " + usuario.Email);
                Console.WriteLine("El password es: " + usuario.Password);
                Console.WriteLine("La fecha de nacimiento es: " + usuario.FechaNacimiento);
                Console.WriteLine("El sexo es: " + usuario.Sexo);
                Console.WriteLine("El telefono es: " + usuario.Telefono);
                Console.WriteLine("El celular es: " + usuario.Celular);
                Console.WriteLine("El CURP es: " + usuario.CURP);
                Console.WriteLine("El rol es: " + usuario.Rol.Nombre);
                Console.WriteLine("------ Direción -------");
                Console.WriteLine("Calle: " + usuario.Direccion.Calle);
                Console.WriteLine("Numero interior: " + usuario.Direccion.NumeroInterior);
                Console.WriteLine("Numero exterior: " + usuario.Direccion.NumeroExterior);
                Console.WriteLine("Colonia: " + usuario.Direccion.Colonia.Nombre);
                Console.WriteLine("Municipio: " + usuario.Direccion.Colonia.Municipio.Nombre);
                Console.WriteLine("Estado: " + usuario.Direccion.Colonia.Municipio.Estado.Nombre);
                Console.WriteLine("Pais: " + usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre);
                Console.WriteLine("--------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Ocurrio un error " + result.ErrorMessage);
            }
        }



        //static public void AddSP()
        //{
        //    ML_EF.Usuario usuario = new ML_EF.Usuario();

        //    Console.WriteLine("Ingrese los datos del ususario al sistema");
        //    Console.WriteLine("Ingrese el nombre de ususario: ");
        //    usuario.UserName = Console.ReadLine();
        //    Console.WriteLine("Ingrese su nombre: ");
        //    usuario.Nombre = Console.ReadLine();
        //    Console.WriteLine("Ingrese su apellido paterno: ");
        //    usuario.ApellidoPaterno = Console.ReadLine();
        //    Console.WriteLine("Ingrese su apellido materno: ");
        //    usuario.ApellidoMaterno = Console.ReadLine();
        //    Console.WriteLine("Ingrese su Email: ");
        //    usuario.Email = Console.ReadLine();
        //    Console.WriteLine("Ingrese su password: ");
        //    usuario.Password = Console.ReadLine();
        //    Console.WriteLine("Ingrese su fecha de nacimiento: ");
        //    usuario.FechaNacimiento = Console.ReadLine();
        //    Console.WriteLine("Ingrese su Sexo: ");
        //    usuario.Sexo = Console.ReadLine();
        //    Console.WriteLine("Ingrese su telefono: ");
        //    usuario.Telefono = Console.ReadLine();
        //    Console.WriteLine("Ingrese su celular: ");
        //    usuario.Celular = Console.ReadLine();
        //    Console.WriteLine("Ingrese su CURP: ");
        //    usuario.CURP = Console.ReadLine();
        //    Console.WriteLine("Ingrese su grado: ");
        //    usuario.Grado = byte.Parse(Console.ReadLine());

        //    BL_EF.Usuario.AddSP(usuario);
        //}
    }
}
