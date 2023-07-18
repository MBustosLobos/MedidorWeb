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
    public partial class AgregarMedidor : System.Web.UI.Page

    {
        private IMedidorDAL medidorDAL = new MedidoresDALDB();
        private IUsuariosDAL usuarioDAL = new UsuarioDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                this.tipoMedidorDDL.DataSource = this.medidorDAL.ObtenerMedidores();
                this.tipoMedidorDDL.DataTextField = "Nombre";
                this.tipoMedidorDDL.DataValueField = "Id";
                this.tipoMedidorDDL.DataBind();
            }

        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Rut = this.rutTXT.Text.Trim();
            usuario.Nombre= this.nombreTXT.Text.Trim(); 
            usuario.Apellido = this.apellidoTXT.Text.Trim();    
            usuario.Correo = this.correoTXT.Text.Trim();    
            usuario.Lectura = Convert.ToInt32(lecturaTXT.Text);
            usuario.Estado = this.estadoRbl.Text.Trim();
            usuario.IdMedidor = Convert.ToInt32(this.tipoMedidorDDL.SelectedItem.Value);

            this.usuarioDAL.AgregarUsuario(usuario);
            Response.Redirect("VerMedidor.aspx");

        }
    }
}