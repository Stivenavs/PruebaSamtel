<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="GestionAlumnos.aspx.cs" Inherits="Notas.Pages.GestionAlumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center-block">
        <div class="Wrap">
            <div class="index center-block">
                <h4 class="text-center">Datos Alumno</h4>
                <hr />
                <asp:Panel ID="Pnl_DatosAlumno" runat="server" Width="100%" CssClass="center-block">
                    <div style="width: 85%" class="center-block">
                        <div style="float: left; width: 50%">
                            <asp:Label ID="Lbl_PrimerNombre" runat="server" Text="Primer Nombre:"></asp:Label>
                            <asp:TextBox ID="Txt_PrimerNombre" runat="server" CssClass="right form-control" Width="80%" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>

                        <div style="float: left; width: 50%">
                            <asp:Label ID="Lbl_SegundoNombre" runat="server" Text="Segundo Nombre:"></asp:Label>
                            <asp:TextBox ID="Txt_SegundoNombre" runat="server" CssClass="right form-control" Width="80%" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>

                        <div style="float: left; width: 50%">
                            <asp:Label ID="Lbl_PrimerApellido" runat="server" Text="Primer Apellido:"></asp:Label>
                            <asp:TextBox ID="Txt_PrimerApellido" runat="server" CssClass="right form-control" Width="80%" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>

                        <div style="float: left; width: 50%">
                            <asp:Label ID="Lbl_SegundoApellido" runat="server" Text="Segundo Apellido:"></asp:Label>
                            <asp:TextBox ID="Txt_SegundoApellido" runat="server" CssClass="right form-control" Width="80%" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>

                        <div style="float: left; width: 50%">
                            <asp:Label ID="Lbl_Documento" runat="server" Text="Documento:"></asp:Label>
                            <asp:TextBox ID="Txt_Documento" runat="server" CssClass="right form-control" Width="80%" AutoCompleteType="Disabled" OnKeyPress="return SoloNumeros(event)"></asp:TextBox>
                        </div>

                        <div style="float: left; width: 50%">
                            <asp:Label ID="Lbl_Programa" runat="server" Text="Programa:"></asp:Label>
                            <asp:DropDownList ID="Ddl_Programa" runat="server" CssClass="left form-control" Width="80%" AutoCompleteType="Disabled">
                            </asp:DropDownList>
                        </div>

                    </div>
                </asp:Panel>
                <br />
                <br />
                <div class="center-block text-center" style="width: 50%">
                    <asp:LinkButton ID="LinkBtn_CrearAlumno" runat="server" CssClass="btn btn-default" Width="150px" OnClick="LinkBtn_CrearAlumno_Click">
                        <span class="glyphicon glyphicon-floppy-save"></span>&nbsp;&nbsp;Crear Alumno
                    </asp:LinkButton>
                </div>
            </div>


            <%-- GRIDVIEW --%>
            <div>
                <asp:GridView ID="GV_Alumnos" runat="server"></asp:GridView>
            </div>
        </div>        
    </div>
</asp:Content>
