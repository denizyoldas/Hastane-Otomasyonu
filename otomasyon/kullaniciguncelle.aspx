<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="kullaniciguncelle.aspx.cs" Inherits="otomasyon.kullaniciguncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <!-- Page Heading -->
    <h1 class="h3 mb-2 text-gray-800">Hasta</h1>

    <!-- DataTales Example -->
    <div class="card shadow mb-4">
        <div class="card-header py-3">
            <h6 class="m-0 font-weight-bold text-primary">Hasta Güncelleme</h6>
        </div>
        <div class="card-body">
            <form id="form1" runat="server" class="row">
                <div class="col-12">
                    <div class="form-group">
                        <label for="name">Ad Soyad</label>
                        <asp:TextBox ID="nameSurnameText" runat="server" placeholder="Mahmut tuncar" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="surname">Email</label>
                        <asp:TextBox ID="emailText" runat="server" placeholder="Tuncar" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="surname">Rol</label>
                        <asp:DropDownList ID="roleDrpDwn" runat="server" class="form-control">
                            <asp:ListItem Value="moderator">Moderatör</asp:ListItem>
                            <asp:ListItem Value="admin">Admin</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Kaydet" OnClick="Button1_Click" />
            </form>
        </div>
    </div>
</asp:Content>
