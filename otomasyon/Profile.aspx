<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="otomasyon.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <!-- Page Heading -->
    <h1 class="h3 mb-2 text-gray-800">Profil</h1>

    <!-- DataTales Example -->
    <div class="card shadow mb-4">
        <div class="card-header py-3">
            <h6 class="m-0 font-weight-bold text-primary">Güncelle</h6>
        </div>
        <div class="card-body">
            <div><asp:Label ID="basarili" runat="server" Text="" class="alert alert-success" Visible="False"></asp:Label></div>
            <form id="form1" runat="server">
                <div class="form-group">
                    <label for="name">Adı Soyadı</label>
                    <asp:TextBox ID="nameSurname" runat="server" placeholder="Mahmut" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="email">Email</label>
                    <asp:TextBox ID="email" runat="server" placeholder="2315435" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="passs">Eski Şifre</label>
                    <asp:TextBox ID="oldPass" runat="server" placeholder="2315435" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="pass2">Yeni Şifre</label>
                    <asp:TextBox ID="newPass" runat="server" placeholder="2315435" class="form-control"></asp:TextBox>
                </div>
                <div><asp:Label ID="hata" runat="server" Text="" class="alert alert-danger" Visible="False"></asp:Label></div>
                <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Güncelle" OnClick="Button1_Click" />
            </form>
        </div>
    </div>
</asp:Content>
