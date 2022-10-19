<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Notas.Pages.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center-block">
        <div class="Wrap">
            <asp:Panel ID="Pnl_MenuPrincipal" runat="server">
                <div class="index center-block">
                    <div class="form-group">
                        <h4 class="text-center">Menú Principal</h4>
                        <hr />
                        <div class="center-block text-center" style="margin-bottom: 10px">
                            <a href="GestionAlumnos.aspx">Gestionar Alumnos</a>
                        </div>
                        <div class="center-block text-center" style="margin-bottom: 10px">
                            <a href="GestionMaterias.aspx">Gestionar Materias</a>
                        </div>
                        <div class="center-block text-center" style="margin-bottom: 10px">
                            <a href="GestiónNotas.aspx">Gestionar Notas</a>
                        </div>
                    </div>
                </div>
            </asp:Panel>
        </div>
    </div>
</asp:Content>
