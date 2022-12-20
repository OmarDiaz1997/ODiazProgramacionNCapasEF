using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL_WebAPI.Controllers
{
    public class ProductoController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}



        [Route("api/Producto/GetAll")]
        [HttpGet]  ///Codigos de error HTTP 
        public IHttpActionResult GetAll()
        {
            ML.Result result = BL.Producto.GetAll();
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }



        [Route("api/Producto/Add")]
        [HttpPost]  ///Codigos de error HTTP 
        public IHttpActionResult Add([FromBody] ML.Producto alumno)
        {
            ML.Result result = BL.Producto.AddSPEF(alumno);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }




        [Route("api/Producto/GetById")]
        [HttpGet]  ///Codigos de error HTTP 
        public IHttpActionResult GetById(int IdProducto)
        {
            ML.Result result = BL.Producto.GetByIdEF(IdProducto);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }




        [Route("api/Producto/Delete")]
        [HttpDelete]  ///Codigos de error HTTP 
        public IHttpActionResult Delete(int IdProducto)
        {
            ML.Result result = BL.Producto.DeleteSP(IdProducto);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }




        [Route("api/Producto/Update")]
        [HttpPut]  ///Codigos de error HTTP 
        public IHttpActionResult Put(ML.Producto producto)
        {
            ML.Result result = BL.Producto.AddSPEF(producto);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, result);
            }
        }

    }
}