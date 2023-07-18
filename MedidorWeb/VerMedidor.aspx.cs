using MedidorModel;
using MedidorModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidorWeb
{
    public partial class VerMedidor : System.Web.UI.Page
    {
        private IUsuariosDAL usuariosDAL = new UsuarioDALDB();

        private void cargaGrilla(List<Usuario> usuario)
        {
            this.grillaUsuario.DataSource = usuario;
            this.grillaUsuario.DataBind();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargaGrilla(this.usuariosDAL.ObtenerUsuarios());
            }

        }

        protected void tipoMedidorDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = this.tipoMedidorDDL.SelectedValue;
            List<Usuario> usuario = this.usuariosDAL.ObtenerUsuarios(estado);
            this.cargaGrilla(usuario);

        }
        protected void grillaUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "elimina")
            {
                //significa que el usuario apreto boton
                //por lo tanto, eliminar el cliente

                 int id = Convert.ToInt32(e.CommandArgument);
                usuariosDAL.EliminarUsuario(id);
                this.cargaGrilla(this.usuariosDAL.ObtenerUsuarios());
            }

        }
    }
}