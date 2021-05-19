<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicio.aspx.cs" Inherits="proyectoFinal.frmInicio" %>

<!DOCTYPE html>

<html lang="es" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="https://bootswatch.com/4/lux/bootstrap.min.css" />
<link href="frmInicio.css" rel="stylesheet" />
<title>Notas</title>

<style type="text/css">
        .auto-style1 {
            display: block;
            width: 100%;
            height: calc(1.5em + 1.5rem + 2px);
            font-size: .875rem;
            font-weight: 400;
            line-height: 1.5;
            color: #55595c;
            background-clip: padding-box;
            border-radius: 0;
            transition: none;
            border: 1px solid #ced4da;
            margin-top: 0;
            background-color: #f7f7f9;
        }
        body{
             background-color: #403A3A;
        }
        .card{
           -webkit-border-radius: 10px 10px 10px 10px;
           border-radius: 10px 10px 10px 10px;
           background: #fff;
           -webkit-box-shadow: 0 30px 60px 0 rgba(0,0,0,1.2);
           box-shadow: 0 5px 60px 0 rgba(0,0,0,1.2);
        }
        .imguser{
            margin-right: 1em;
        }
        #LblUser{
            cursor: pointer;

        }
        .dropdown-content {
            display: none;
            position: absolute;
            background-color: #f9f9f9;
            min-width: 200px;
            box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
            padding: 12px 16px;
            z-index: 1;
        }
        .dropdown {
            position: relative;
            display: inline-block;
        }
        .dropdown:hover .dropdown-content {
            display: block;
        }
        #BtnDelete{
            border-radius: 10px 10px 10px 10px;
            -webkit-box-shadow: 0 30px 60px 0 rgba(0,0,0,1.2);
           box-shadow: 0 5px 60px 0 rgba(0,0,0,1.2);
        }
    </style>

    

    <link rel="shortcut icon" href="Img/16_122653 (2).ico"/>


</head>
<body>
    
    <form id="form1" runat="server">
    
    <div>
            <!-- NAVIGATION -->
        <nav class="navbar navbar-light bg-white">
            <div class="container">
                <a class="navbar-brand" href="#">Notas Escolares</a>
                <div align="right">
                <img src="Img/usuario.png" class="imguser" alt="Alternate Text"/>
                    <div class="dropdown">
                        <span>
                            <asp:Label ID="LblUser" class="navbar-brand" runat="server"></asp:Label></span>
                        <div class="dropdown-content">
                            <a href="WebForm2.aspx" class="btn btn-outline-dark">Cerrar Sesión</a>
                        </div>
                    </div>
            </div>
        </nav>

        <div class="container">
            <div class="row my-5">
                <div class="col-md-4">

                    <div class="card">
                        <div class="card-body">
                            <!-- FORM DE TASKS -->
                            <div class="form-group">
                                &nbsp;<asp:TextBox ID="title" name="title" CssClass="form-control" placeholder="Titulo..." runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <textarea id="description" name="description" placeholder="Descripción..." cols="30" rows="10" class="form-control"></textarea>
                                <asp:SqlDataSource ID="SqlDataSourceNotas" runat="server" ConnectionString="<%$ ConnectionStrings:NotasBDConnectionString %>" SelectCommand="SELECT [NombreMateria] FROM [Materias]"></asp:SqlDataSource>
                                <asp:DropDownList ID="DropDownList1" name="DropDownList1" runat="server" CssClass="custom-select my-1 mr-sm-2" DataSourceID="SqlDataSourceNotas" DataTextField="NombreMateria" DataValueField="NombreMateria">
                                </asp:DropDownList>
                                <br />
                                <br />
                                <asp:Button ID="BtnAdd" CssClass="btn btn-primary btn-block" runat="server" Text="Guardar" OnClick="Button1_Click" OnClientClick="getTasks()" />
                            </div>
                        </div>
                    </div>
                    <br />
                </div> 
                <!-- NOTAS EN PAGINA -->
                <div id="cont" class="col-md-8">
                    <div id="tasks" runat="server">
                    </div>
                   <asp:Button ID="BtnDelete" runat="server" CssClass="btn btn-danger btn-block" Text="Eliminar todos los registros" OnClick="BtnDelete_Click" />

                </div> 
            </div>
        </div>
   
        </div>    
    </form>
   

</body>
</html>
