using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
namespace BL
{
    public class Usuario
    {
        //static public ML.Result Add(ML.Usuario usuario)
        // {
        //    ML.Result result = new ML.Result();
        //    try {
        //        using(SqlConnection context = new SqlConnection(DL.Conexion.Get())) 
        //        {
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.Connection = context;
        //            cmd.CommandText = "INSERT INTO [Usuario]([Nombre],[ApellidoPaterno],[ApellidoMaterno],[Grado])VALUES(@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Grado)";

        //            SqlParameter[] collection = new SqlParameter[4];
        //            collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //            collection[0].Value = usuario.Nombre;
        //            collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //            collection[1].Value = usuario.ApellidoPaterno;
        //            collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoMaterno;
        //            collection[3] = new SqlParameter("Grado", SqlDbType.TinyInt);
        //            collection[3].Value = usuario.Grado;

        //            cmd.Parameters.AddRange(collection);

        //            cmd.Connection.Open();

        //            int RowsAffected = cmd.ExecuteNonQuery();
        //            if (RowsAffected > 0)
        //            {
        //                Console.WriteLine("Usuario Insertado");
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error al insertar el usuario";
        //            }
        //        }

        //    }catch(Exception ex) 
        //    {
        //        result.Correct=false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}




        //static public ML.Result Udate(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.Connection = context;
        //            cmd.CommandText = "UPDATE [Usuario]SET [Nombre] = @Nombre,[ApellidoPaterno] = @ApellidoPaterno,[ApellidoMaterno] = @ApellidoMaterno,[Grado] = @Grado WHERE [IdUsuario] = 3";

        //            SqlParameter[] collection = new SqlParameter[4];
        //            collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //            collection[0].Value = usuario.Nombre;
        //            collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //            collection[1].Value = usuario.ApellidoPaterno;
        //            collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoMaterno;
        //            collection[3] = new SqlParameter("Grado", SqlDbType.TinyInt);
        //            collection[3].Value = usuario.Grado;

        //            cmd.Parameters.AddRange(collection);

        //            cmd.Connection.Open();

        //            int RowsAffected = cmd.ExecuteNonQuery();
        //            if (RowsAffected > 0)
        //            {
        //                Console.WriteLine("Usuario actualizado");
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error al actualizar";
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}



        //static public ML.Result Delete(int IdUsuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.Connection = context;
        //            cmd.CommandText = "DELETE FROM [Usuario] WHERE IdUsuario =" + IdUsuario;

        //            //SqlParameter[] collection = new SqlParameter[1];
        //            //collection[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
        //            //collection[0].Value = IdUsuario;

        //            //cmd.Parameters.AddRange(collection);

        //            cmd.Connection.Open();

        //            int RowsAffected = cmd.ExecuteNonQuery();
        //            if (RowsAffected > 0)
        //            {
        //                Console.WriteLine("Usuario Eliminado");
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error al eliminar el usuario";
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}





        //static public ML.Result GetAll() 
        //{
        //    ML.Result result = new ML.Result();
        //    try 
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.Connection = context;
        //            cmd.CommandText = "SELECT [IdUsuario],[Nombre],[ApellidoPaterno],[ApellidoMaterno],[Grado]FROM [Usuario]";

        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            DataTable alumnoTabla = new DataTable();

        //            da.Fill(alumnoTabla);
        //            if (alumnoTabla.Rows.Count > 0)
        //            {
        //                result.Objects = new List<object>();
        //                foreach (DataRow row in alumnoTabla.Rows) 
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();
        //                    usuario.IdUsuario = int.Parse(row[0].ToString());
        //                    usuario.Nombre = row[1].ToString();
        //                    usuario.ApellidoPaterno = row[2].ToString();
        //                    usuario.ApellidoMaterno = row[3].ToString();
        //                    usuario.Grado = byte.Parse(row[4].ToString());

        //                    result.Objects.Add(usuario);
        //                }

        //                result.Correct = true;
        //            }
        //            else 
        //            {
        //                result.Correct=false;
        //                result.ErrorMessage = ("No contiene registros");
        //            }
        //        }
        //    }
        //        catch(Exception ex) 
        //    {
        //        result.Correct=false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;

        //}






        //static public ML.Result GetById(int IdUsuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.Connection = context;
        //            cmd.CommandText = "SELECT [IdUsuario],[Nombre],[ApellidoPaterno],[ApellidoMaterno],[Grado]FROM [Usuario] WHERE [IdUsuario]=" + IdUsuario;

        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            DataTable alumnoTabla = new DataTable();


        //            da.Fill(alumnoTabla);
        //            if (alumnoTabla.Rows.Count > 0)
        //            {
        //                result.Objects = new List<object>();
        //                foreach (DataRow row in alumnoTabla.Rows)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();
        //                    usuario.IdUsuario = int.Parse(row[0].ToString());
        //                    usuario.Nombre = row[1].ToString();
        //                    usuario.ApellidoPaterno = row[2].ToString();
        //                    usuario.ApellidoMaterno = row[3].ToString();
        //                    usuario.Grado = byte.Parse(row[4].ToString());

        //                    result.Objects.Add(usuario);
        //                }

        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = ("No contiene registros");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;

        //}





        //static public ML.Result AddSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.Connection = context;
        //            cmd.CommandText = "AddSP";
        //            // AlumnoAdd 3
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            SqlParameter[] collection = new SqlParameter[12];
        //            collection[0] = new SqlParameter("UserName", SqlDbType.VarChar);
        //            collection[0].Value = usuario.UserName;
        //            collection[1] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //            collection[1].Value = usuario.Nombre;
        //            collection[2] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoPaterno;
        //            collection[3] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //            collection[3].Value = usuario.ApellidoMaterno;
        //            collection[4] = new SqlParameter("Email", SqlDbType.VarChar);
        //            collection[4].Value = usuario.Email;
        //            collection[5] = new SqlParameter("Password", SqlDbType.VarChar);
        //            collection[5].Value = usuario.Password;
        //            collection[6] = new SqlParameter("FechaNacimiento", SqlDbType.VarChar);
        //            collection[6].Value = usuario.FechaNacimiento;
        //            collection[7] = new SqlParameter("Sexo", SqlDbType.VarChar);
        //            collection[7].Value = usuario.Sexo;
        //            collection[8] = new SqlParameter("Telefono", SqlDbType.VarChar);
        //            collection[8].Value = usuario.Telefono;
        //            collection[9] = new SqlParameter("Celular", SqlDbType.VarChar);
        //            collection[9].Value = usuario.Celular;
        //            collection[10] = new SqlParameter("CURP", SqlDbType.VarChar);
        //            collection[10].Value = usuario.CURP;
        //            collection[11] = new SqlParameter("Grado", SqlDbType.TinyInt);
        //            collection[11].Value = usuario.Grado;


        //            cmd.Parameters.AddRange(collection);

        //            cmd.Connection.Open();

        //            int RowsAffected = cmd.ExecuteNonQuery();

        //            if (RowsAffected > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error al insertar el alumno";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}




        //static public ML.Result UdateSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.Connection = context;
        //            cmd.CommandText = "UpdateSP";
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            SqlParameter[] collection = new SqlParameter[13];
        //            collection[0] = new SqlParameter("IdUsuario", SqlDbType.TinyInt);
        //            collection[0].Value = usuario.IdUsuario;
        //            collection[1] = new SqlParameter("UserName", SqlDbType.VarChar);
        //            collection[1].Value = usuario.UserName;
        //            collection[2] = new SqlParameter("Nombre", SqlDbType.VarChar);
        //            collection[2].Value = usuario.Nombre;
        //            collection[3] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
        //            collection[3].Value = usuario.ApellidoPaterno;
        //            collection[4] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
        //            collection[4].Value = usuario.ApellidoMaterno;
        //            collection[5] = new SqlParameter("Email", SqlDbType.VarChar);
        //            collection[5].Value = usuario.Email;
        //            collection[6] = new SqlParameter("Password", SqlDbType.VarChar);
        //            collection[6].Value = usuario.Password;
        //            collection[7] = new SqlParameter("FechaNacimiento", SqlDbType.VarChar);
        //            collection[7].Value = usuario.FechaNacimiento;
        //            collection[8] = new SqlParameter("Sexo", SqlDbType.VarChar);
        //            collection[8].Value = usuario.Sexo;
        //            collection[9] = new SqlParameter("Telefono", SqlDbType.VarChar);
        //            collection[9].Value = usuario.Telefono;
        //            collection[10] = new SqlParameter("Celular", SqlDbType.VarChar);
        //            collection[10].Value = usuario.Celular;
        //            collection[11] = new SqlParameter("CURP", SqlDbType.VarChar);
        //            collection[11].Value = usuario.CURP;
        //            collection[12] = new SqlParameter("Grado", SqlDbType.TinyInt);
        //            collection[12].Value = usuario.Grado;

        //            cmd.Parameters.AddRange(collection);

        //            cmd.Connection.Open();

        //            int RowsAffected = cmd.ExecuteNonQuery();
        //            if (RowsAffected > 0)
        //            {
        //                Console.WriteLine("Usuario actualizado");
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error al actualizar";
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}




        //static public ML.Result DeleteSP(int IdUsuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.Connection = context;
        //            cmd.CommandText = "DeleteSP";
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Connection.Open();

        //            SqlParameter[] collection = new SqlParameter[1];
        //            collection[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
        //            collection[0].Value = IdUsuario;
        //            cmd.Parameters.AddRange(collection);

        //            int RowsAffected = cmd.ExecuteNonQuery();//Manda a la exepcion
        //            if (RowsAffected > 0)
        //            {
        //                Console.WriteLine("Usuario Eliminado");
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error al eliminar el usuario";
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}




        //static public ML.Result GetAllSP()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.Connection = context;
        //            cmd.CommandText = "GetAllSP";
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            DataTable usuarioTabla = new DataTable();

        //            da.Fill(usuarioTabla);
        //            //Manda a la exepcion
        //            if (usuarioTabla.Rows.Count > 0)
        //            {
        //                result.Objects = new List<object>();
        //                foreach (DataRow row in usuarioTabla.Rows)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();
        //                    usuario.IdUsuario = int.Parse(row[0].ToString());
        //                    usuario.UserName = row[1].ToString();
        //                    usuario.Nombre = row[2].ToString();
        //                    usuario.ApellidoPaterno = row[3].ToString();
        //                    usuario.ApellidoMaterno = row[4].ToString();
        //                    usuario.Email = row[5].ToString();
        //                    usuario.Password = row[6].ToString();
        //                    usuario.FechaNacimiento = row[7].ToString();
        //                    usuario.Sexo = row[8].ToString();
        //                    usuario.Telefono = row[9].ToString();
        //                    usuario.Celular = row[10].ToString();
        //                    usuario.CURP = row[11].ToString();
        //                    usuario.Grado = byte.Parse(row[12].ToString());

        //                    result.Objects.Add(usuario);
        //                }

        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = ("No contiene registros");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;

        //}







        //static public ML.Result GetByIdSP(int IdUsuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.Get()))
        //        {
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.Connection = context;
        //            cmd.CommandText = "GetByIDSP";
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            SqlParameter[] collection = new SqlParameter[1];
        //            collection[0] = new SqlParameter("IdUsuario", SqlDbType.Int);
        //            collection[0].Value = IdUsuario;

        //            cmd.Parameters.AddRange(collection);

        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            DataTable userTable = new DataTable();

        //            da.Fill(userTable);

        //            if (userTable.Rows.Count > 0)
        //            {
        //                DataRow row = userTable.Rows[0];

        //                ML.Usuario usuario = new ML.Usuario();
        //                usuario.IdUsuario = int.Parse(row[0].ToString());
        //                usuario.UserName = row[1].ToString();
        //                usuario.Nombre = row[2].ToString();
        //                usuario.ApellidoPaterno = row[3].ToString();
        //                usuario.ApellidoMaterno = row[4].ToString();
        //                usuario.Email = row[5].ToString();
        //                usuario.Password = row[6].ToString();
        //                usuario.FechaNacimiento = row[7].ToString();
        //                usuario.Sexo = row[8].ToString();
        //                usuario.Telefono = row[9].ToString();
        //                usuario.Celular = row[10].ToString();
        //                usuario.CURP = row[11].ToString();
        //                usuario.Grado = byte.Parse(row[12].ToString());

        //                result.Object = usuario; //BOXING manda a la exepcion

        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "No contiene registros la tabla usuario";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}





        /*  ENTITY FRAMEWORK   */

        static public ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {

                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var query = context.UsuarioGetAll().ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var objUsuario in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.IdUsuario = objUsuario.IdUsuario;
                            usuario.UserName = objUsuario.UserName;
                            usuario.Nombre = objUsuario.NombreUsuario;
                            usuario.ApellidoPaterno = objUsuario.ApellidoPaterno;
                            usuario.ApellidoMaterno = objUsuario.ApellidoMaterno;
                            usuario.Email = objUsuario.Email;
                            usuario.Password = objUsuario.Password;
                            usuario.FechaNacimiento = objUsuario.FechaNacimiento.ToString();
                            usuario.Sexo = objUsuario.Sexo;
                            usuario.Telefono = objUsuario.Telefono;
                            usuario.Celular = objUsuario.Celular;
                            usuario.CURP = objUsuario.CURP;


                            result.Objects.Add(usuario);
                        }
                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No contiene registros la tabla Alumno";
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





        //static public ML.Result AddSPEF(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
        //        {
        //            var query = context.AddSP(usuario.UserName, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Email, usuario.Password, usuario.FechaNacimiento, usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.CURP);

        //            if (query > 0)
        //            {
        //                result.Correct = true;
        //                Console.WriteLine();
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error al insertar el alumno";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}







        //static public ML.Result UdateSPEF(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
        //        {
        //            var query = context.UpdateSP(usuario.IdUsuario, usuario.UserName, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Email, usuario.Password, usuario.FechaNacimiento, usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.CURP, usuario.Rol.IdRol);

        //            if (query > 0)
        //            {
        //                Console.WriteLine("Usuario actualizado");
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error al actualizar";
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}







        static public ML.Result DeleteSPEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                //using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                //{
                //    var query = context.DeleteSP(IdUsuario);
                //    if (query > 0)
                //    {
                //        Console.WriteLine("Usuario eliminado");
                //    }
                //    else
                //    {
                //        result.Correct = false;
                //        result.ErrorMessage = "Error al eliminar";
                //    }
                //}

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }








        static public ML.Result GetByIdSPEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    //var objUsuario = context.GetByIDSP(IdUsuario).Single();

                    //if (objUsuario != null)
                    //{
                    //    ML.Usuario usuario = new ML.Usuario();
                    //    usuario.IdUsuario = objUsuario.IdUsuario;
                    //    usuario.UserName = objUsuario.UserName;
                    //    usuario.Nombre = objUsuario.Nombre;
                    //    usuario.ApellidoPaterno = objUsuario.ApellidoPaterno;
                    //    usuario.ApellidoMaterno = objUsuario.ApellidoMaterno;
                    //    usuario.Email = objUsuario.Email;
                    //    usuario.Password = objUsuario.Password;
                    //    usuario.FechaNacimiento = objUsuario.FechaNacimiento.ToString();
                    //    usuario.Sexo = objUsuario.Sexo;
                    //    usuario.Telefono = objUsuario.Telefono;
                    //    usuario.Celular = objUsuario.Celular;
                    //    usuario.CURP = objUsuario.CURP;

                    //    result.Object = usuario;

                    //    result.Correct = true;
                    //}

                    //else
                    //{
                    //    result.Correct = false;
                    //    result.ErrorMessage = "No contiene registros la tabla Alumno";
                    //}

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


        /*  LINQ  */


        static public ML.Result GetAllLINQ()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var query = (from usuario in context.Usuarios select usuario);

                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var objUsuario in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.IdUsuario = objUsuario.IdUsuario;
                            usuario.UserName = objUsuario.UserName;
                            usuario.Nombre = objUsuario.Nombre;
                            usuario.ApellidoPaterno = objUsuario.ApellidoPaterno;
                            usuario.ApellidoMaterno = objUsuario.ApellidoMaterno;
                            usuario.Email = objUsuario.Email;
                            usuario.Password = objUsuario.Password;
                            usuario.FechaNacimiento = objUsuario.FechaNacimiento.ToString();
                            usuario.Sexo = objUsuario.Sexo;
                            usuario.Telefono = objUsuario.Telefono;
                            usuario.Celular = objUsuario.Celular;
                            usuario.CURP = objUsuario.CURP;

                            result.Objects.Add(usuario);
                        }
                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No contiene registros la tabla Alumno";
                    }
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.Correct = false;
                result.Ex = ex;
            }
            return result;
        }





        static public ML.Result AddLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    DL.Usuario alumnoLINQ = new DL.Usuario();
                    alumnoLINQ.IdUsuario = usuario.IdUsuario;
                    alumnoLINQ.Nombre = usuario.Nombre;
                    alumnoLINQ.ApellidoMaterno = usuario.ApellidoMaterno;
                    alumnoLINQ.ApellidoPaterno = usuario.ApellidoPaterno;
                    alumnoLINQ.Email = usuario.Email;
                    alumnoLINQ.Password = usuario.Password;
                    alumnoLINQ.FechaNacimiento = DateTime.ParseExact(usuario.FechaNacimiento, "dd-MM-yyyy", CultureInfo.InvariantCulture); // MM/dd/yyyy dd-MM-yyy
                    alumnoLINQ.Sexo = usuario.Sexo;
                    alumnoLINQ.Telefono = usuario.Telefono;
                    alumnoLINQ.Celular = usuario.Celular;
                    alumnoLINQ.CURP = usuario.CURP;
                    alumnoLINQ.IdRol = usuario.Rol.IdRol; //Esta mal la referencia

                    context.Usuarios.Add(alumnoLINQ);  //NO SE REFLEJA EN LA BD

                    int rowAffeted = context.SaveChanges();  //EJECUTA EN LA BD
                    if (rowAffeted > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }

                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.Correct = false;
                result.Ex = ex;
            }
            return result;
        }







        static public ML.Result GetByIdLINQ(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var objUsuario = (from usuarios in context.Usuarios where usuarios.IdUsuario == IdUsuario select usuarios).Single();

                    if (objUsuario != null)
                    {
                        ML.Usuario usuario = new ML.Usuario();
                        usuario.IdUsuario = objUsuario.IdUsuario;
                        usuario.UserName = objUsuario.UserName;
                        usuario.Nombre = objUsuario.Nombre;
                        usuario.ApellidoPaterno = objUsuario.ApellidoPaterno;
                        usuario.ApellidoMaterno = objUsuario.ApellidoMaterno;
                        usuario.Email = objUsuario.Email;
                        usuario.Password = objUsuario.Password;
                        usuario.FechaNacimiento = objUsuario.FechaNacimiento.ToString();
                        usuario.Sexo = objUsuario.Sexo;
                        usuario.Telefono = objUsuario.Telefono;
                        usuario.Celular = objUsuario.Celular;
                        usuario.CURP = objUsuario.CURP;

                        result.Object = usuario;

                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No contiene registros la tabla Alumno";
                    }
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.Correct = false;
                result.Ex = ex;
            }
            return result;
        }




        static public ML.Result DeleteLINQ(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var query = (from usuarios in context.Usuarios where usuarios.IdUsuario == IdUsuario select usuarios).Single();
                    context.Usuarios.Remove(query);
                    int rowAffected = context.SaveChanges();

                    if (rowAffected > 0)
                    {
                        result.Correct = true;
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
                result.ErrorMessage = ex.Message;
                result.Correct = false;
                result.Ex = ex;
            }
            return result;
        }




        static public ML.Result UpdateLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {

                    var query = (from usuarios in context.Usuarios where usuarios.IdUsuario == usuario.IdUsuario select usuarios).Single();

                    if (query != null)
                    {
                        query.UserName = usuario.UserName;
                        query.Nombre = usuario.Nombre;
                        query.ApellidoMaterno = usuario.ApellidoMaterno;
                        query.ApellidoPaterno = usuario.ApellidoPaterno;
                        query.Email = usuario.Email;
                        query.Password = usuario.Password;
                        query.FechaNacimiento = DateTime.ParseExact(usuario.FechaNacimiento, "dd-MM-yyyy", CultureInfo.InvariantCulture); // MM/dd/yyyy dd-MM-yyy
                        query.Sexo = usuario.Sexo;
                        query.Telefono = usuario.Telefono;
                        query.Celular = usuario.Celular;
                        query.CURP = usuario.CURP;
                        query.IdRol = usuario.Rol.IdRol;

                        int rowAffected = context.SaveChanges();   ///exepcion en la tabla IdRol
                        if (rowAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "Error al actualizar el usuario";
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.Correct = false;
                result.Ex = ex;
            }
            return result;
        }





        /*  ENTITY FRAMEWORK TABLAS RELACIONADAS   */

        static public ML.Result GetAllSP()
        {
            ML.Result result = new ML.Result();
            try
            {

                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var query = context.UsuarioGetAll().ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var objUsuario in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();
                            usuario.IdUsuario = objUsuario.IdUsuario;
                            usuario.UserName = objUsuario.UserName;
                            usuario.Nombre = objUsuario.NombreUsuario;
                            usuario.ApellidoPaterno = objUsuario.ApellidoPaterno;
                            usuario.ApellidoMaterno = objUsuario.ApellidoMaterno;
                            usuario.Email = objUsuario.Email;
                            usuario.Password = objUsuario.Password;
                            usuario.FechaNacimiento = objUsuario.FechaNacimiento.ToString();
                            usuario.Sexo = objUsuario.Sexo;
                            usuario.Telefono = objUsuario.Telefono;
                            usuario.Celular = objUsuario.Celular;
                            usuario.CURP = objUsuario.CURP;
                            usuario.Rol = new ML.Rol();
                            usuario.Rol.Nombre = objUsuario.NombreRol;
                            usuario.Direccion = new ML.Direccion();
                            usuario.Direccion.Calle = objUsuario.Calle;
                            usuario.Direccion.NumeroInterior = objUsuario.NumeroInterior;
                            usuario.Direccion.NumeroExterior = objUsuario.NumeroExterior;
                            usuario.Direccion.Colonia = new ML.Colonia();
                            usuario.Direccion.Colonia.Nombre = objUsuario.NombreColonia;
                            usuario.Direccion.Colonia.CodigoPostal = objUsuario.CodigoPostal;
                            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuario.Direccion.Colonia.Municipio.Nombre = objUsuario.NombreColonia;
                            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuario.Direccion.Colonia.Municipio.Estado.Nombre = objUsuario.NombreEstado;
                            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                            usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = objUsuario.NombrePais;

                            result.Objects.Add(usuario);
                        }
                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No contiene registros la tabla Alumno";
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





        static public ML.Result GetByIdEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var objUsuario = context.UsuarioGetByID(IdUsuario).Single();

                    if (objUsuario != null)
                    {
                        ML.Usuario usuario = new ML.Usuario();
                        usuario.IdUsuario = objUsuario.IdUsuario;
                        usuario.UserName = objUsuario.UserName;
                        usuario.Nombre = objUsuario.NombreUsuario;
                        usuario.ApellidoPaterno = objUsuario.ApellidoPaterno;
                        usuario.ApellidoMaterno = objUsuario.ApellidoMaterno;
                        usuario.Email = objUsuario.Email;
                        usuario.Password = objUsuario.Password;
                        usuario.FechaNacimiento = objUsuario.FechaNacimiento.ToString();
                        usuario.Sexo = objUsuario.Sexo;
                        usuario.Telefono = objUsuario.Telefono;
                        usuario.Celular = objUsuario.Celular;
                        usuario.CURP = objUsuario.CURP;
                        usuario.Rol = new ML.Rol();
                        usuario.Rol.Nombre = objUsuario.NombreRol;
                        usuario.Direccion = new ML.Direccion();
                        usuario.Direccion.Calle = objUsuario.Calle;
                        usuario.Direccion.NumeroInterior = objUsuario.NumeroInterior;
                        usuario.Direccion.NumeroExterior = objUsuario.NumeroExterior;
                        usuario.Direccion.Colonia = new ML.Colonia();
                        usuario.Direccion.Colonia.Nombre = objUsuario.NombreColonia;
                        usuario.Direccion.Colonia.CodigoPostal = objUsuario.CodigoPostal;
                        usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                        usuario.Direccion.Colonia.Municipio.Nombre = objUsuario.NombreColonia;
                        usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                        usuario.Direccion.Colonia.Municipio.Estado.Nombre = objUsuario.NombreEstado;
                        usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                        usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = objUsuario.NombrePais;

                        result.Object = usuario;

                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No contiene registros la tabla Alumno";
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




        static public ML.Result AddSPEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var query = context.UsuarioAdd(usuario.UserName, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Email, usuario.Password, DateTime.Parse(usuario.FechaNacimiento), usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.CURP,usuario.Rol.IdRol,usuario.Direccion.Calle,usuario.Direccion.NumeroInterior,usuario.Direccion.NumeroExterior,usuario.Direccion.Colonia.IdColonia);

                    if (query > 0)
                    {
                        result.Correct = true;
                        //Console.WriteLine();
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al insertar el alumno";
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




        static public ML.Result UdateSPEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var query = context.UsuarioUpdate(usuario.IdUsuario, usuario.UserName, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Email, usuario.Password, DateTime.Parse(usuario.FechaNacimiento), usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.CURP, usuario.Rol.IdRol, usuario.Direccion.Calle, usuario.Direccion.NumeroInterior, usuario.Direccion.NumeroExterior, usuario.Direccion.Colonia.IdColonia);

                    if (query > 0)
                    {
                        Console.WriteLine("Usuario actualizado");
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






        static public ML.Result DeleteSP(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ODiazProgramacionNCapasEntities3 context = new DL.ODiazProgramacionNCapasEntities3())
                {
                    var query = context.UsuarioDelete(IdUsuario);
                    if (query > 0)
                    {
                        Console.WriteLine("Usuario eliminado");
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
