using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Producto" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Producto.svc o Producto.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Producto : IProducto
    {
        public ML.Result Add(ML.Producto producto)
        {
            ML.Result result = BL.Producto.Add(producto);
            return result;

            //return new SL.Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects };

        }



        public ML.Result GetAll()
        {
            ML.Result result = BL.Producto.GetAll();
            // return result;
            return new ML.Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects };
        }


        public ML.Result GetById(int IdProducto)
        {
            ML.Result result = BL.Producto.GetById(IdProducto);
            // return result;
            return new ML.Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects };
        }



        public ML.Result Update(ML.Producto producto)
        {
            ML.Result result = BL.Producto.Add(producto);
            return result;

            //return new SL.Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects };

        }



        public ML.Result Delete(int IdProducto)
        {
            ML.Result result = BL.Producto.Delete(IdProducto);
            // return result;
            return new ML.Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects };
        }
    }
}
