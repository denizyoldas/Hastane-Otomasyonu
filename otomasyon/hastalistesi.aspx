<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="hastalistesi.aspx.cs" Inherits="otomasyon.hastalistesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Heading -->
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800">Hasta</h1>
        <a href="hastakayit.aspx" class="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"><i
            class="fas fa-download fa-sm text-white-50"></i>Yeni hasta</a>
    </div>

    <!-- DataTales Example -->
    <div class="card shadow mb-4">
        <div class="card-header py-3">
            <h6 class="m-0 font-weight-bold text-primary">Hasta Listesi</h6>
        </div>
        
        <div class="card-body">
            <div class="table-responsive">
                <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Ad</th>
                            <th>Soyad</th>
                            <th>TcNo</th>
                            <th>Alan</th>
                            <th>Durum</th>
                            <th>İşlem</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>#</th>
                            <th>Ad</th>
                            <th>Soyad</th>
                            <th>TcNo</th>
                            <th>Alan</th>
                            <th>Durum</th>
                            <th>İşlem</th>
                        </tr>
                    </tfoot>
                    <tbody>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%# Eval("id") %></td>
                                    <td><%# Eval("name") %></td>
                                    <td><%# Eval("surname") %></td>
                                    <td><%# Eval("tcNo") %></td>
                                    <td><%# Eval("fieldName") %></td>
                                    <td><%# Eval("statusName") %></td>
                                    <td>
                                        <i class="fa fa-edit fa-sm pr-2" style="color: forestgreen; cursor: pointer" onclick="confirmUpdate(<%#Eval("id")%>)"></i>
                                        <i class="fa fa-trash fa-sm" style="color: red; cursor: pointer" onclick="confirmDelete(<%#Eval("id")%>)"></i>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
