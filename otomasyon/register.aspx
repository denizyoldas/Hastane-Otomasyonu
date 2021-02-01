<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="otomasyon.register" %>

<!DOCTYPE html>

<!DOCTYPE html>
<html lang="tr">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Hastane Otomasyon Sistemi</title>

    <!-- Custom fonts for this template-->

    <!-- Custom styles for this template-->
    <link href="Content/sb-admin-2.css" rel="stylesheet">

</head>

<body class="bg-gradient-primary">

    <div class="container">

        <!-- Outer Row -->
        <div class="row justify-content-center">

            <div class="col-xl-10 col-lg-12 col-md-9">

                <div class="card o-hidden border-0 shadow-lg my-5">
                    <div class="card-body p-0">
                        <!-- Nested Row within Card Body -->
                        <div class="row" style="min-height: 80vh">
                            <div class="col-lg-6 d-none d-lg-block bg-login-image"></div>
                            <div class="col-lg-6">
                                <div class="p-5">
                                    <div class="text-center">
                                        <h1 class="h4 text-gray-900 mb-4">Lütfen Yönetici Kaydı Yapınız</h1>
                                        <h5 style="color: red;"><asp:Label ID="hata" runat="server" Text=""></asp:Label></h5>
                                        <h5><asp:Label ID="onay" runat="server" Text=""></asp:Label></h5>
                                    </div>
                                    <form class="username" runat="server">
                                        <div class="form-group">
                                            <asp:TextBox ID="username" runat="server" class="form-control form-control-user" placeholder="ad Soyad Giriniz..."></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox ID="email" runat="server"  class="form-control form-control-user" placeholder="Email Giriniz..."></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox ID="password" runat="server"  class="form-control form-control-user" placeholder="Şifre Giriniz..."></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox ID="passwordverfy" runat="server" class="form-control form-control-user" placeholder="Şifrenizi doğrulayın..."></asp:TextBox>
                                        </div>
                                        <asp:Button ID="Button2" runat="server" Text="Kaydet" class="btn btn-primary btn-user btn-block" OnClick="Button2_Click"/>
                                        <h6><asp:HyperLink ID="link" runat="server" NavigateUrl="login.aspx">Giriş Yap</asp:HyperLink></h6>
                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>

    </div>

    <!-- Bootstrap core JavaScript-->
    <script src="Scripts/jquery-3.4.1.js"></script>
    <script src="Scripts/bootstrap.bundle.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="Scripts/jquery.easing.min.js"></script>

    <!-- Custom scripts for all pages-->
    <script src="Scripts/sb-admin-2.js"></script>

</body>
