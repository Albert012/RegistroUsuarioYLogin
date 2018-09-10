using BLL;
using Entidades;
using RegistroUsuario.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroUsuario.Registros
{
    public partial class rUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                int id = Utilitarios.Utils.ToInt(Request.QueryString["id"]);
                if(id > 0)
                {
                    Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();
                    var usuario = repositorio.Buscar(id);

                    if(usuario == null)
                    {
                        MostrarMensaje(TiposMensaje.Error, "Registro No Encontrado");
                    }
                    else
                    {
                        LlenaCampos(usuario);
                    }
                }
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuadarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();
            Usuarios usuarios = new Usuarios();
            bool paso = false;

            LlenaClase(usuarios);

            if (usuarios.UsuarioId == 0)
                paso = repositorio.Guardar(usuarios);
            else
                paso = repositorio.Modificar(usuarios);

            if(paso)
            {
                MostrarMensaje(TiposMensaje.Success, "Usuario Registrado");
                Limpiar();
            }
            else
            {
                MostrarMensaje(TiposMensaje.Error, "No Se Pudo Registrar Usuario");
            }



        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();
            int id = Utils.ToInt(UsuarioIdTextBox.Text);

            var usuario = repositorio.Buscar(id);

            if (usuario == null)
                MostrarMensaje(TiposMensaje.Error, "Registro No Encontrado");
            else
                repositorio.Eliminar(id);
        }

        private void LlenaClase(Usuarios usuario)
        {
            usuario.UsuarioId = Utils.ToInt(UsuarioIdTextBox.Text);
            usuario.Usuario = UsuarioTextBox.Text;
            usuario.Nombre = NombreUsuarioTextBox.Text;
            usuario.Tipo = TipoDropDownList.Text;
            usuario.Contrasena = ContrasenaTextBox.Text;
        }
        private void LlenaCampos(Usuarios usuario)
        {
            UsuarioIdTextBox.Text = usuario.UsuarioId.ToString();
            UsuarioTextBox.Text = usuario.Usuario;
            NombreUsuarioTextBox.Text = usuario.Nombre;
            TipoDropDownList.Text = usuario.Tipo;
            ContrasenaTextBox.Text = usuario.Contrasena;
        }
        private void Limpiar()
        {
            UsuarioIdTextBox.Text = "";
            UsuarioTextBox.Text = "";
            NombreUsuarioTextBox.Text = "";
            TipoDropDownList.SelectedIndex = 0;
            ContrasenaTextBox.Text = "";
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