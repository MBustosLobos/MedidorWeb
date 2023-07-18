using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public class UsuarioDALDB : IUsuariosDAL
    {
        private MedidorDBEntities1 medidorDB = new MedidorDBEntities1();
        public void AgregarUsuario(Usuario usuario)
        {
            //ADD a la base de datos
            this.medidorDB.Usuarios.Add(usuario);
            //guardamos
            this.medidorDB.SaveChanges();
        }

        public void EliminarUsuario(int id)
        {
            //buscamos al asistente asociado al ID
            Usuario usuario = this.medidorDB.Usuarios.Find(id);
            //lo destruimos
            this.medidorDB.Usuarios.Remove(usuario);
            this.medidorDB.SaveChanges();
        }

        public Usuario Obtener(int id)
        {
            //Obtenemos datos mediante ID
            return this.medidorDB.Usuarios.Find(id);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            //retornamos lista completa
            return this.medidorDB.Usuarios.ToList();

        }
        public List<Usuario> ObtenerUsuarios(string estado)
        {
            //creamos el query para encontrar datos 
            var query = from u in this.medidorDB.Usuarios
                        where u.Estado == estado
                        select u;

            //retornamos lista de asistentes
            return query.ToList();
        }
    }

}
