using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhamMinhDuc_Tree.UC
{
    public partial class ucRight : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSachBanChay();
                lbTongTC.Text = Application["Luot_truy_cap"].ToString();
                lbOnline.Text = Application["So_nguoi_online"].ToString();
            }
        }

        private void LoadSachBanChay()
        {
            dlSachBanChay.DataSource = XLDL.GetData("SELECT TOP 5 CTDATHANG.MaSach, TenSach, HinhMinhHoa, SUM(SoLuongBan) AS SoLuongBan FROM dbo.SACH, dbo.CTDATHANG WHERE CTDATHANG.MaSach = SACH.MaSach GROUP BY CTDATHANG.MaSach, TenSach, HinhMinhHoa ORDER BY SUM(SoLuongBan) DESC");
            dlSachBanChay.DataBind();
        }
    }
}