using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProducto" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProducto
    {
        [OperationContract]
        ML.Result Add(ML.Producto producto);  //Firma de metodos

        [OperationContract]
        [ServiceKnownType(typeof(ML.Producto))]
        ML.Result GetAll();

        [OperationContract]
        [ServiceKnownType(typeof(ML.Producto))] //Deserealizar
        ML.Result GetById(int IdProducto);


        [OperationContract]
        ML.Result Update(ML.Producto producto);



        [OperationContract]
        [ServiceKnownType(typeof(ML.Producto))] //Deserealizar
        ML.Result Delete(int IdProducto);
    }
}
