<%@ Page Title="Registrarse" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rUsuario.aspx.cs" Inherits="RegistroUsuario.Registros.rUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel panel-primary">
        <div class="panel-heading">Registro Usuario </div>
        <div class="panel-body">
            <div class="form-horizontal col-md-12" role="form">
            <%--UsuarioId--%>
            <div class="form-group">               
                <label for="UsuarioIdTextBox" class="col-xs-12 col-sm-6 col-md-3 control-label input-sm">Usuario Id:</label>
                <div class="col-md-1 col-sm-2 col-xs-4">
                    <asp:TextBox ID="UsuarioIdTextBox" runat="server" placeholder="0" class="form-control input-sm" />                   
                  </div>
                <div class="col-md-1 col-sm-2 col-xs-4">
                    <asp:LinkButton ID="BuscarButton" CssClass="btn btn-info btn-block btn-md" data-toggle="modal" data-target="#myModal" CausesValidation="False" runat="server" Text="<span class='glyphicon glyphicon-search'></span>" />
                </div>
            </div>

             <%--Nombre--%>
            <div class="form-group">               
                <label for="NombreUsuarioTextBox" class="col-md-3 control-label input-sm"> Nombre:</label>
                <div class="col-md-6 col-sm-2 col-xs-4">
                    <asp:TextBox ID="NombreUsuarioTextBox" runat="server" placeholder="Nombre Completo" class="form-control input-sm" />
                    <asp:RequiredFieldValidator ID="RFVNombre" runat="server" MaxLength="30" ControlToValidate="NombreUsuarioTextBox" ErrorMessage="Campo Nombre obligatorio" ForeColor="Red" Display="Dynamic" SetFocusOnError="True" ToolTip="Campo Nombre obligatorio">Por favor llenar el campo Nombre </asp:RequiredFieldValidator>
                </div>                
            </div>

             <%--Usuario--%>
            <div class="form-group">               
                <label for="UsuarioTextBox" class="col-md-3 control-label input-sm"> Usuario:</label>
                <div class="col-md-6 col-sm-2 col-xs-4">
                    <asp:TextBox ID="UsuarioTextBox" runat="server" placeholder="Nombre Usuario" class="form-control input-sm" />
                    <asp:RequiredFieldValidator ID="RFVUsuario" runat="server" MaxLength="20" ControlToValidate="UsuarioTextBox" ErrorMessage="Campo Usuario obligatorio" ForeColor="Red" Display="Dynamic" SetFocusOnError="True" ToolTip="Campo Usuario obligatorio">Por favor llenar el campo Usuario </asp:RequiredFieldValidator>
                </div>       
            </div>

             <%--Tipo Usuario--%>
            <div class="form-group">
                    <label for="TipoDropDownList" class="col-md-3 control-label input-sm">Tipo Usuario:</label>
                    <div class="col-md-8">
                        <asp:DropDownList ID="TipoDropDownList" runat="server" Class="form-control input-sm">
                            <asp:ListItem Selected="True">[Seleccione Uno]</asp:ListItem>
                            <asp:ListItem Text="Administrador"></asp:ListItem>
                            <asp:ListItem Text="Empleado"></asp:ListItem>                            
                        </asp:DropDownList>                       
                    
                </div>
            </div>

             <%--Contrasena--%>
            <div class="form-group">               
                <label for="ContrasenaTextBox" class="col-md-3 control-label input-sm"> Contrasena:</label>
                <div class="col-md-6 col-sm-2 col-xs-4">
                    <asp:TextBox ID="ContrasenaTextBox" runat="server" placeholder="Contrasena" TextMode="Password" class="form-control input-sm" />
                    <asp:RequiredFieldValidator ID="RFVContrasena" runat="server" MaxLength="15" ControlToValidate="ContrasenaTextBox" ErrorMessage="Campo Contrasena obligatorio" ForeColor="Red" Display="Dynamic" SetFocusOnError="True" ToolTip="Campo Contrasena obligatorio">Por favor llenar el campo Contrasena </asp:RequiredFieldValidator>
                </div>                
            </div>

             <%--Confirmar--%>
            <div class="form-group">               
                <label for="ConfirmarTextBox" class="col-md-3 control-label input-sm"> Confirmar:</label>
                <div class="col-md-6 col-sm-2 col-xs-4">
                    <asp:TextBox ID="ConfirmarTextBox" runat="server" placeholder="Confirmar Contrasena" TextMode="Password" class="form-control input-sm" />
                    <asp:RequiredFieldValidator ID="RFVConfirmar" runat="server" MaxLength="15" ControlToValidate="ConfirmarTextBox" ErrorMessage="Campo Confirmar obligatorio" ForeColor="Red" Display="Dynamic" SetFocusOnError="True" ToolTip="Campo Confirmar obligatorio">Por favor llenar el campo Confirmar </asp:RequiredFieldValidator>
                </div>                
            </div>

                </div>
                    <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
                </div>

         <%--Botones--%>
              <div class="panel-footer">
                  <div class="text-center">
                <div class="form-group" style="display: inline-block">
                    <asp:Button Text="Nuevo" class="btn btn-primary btn-sm" runat="server" ID="NuevoButton" OnClick="NuevoButton_Click" />
                    <asp:Button Text="Guardar" class="btn btn-success btn-sm" runat="server" ID="GuadarButton" OnClick="GuadarButton_Click"  />
                    <asp:Button Text="Eliminar" class="btn btn-danger btn-sm" runat="server" ID="EliminarButton" OnClick="EliminarButton_Click"  />

                </div>
            </div>

        </div>


            </div>  
</asp:Content>