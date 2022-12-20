using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace BL
{
    public class Producto
    {
        static public ML.Result GetAllSP()
        {
            ML.Result result = new ML.Result();
            try
            {

                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var query = context.ProductoGetAll().ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var objProducto in query)
                        {
                            ML.Producto producto = new ML.Producto();
                            producto.IdProducto = objProducto.IdProducto;
                            producto.Nombre = objProducto.NombreProducto;
                            producto.PrecioUnitario = objProducto.PrecioUnitario;
                            producto.Stock = objProducto.Stock;
                            producto.Descripcion = objProducto.Descripcion;
                            producto.Proveedor = new ML.Proveedor();
                            //producto.Proveedor.IdProveedor = objProducto.IdProveedor;
                            producto.Proveedor.Nombre = objProducto.NombreProveedor;
                            producto.Proveedor.Telefono = objProducto.Telefono;
                            producto.Departamento = new ML.Departamento();
                            //producto.Departamento.IdDepartamento = objProducto.IdDepartamento;
                            producto.Departamento.Nombre = objProducto.NombreDepartamento;
                            producto.Departamento.Area = new ML.Area();
                            //  producto.Departamento.Area.IdArea = objProducto.IdArea;
                            producto.Departamento.Area.Nombre = objProducto.NombreArea;

                            result.Objects.Add(producto);
                        }
                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No contiene registros la tabla Producto";
                    }

                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }






        static public ML.Result GetByIdEF(int IdProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var objProducto = context.ProductoGetByID(IdProducto).Single();

                    if (objProducto != null)
                    {
                        ML.Producto producto = new ML.Producto();
                        producto.IdProducto = objProducto.IdProducto;
                        producto.Nombre = objProducto.NombreProducto;
                        producto.PrecioUnitario = objProducto.PrecioUnitario;
                        producto.Stock = objProducto.Stock;
                        producto.Descripcion = objProducto.Descripcion;
                        producto.Proveedor = new ML.Proveedor();
                        producto.Proveedor.Nombre = objProducto.NombreProveedor;
                        producto.Proveedor.Telefono = objProducto.Telefono;
                        producto.Departamento = new ML.Departamento();
                        producto.Departamento.Nombre = objProducto.NombreDepartamento;
                        producto.Departamento.Area = new ML.Area();
                        producto.Departamento.Area.Nombre = objProducto.NombreArea;

                        result.Object = producto;

                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No contiene registros la tabla producto";
                    }

                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }






        static public ML.Result AddSPEF(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var query = context.ProductoAdd(producto.Nombre,producto.PrecioUnitario,producto.Stock,producto.Descripcion,producto.Proveedor.IdProveedor,producto.Departamento.IdDepartamento);

                    if (query > 0)
                    {
                        result.Correct = true;
                        //Console.WriteLine();
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al insertar el producto";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }







        static public ML.Result DeleteSP(int IdProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var query = context.ProductoDelete(IdProducto);
                    if (query > 0)
                    {
                        result.Correct=true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al eliminar";
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }





        static public ML.Result UdateSPEF(ML.Producto usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var query = context.ProductoUpdate(usuario.IdProducto, usuario.Nombre, usuario.PrecioUnitario, usuario.Stock, usuario.Descripcion, usuario.Proveedor.IdProveedor, usuario.Departamento.IdDepartamento);

                    if (query > 0)
                    {
                        Console.WriteLine("Producto actualizado");
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al actualizar";
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }








        /*    SERVICIO WCF    */

        static public ML.Result Add(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var query = context.ProductoAdd(producto.Nombre, producto.PrecioUnitario, producto.Stock, producto.Descripcion, producto.Proveedor.IdProveedor, producto.Departamento.IdDepartamento);

                    if (query > 0)
                    {
                        result.Correct = true;
                        //Console.WriteLine();
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al insertar el producto";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }






        static public ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {

                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var query = context.ProductoGetAll().ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var objProducto in query)
                        {
                            ML.Producto producto = new ML.Producto();
                            producto.IdProducto = objProducto.IdProducto;
                            producto.Nombre = objProducto.NombreProducto;
                            producto.PrecioUnitario = objProducto.PrecioUnitario;
                            producto.Stock = objProducto.Stock;
                            producto.Descripcion = objProducto.Descripcion;
                            producto.Proveedor = new ML.Proveedor();
                            //producto.Proveedor.IdProveedor = objProducto.IdProveedor;
                            producto.Proveedor.Nombre = objProducto.NombreProveedor;
                            producto.Proveedor.Telefono = objProducto.Telefono;
                            producto.Departamento = new ML.Departamento();
                            //producto.Departamento.IdDepartamento = objProducto.IdDepartamento;
                            producto.Departamento.Nombre = objProducto.NombreDepartamento;
                            producto.Departamento.Area = new ML.Area();
                            //  producto.Departamento.Area.IdArea = objProducto.IdArea;
                            producto.Departamento.Area.Nombre = objProducto.NombreArea;

                            result.Objects.Add(producto);
                        }
                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No contiene registros la tabla Producto";
                    }

                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }





        static public ML.Result GetById(int IdProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var objProducto = context.ProductoGetByID(IdProducto).Single();

                    if (objProducto != null)
                    {
                        ML.Producto producto = new ML.Producto();
                        producto.IdProducto = objProducto.IdProducto;
                        producto.Nombre = objProducto.NombreProducto;
                        producto.PrecioUnitario = objProducto.PrecioUnitario;
                        producto.Stock = objProducto.Stock;
                        producto.Descripcion = objProducto.Descripcion;
                        producto.Proveedor = new ML.Proveedor();
                        producto.Proveedor.Nombre = objProducto.NombreProveedor;
                        producto.Proveedor.Telefono = objProducto.Telefono;
                        producto.Departamento = new ML.Departamento();
                        producto.Departamento.Nombre = objProducto.NombreDepartamento;
                        producto.Departamento.Area = new ML.Area();
                        producto.Departamento.Area.Nombre = objProducto.NombreArea;

                        result.Object = producto;

                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No contiene registros la tabla producto";
                    }

                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }




        static public ML.Result Update(ML.Producto usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var query = context.ProductoUpdate(usuario.IdProducto, usuario.Nombre, usuario.PrecioUnitario, usuario.Stock, usuario.Descripcion, usuario.Proveedor.IdProveedor, usuario.Departamento.IdDepartamento);

                    if (query > 0)
                    {
                        Console.WriteLine("Producto actualizado");
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al actualizar";
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }



        static public ML.Result Delete(int IdProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var query = context.ProductoDelete(IdProducto);
                    if (query > 0)
                    {
                        Console.WriteLine("Producto eliminado");
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al eliminar";
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

    }
}
