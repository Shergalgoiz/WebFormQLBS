<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucRight.ascx.cs" Inherits="PhamMinhDuc_Tree.UC.ucRight" %>
<aside id="right">
    <div id="sachbannhieu">
        <p>SÁCH BÁN CHẠY</p>
        <marquee direction="up" scrollamuont="3" scrolldelay="100" onmousemove="stop()" onmouseout="start()">
                    <asp:DataList ID="dlSachBanChay" runat="server">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# "/Images/Sach/"+Eval("HinhMinhHoa") %>' />
                <asp:HyperLink ID="HyperLink1" runat="server" Text='<%# Eval("TenSach") %>'></asp:HyperLink>
            </ItemTemplate>
        </asp:DataList>
        </marquee>
    </div>
    <div id="lienketwbsite">
        <p>LIÊN KẾT WEBSITE KẾT WEBSITE</p>
        <select onchange="window.open(this.options[this.selectedIndex].value,'_ blank')">
            <option selected>-------- Tin Tuc --------</option>
            <option value="http://www.tdmu.edu.vn">ĐH Thủ Dầu Một</option>
            <option value="http://iteee.tdmu.edu.vn">Khoa CNTT</option>
        </select>
    </div>
    <div id="soluottruycap">
        <p>THỐNG KÊ TRUY CẬP</p>
        <h4>Tổng truy cập:
            <asp:Label ID="lbTongTC" runat="server" Text="0"></asp:Label></h4>
        <h4>Đang online:
            <asp:Label ID="lbOnline" runat="server" Text="0"></asp:Label></h4>
    </div>
</aside>
