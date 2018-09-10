<%@ Page Title="Iniciar Sesion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RegistroUsuario.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   

     <div class="center-block" style="overflow: auto;">
           
     
        <h1 class="page-header text-center">Iniciar Sesion <span></span></h1>

        <div class="text-center">


            <br />
    

        <span class="badge badge-primary">Nombre Usuario </span>


            <!--Texbos Buscar y descrpcion o nombre -->



            <br />
            <asp:TextBox ID="UsuarioText" placeholder="Usuario" class="input-lg" runat="server" Height="30px" Width="134px" ></asp:TextBox>
            <br />

            <br />
    

        <span class="badge badge-primary">Contraseña </span>
            <br />


            <asp:TextBox ID="ContrasenaText"  TextMode="Password" placeholder="Contraseña" class="input-lg" runat="server" Height="30px" Width="162px"></asp:TextBox>

            <br />

            <br />
          
            <asp:Button ID="Iniciar" runat="server" CssClass="btn btn-success"  Text="Iniciar" OnClick="Inicio_Click" Width="99px"  />
            <br />
        </div>'

          <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
                
        <!--Botones -->

        <div class="text-center">
        </div>

         
               </div>
        

</asp:Content>
