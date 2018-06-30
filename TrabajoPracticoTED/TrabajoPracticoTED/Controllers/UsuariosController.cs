using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gestor;

namespace TrabajoPracticoTED.Controllers
{
    public class UsuariosController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            List<Usuario> list = GestorUsuarios.ObtenerUsuarios();

            if (list == null) return NotFound();
            else return Ok(list);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(string nombre, string password)
        {
            Usuario usr = GestorUsuarios.ObtenerUsuario(nombre, password);

            if (usr == null) return Ok("");
            else return Ok(usr);
        }

        // POST api/<controller>
        public IHttpActionResult Post(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            GestorUsuarios.Grabar(usuario);
            //Datos.GestorArticulos.Grabar(articulos);

            return CreatedAtRoute("DefaultApi", new { nombre = usuario.nombre, contraseña = usuario.contraseña }, usuario);
            //return CreatedAtRoute("DefaultApi", new { id = articulos.IdArticulo }, articulos);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}