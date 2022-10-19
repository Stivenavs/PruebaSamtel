<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="GestionMaterias.aspx.cs" Inherits="Notas.Pages.GestionMaterias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center-block">
        <div class="Wrap">
            <div class="index center-block">
                <h4 class="text-center">Datos Materia</h4>
                <hr />
                <asp:Panel ID="Pnl_DatosMateria" runat="server" Width="100%" CssClass="center-block">
                    <div style="width: 85%" class="center-block">
                        <div style="float: left; width: 50%">
                            <asp:Label ID="Lbl_Descripcion" runat="server" Text="Descripción:"></asp:Label>
                            <asp:TextBox ID="Txt_Descripcion" runat="server" CssClass="right form-control" Width="80%" AutoCompleteType="Disabled"></asp:TextBox>
                        </div>
                      
                        <div style="float: left; width: 50%">
                            <asp:Label ID="Lbl_Codigo" runat="server" Text="Codigo (Numerico):"></asp:Label>
                            <asp:TextBox ID="Txt_Codigo" runat="server" CssClass="right form-control" Width="80%" AutoCompleteType="Disabled" OnKeyPress="return SoloNumeros(event)"></asp:TextBox>
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
                    <asp:LinkButton ID="LinkBtn_CrearMateria" runat="server" CssClass="btn btn-default" Width="150px" OnClick="LinkBtn_CrearMateria_Click">
                        <span class="glyphicon glyphicon-floppy-save"></span>&nbsp;&nbsp;Crear Materia
                    </asp:LinkButton>
                </div>
            </div>


            <%-- GRIDVIEW --%>
            <div>
                <asp:GridView ID="GV_Materias" runat="server"></asp:GridView>
            </div>
        </div>        
    </div>
</asp:Content>
