<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="proyectoFinal.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="https://bootswatch.com/4/lux/bootstrap.min.css" />

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrar nuevo usuario</title>


<style type="text/css">
    body{
        font-family: "Poppins", sans-serif;
        background-color: #403A3A;
        height: auto;
        width:auto;
    }

    #container {
    display: flex;
    align-items: center;
    flex-direction: column;
    justify-content: center;
    width: auto;
    min-height: 100%;
    padding: 20px;
    }
    #form1{
    -webkit-border-radius: 10px 10px 10px 10px;
    border-radius: 10px 10px 10px 10px;
    background: #fff;
    padding: 30px;
    width: 90%;
    max-width: 450px;
    -webkit-box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
    box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
    
    
    }
    #btn{
        max-width: 210px;
    }
</style>
    <link rel="shortcut icon" href="Img/16_122653 (2).ico"/>
</head>



<body>
    <div id="container" >
    <form id="form1" runat="server">
        

            <div class="form-group">
                <label>Usuario</label>&nbsp;
                <asp:TextBox ID="TxtUser" runat="server" type="text" class="form-control" placeholder="Escribe un usuario"></asp:TextBox>
               
            </div>
            <div class="form-group">
                <label>Contraseña</label>
                <asp:TextBox ID="TxtPass" runat="server" type="password" class="form-control" placeholder="Password" ></asp:TextBox>
                <br />
&nbsp;<asp:Button ID="BtnRegister" runat="server" Text="Registrar" type="submit" class="btn btn-success" OnClick="BtnRegister_Click" />
            </div>
            

        
        <a href="WebForm2.aspx" id="btn" class="btn btn-outline-dark">Volver al inicio de sesión</a>
            
    </form>

   </div>

</body>
</html>
