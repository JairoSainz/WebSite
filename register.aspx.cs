using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoFinal
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        NoteBDDataContext noteBD = new NoteBDDataContext();
        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            Usuarios objuser = new Usuarios();
            objuser.NombreUser = TxtUser.Text;
            objuser.Clave = TxtPass.Text;

            if (TxtUser.Text == "" || TxtPass.Text == "")
            {
                string script = "alert('Llena los campos')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", script, true);
            }
            else
            {
                string script = "alert('Registrado correctamente')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", script, true);
                noteBD.Usuarios.InsertOnSubmit(objuser);
                noteBD.SubmitChanges();
                
                Response.Redirect("WebForm2.aspx");
            }
            
        }
    }
}