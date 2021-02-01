<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="yatak.aspx.cs" Inherits="otomasyon.yatak" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1 class="h3 mb-2 text-gray-800">Yatak Durumu</h1>

    <div class="row">

        <!-- Area Chart -->
        <div class="col-xl-12 col-lg-12">
            <div class="card shadow mb-4">
                <!-- Card Header - Dropdown -->
                <div
                    class="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                    <h6 class="m-0 font-weight-bold text-primary">Hata</h6>
                </div>
                <!-- Card Body -->
                <div class="card-body">
                    <h1>Yatak Durumu Aktif Edilmemiştir.</h1>
                    <h2>
                        En Kısa Sürede Aktif Edilecektir.
                    </h2>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
