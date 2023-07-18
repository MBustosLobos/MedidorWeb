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
            this.grillaAsistente.DataSource = usuario;
            this.grillaAsistente.DataBind();
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
    }
}