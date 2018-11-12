using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            //Book classından nesneleri oluşturduk.
            Book book1 = new Book(1, "ASP.NET 3.5 Unleashed", "Stephen Walther", "Sams", 1920, "Images/1.jpg");
            Book book2 = new Book(2, "ASP.NET Evolution", "Dan Kent", "Sams", 384, "Images/2.jpg");
            Book book3 = new Book(3, "Mastering Web Development with Microsoft Visual Studio 2005 ", "John Paul Mueller", "Sams", 848, "Images/3.jpg");
            Book book4 = new Book(4, "Beginning ASP.NET 2.0", "Chris Hart, John Kauffman,Dave Sussman, and Chris Ullman", "Wrox", 792, "Images/4.jpg");
            Book book5 = new Book(5, "Beginning ASP.NET 3.5 in C# 2008:From Novice to Professional,Second Edition", "Matthew MacDonald", "Apress", 954, "Images/5.jpg");

            // Sessionlara nesneleri ekledik.
            Session["Book1"] = book1;
            Session["Book2"] = book2;
            Session["Book3"] = book3;
            Session["Book4"] = book4;
            Session["Book5"] = book5;

        }
        HttpCookie myCookie = Request.Cookies["UserInfo"];//Login.aspx de oluşturulan cookie yi çağırdık. 

        if (myCookie != null) 
        {
            lblname.Text = "Welcome " + Server.UrlDecode(myCookie.Value);//UrlDecode ile Türkçe karakter kontrolü yaptık.
            linkButton.Visible = false;
            leftside.Style.Add("background-color", "yellow");
            rightside.Visible = true;
        }
        else
        {
            linkButton.Visible = true;
            btnlogout.Visible = false;
            btnshoppingcart.Visible = false;
            lblname.Text = "You are not logged in. Please log in ";
            leftside.Style.Add("background-color", "#99ff99");
            rightside.Visible = false;            
        }
        //GetQueryString ile idleri göndermek için gerekli işlemleri yaptık. 
        string key1 = book1.ID;
        Book kitap1 = (Book)Session[key1];
        book1.NavigateUrl = "BookInfo.aspx?id=" + kitap1.BookID;

        string key2 = book2.ID;
        Book kitap2 = (Book)Session[key2];
        book2.NavigateUrl = "BookInfo.aspx?id=" + kitap2.BookID;

        string key3 = book3.ID;
        Book kitap3 = (Book)Session[key3];
        book3.NavigateUrl = "BookInfo.aspx?id=" + kitap3.BookID;

        string key4 = book4.ID;
        Book kitap4 = (Book)Session[key4];
        book4.NavigateUrl = "BookInfo.aspx?id=" + kitap4.BookID;

        string key5 = book5.ID;
        Book kitap5 = (Book)Session[key5];
        book5.NavigateUrl = "BookInfo.aspx?id=" + kitap5.BookID;
        
    }

    protected void btnlogout_Click(object sender, EventArgs e)
    {
        //Çıkış işlemleri, Cookie silme
        HttpCookie myCookie = Request.Cookies["UserInfo"];
        myCookie.Expires = DateTime.Now.AddMonths(-1);
        Response.Cookies.Add(myCookie);
        myCookie.Value = null;
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}

