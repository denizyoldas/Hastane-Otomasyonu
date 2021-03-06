﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="hastaguncelle.aspx.cs" Inherits="otomasyon.hastaguncelle" %>

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
                <div class="col-6">
                    <div class="form-group">
                        <label for="name">Adı</label>
                        <asp:TextBox ID="nameText" runat="server" placeholder="Mahmut" class="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="alert-danger"
                            ErrorMessage="Boş Geçilemez" ControlToValidate="nameText"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="surname">Soyadı</label>
                        <asp:TextBox ID="surnameText" runat="server" placeholder="Tuncar" class="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="alert-danger"
                            ErrorMessage="Boş Geçilemez" ControlToValidate="surnameText"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="tcNo">TC No</label>
                        <asp:TextBox ID="tcNoText" runat="server" placeholder="2315435" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-6">
                    <div class="form-group">
                        <label for="field">Hasta kayıt Tipi</label>
                        <asp:DropDownList ID="fieldDrop" runat="server" class="form-control">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="field">Hasta Alanı</label>
                        <asp:DropDownList ID="statusDrop" runat="server" class="form-control">
                        </asp:DropDownList>
                    </div>
                </div>
                <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Kaydet" OnClick="Button1_Click" />
            </form>
        </div>
    </div>
</asp:Content>
