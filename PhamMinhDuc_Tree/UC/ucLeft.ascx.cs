using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhamMinhDuc_Tree.UC
{
    public partial class ucLeft : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getChuDe();
                getNXB();

            }
        }

        private void getChuDe()
        {
            gvChuDe.DataSource = XLDL.GetData("SELECT * FROM CHUDE");
            gvChuDe.DataBind();
        }

        private void getNXB()
        {
            gvNhaXuatBan.DataSource = XLDL.GetData("SELECT MaNXB, TenNXB FROM NHAXUATBAN");
            gvNhaXuatBan.DataBind();
        }
    }
}