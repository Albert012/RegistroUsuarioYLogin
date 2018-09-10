using System;
using BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using System.Web.Security;

namespace RegistroUsuario
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Inicio_Click(object sender, EventArgs e)
        {
            if(UsuariosBLL.Authenticate(UsuarioText.Text,ContrasenaText.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(UsuarioText.Text, true);
            }
            else
            {
                MostrarMensaje(TiposMensaje.Error, "");
            }
        }

        void MostrarMensaje(TiposMensaje tipo, string mensaje)
        {
            ErrorLabel.Text = mensaje;

            if (tipo == TiposMensaje.Success)
                ErrorLabel.CssClass = "alert-success";
            else
                ErrorLabel.CssClass = "alert-danger";
        }
    }
}