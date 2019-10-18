<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHeader.ascx.cs" Inherits="PhamMinhDuc_Tree.UC.ucHeader" %>
<header>
    <div id="logo">
        <img src="Images/LOGO.jpg">
    </div>
    <div id="dn">
        <img src="Images/dangnhap.jpg" title="Đăng nhập">
        <a href="Dangnhap.html">Đăng nhập</a>
        <a href="Dangky.html">Đăng ký</a>
        <a href="#">
            <img src="Images/Giohang.gif" title="Giỏ hàng" />Giỏ hàng<span>(<asp:Label ID="lbTongSL" runat="server" Text="trống"></asp:Label>)</span></a>
    </div>
</header>
<nav>
    <div id="subnav">
        <ul>
            <li><a href="Trangchu.html">TRANG CHỦ</a></li>
            <li><a href="Gioithieu.html">GIỚI THIỆU</a></li>
            <li><a href="#">LIÊN HỆ</a></li>
        </ul>
        <div id="search">
            <input type="text" size="36" name="tsearch" placeholder="Hãy nhập tên sách cần tìm. . .">
            <input type="submit" value="Tìm sách" title="Tìm sách">
        </div>
    </div>
</nav>
