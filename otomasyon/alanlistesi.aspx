<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="alanlistesi.aspx.cs" Inherits="otomasyon.alanlistesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800">Alanlar</h1>
    </div>

    <!-- DataTales Example -->
    <div class="card shadow mb-4">
        <div class="card-header py-3">
            <h6 class="m-0 font-weight-bold text-primary">Alan Listesi</h6>
        </div>

        <div class="card-body">
            <div class="row">
                <div class="table-responsive col-6">
                    <table class="table table-striped">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Ad</th>
                                <th>İşlem</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("id") %></td>
                                        <td><%# Eval("name") %></td>
                                        <td>
                                            <a href="alanlistesi.aspx?id=<%# Eval("id") %>">
                                                <i class="fa fa-edit fa-sm pr-2" style="color: forestgreen; cursor: pointer"></i>
                                            </a>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
                <div class="col-6">
                    <form id="form1" runat="server">
                        <div class="form-group">
                            <label for="name">Adı</label>
                            <asp:TextBox ID="nameText" runat="server" placeholder="Mahmut" class="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="alert-danger"
                                ErrorMessage="Boş Geçilemez" ControlToValidate="nameText"></asp:RequiredFieldValidator>
                        </div>
                        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Kaydet" OnClick="Button1_Click" />
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
