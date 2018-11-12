using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        //Cookie oluşturduk.
        HttpCookie myCookie = new HttpCookie("UserInfo");
        myCookie.Value = Server.UrlEncode(txtfname.Text + " " + txtlname.Text);//UrlEncode ile Türkçe karakter kontrolü
        myCookie.Expires = DateTime.Now.AddMonths(1);
        Response.Cookies.Add(myCookie);
        
        Response.Redirect("Default.aspx");

    }
}