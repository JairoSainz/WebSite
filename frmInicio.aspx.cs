using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoFinal
{
    public partial class frmInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //Session usario from master page
                string usuario = Request.QueryString["usuario"];
                LblUser.Text = usuario;
                //metodo mostrar nota de usuarios
                selectuser(usuario);
            }

            


        }
        
        NoteBDDataContext noteBD = new NoteBDDataContext();
        Notas objnote = new Notas();
        protected void Button1_Click(object sender, EventArgs e)
        {
            saveNote();



        }
        public void settask()
        {
            Notas objnote = new Notas();
            //TOMAR VALORES DE MI HTML
            string getTxtA = Request.Form["description"];
            string titulo = Request.Form["title"];
            string dropDown = Request.Form["DropDownList1"];
            int n = objnote.Numero;
            //CONCATENAR NOTAS
            for (var i = 0; i == n; i++)
            {
                //Cuadro de Notas
                tasks.InnerHtml += "<div class='card mb-3'> <div class='card-body'><p class='font-weight-bold'><big>" + titulo + "- <span class='badge badge-primary'>" + dropDown + "</span></p><p></big>" + getTxtA + "<br><br><br><a href='#' onclick='editTask('${title}, ${description}')' class='btn btn-success'>Editar</a><a href='#' onclick='' class='btn btn-info'>Materia</a><a href='#' onclick='deleteTasks()' class='btn btn-danger ml-5'>Delete</a></p></div></div>";

            }
        }
      
        public void selectuser(string user)
        {
            Notas objnote = new Notas();
            //string getTxtA = Request.Form["description"];
            int n = objnote.Numero;
            //-----------------------Variable de session para tomar usuario
            user = Request.QueryString["usuario"];
            LblUser.Text = user;
            //-----------------------Storage procedure
            string msj = "";
            
            var selectnote = noteBD.selectNote(user, msj);
            
            foreach (var dato in selectnote)
            {
                for (var i = 0; i==n ; i++)
                {
                    
                    //Cuadro de Notas
                    tasks.InnerHtml += "<div class='card mb-3'> <div class='card-body'><p class='font-weight-bold'><big>" + dato.Titulo + "- <span class='badge badge-primary'>" + dato.NombreMateria + "</span></p><p></big>" + dato.Descripcion + "<br><br><br><a href='#' onclick='editTask('${title}, ${description}')' class='btn btn-success'>Editar</a><a href='#' onclick='' class='btn btn-info'>Materia</a><a href='#' onclick='deleteTasks()' class='btn btn-danger ml-5'>Delete</a></p></div></div>";

                }
            }
            


        }

        public void saveNote()
        {
            Notas objnote = new Notas();
            objnote.Titulo = title.Text;
            string getTxtA = Request.Form["description"];
            objnote.Descripcion = getTxtA;
            //Variable session ----------------------------
            string usuario = Request.QueryString["usuario"];
            LblUser.Text = usuario;
            //set
            objnote.NombreUser = usuario;
            //------------------------------------
            objnote.NombreMateria = DropDownList1.SelectedValue;
            noteBD.Notas.InsertOnSubmit(objnote);
            noteBD.SubmitChanges();

            limpiar();

            //ACTUALIZAR NOTAS DE PAGINA
            
            settask();



        }

        public void limpiar()
        {
            title.Text = "";
            DropDownList1.ClearSelection();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            string usuario = Request.QueryString["usuario"];
            string msj = "";

            noteBD.deleteNote(usuario, msj);
            selectuser(usuario);
            tasks.InnerText = "";
            
            

        }

        protected void BtnEliminarNota_Click(object sender, EventArgs e)
        {
            /*Notas objnote = new Notas();
            objnote.Titulo = title.Text;
            string msj = "";
            var delete = noteBD.eraseNote(title.Text, msj);*/
        }
    }
}