using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor
{
    public class GestorUsuarios
    {
        public static List<Usuario> ObtenerUsuarios()
        {
            using (UsuariosEntities db = new UsuariosEntities())
            {
                return db.Usuarios.ToList();
            }
        }
        public static Usuario ObtenerUsuario(string nombre, string contraseña)
        {
            using (UsuariosEntities db = new UsuariosEntities())
            {
                return (db.Usuarios.Where(x => x.nombre == nombre && x.contraseña == contraseña)).FirstOrDefault();
            }
        }

        public static void Grabar(Usuario usuario)
        {
            using (UsuariosEntities db = new UsuariosEntities())
            {
                try
                {
                    db.Usuarios.Add(usuario);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error al grabar usuario");
                }
            }
        }
    }
}
