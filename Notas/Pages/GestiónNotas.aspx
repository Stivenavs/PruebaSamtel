<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="GestiónNotas.aspx.cs" Inherits="Notas.Pages.GestiónNotas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center-block">
        <div class="Wrap">
            <div class="index center-block">
                <h4 class="text-center">Notas</h4>
                <hr />
                <asp:Panel ID="Pnl_Notas" runat="server" Width="100%" CssClass="center-block">
                    <div style="width: 85%" class="center-block">
                        <div style="float: left; width: 50%">
                            <asp:Label ID="Lbl_Alumno" runat="server" Text="Alumno:"></asp:Label>
                            <asp:DropDownList ID="Ddl_Alumno" runat="server" CssClass="left form-control" Width="80%" AutoCompleteType="Disabled">
                            </asp:DropDownList>
                        </div>  
                        
                        <div style="float: left; width: 50%">
                            <asp:Label ID="Lbl_Materia" runat="server" Text="Materia:"></asp:Label>
                            <asp:DropDownList ID="Ddl_Materia" runat="server" CssClass="left form-control" Width="80%" AutoCompleteType="Disabled">
                            </asp:DropDownList>
                        </div>

                        <div style="float: left; width: 50%">
                            <asp:Label ID="Lbl_Codigo" runat="server" Text="Nota Final:"></asp:Label>
                            <asp:TextBox ID="Txt_Codigo" runat="server" CssClass="right form-control" Width="80%" AutoCompleteType="Disabled" OnKeyPress="return SoloNumeros(event)"></asp:TextBox>
                        </div>                        
                    </div>
                </asp:Panel>
                <br />
                <br />
                <div class="center-block text-center" style="width: 50%">
                    <asp:LinkButton ID="LinkBtn_AsignarNota" runat="server" CssClass="btn btn-default" Width="150px" OnClick="LinkBtn_AsignarNota_Click">
                        <span class="glyphicon glyphicon-floppy-save"></span>&nbsp;&nbsp;Asignar Nota
                    </asp:LinkButton>
                </div>
            </div>


            <%-- GRIDVIEW --%>
            <div>
                <asp:GridView ID="GV_NotasFinales" runat="server"></asp:GridView>
            </div>
        </div>        
    </div>
</asp:Content>
