using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoFinal
{
    public partial class InicioSesion : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuario = login.Text;
            
        }

        private bool Validar(String UserName, String Pass)
        {
            
            NoteBDDataContext conex = new NoteBDDataContext();
            var valid = from p in conex.Usuarios
                        where p.NombreUser == login.Text
                        && p.Clave == password.Text
                        select p;
            if (valid.Any())
            {
                string script = "alert(\"Hola, Bienvenido!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                      "ServerControlScript", script, true);
                return true;
            }
            else
            {
                string script = "alert(\"Usuario o Contraseña Incorrecta!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                      "ServerControlScript", script, true);
                return false;
            }

        }

        protected void BtnIniciar_Click(object sender, EventArgs e)
        {
            


            if (Validar(login.Text, password.Text))
            {
                
                string formatted = System.Globalization.CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(login.Text);
                string usuario = login.Text;
                Response.Redirect("frmInicio.aspx?usuario="+usuario);


            }
        }

    }
}