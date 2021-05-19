using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Text;


namespace proyectoFinal
{
    public partial class Login : System.Web.UI.Page
    {
        private bool Validar(String UserName, String Pass)
        {
            NoteBDDataContext conex = new NoteBDDataContext();
            var valid = from p in conex.Usuarios
                    where p.NombreUser == TxtUser.Text
                    && p.Clave == TxtPass.Text
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Validar(TxtUser.Text,TxtPass.Text))
            {

                Response.Redirect("frmInicio.aspx");


            }
        }
    }

    
}