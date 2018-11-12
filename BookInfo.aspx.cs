using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookInfo : System.Web.UI.Page
{
    int id;
    List<int> cartt1;
    List<int> cartt2;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Cartt"] == null)
        {
            Session["Cartt"] = new List<int>();
        }
        else
        {
            List<int> cartt = (List<int>)Session["Cartt"];
        }
        //Oluşturduğumuz session nesnelerini Book classından nesnelere attık.
        Book book1 = (Book)Session["Book1"];
        Book book2 = (Book)Session["Book2"];
        Book book3 = (Book)Session["Book3"];
        Book book4 = (Book)Session["Book4"];
        Book book5 = (Book)Session["Book5"];

        //İd girilmemişse "Please specify a book ID!" hatası verecek.
        if ((Request.QueryString["id"]) == null)
        {
            lblpublisher.Visible = false;
            lblpages.Visible = false;
            lblauthor.Visible = false;
            bookImage.Visible = false;
            btnaddtocart.Visible = false;
            displayshoppingcart.Visible = false;
            lbltitle.Text = "Please specify a book ID!";
        }
        else if ((Request.QueryString["id"]) != null)
        {
            // Null değilse, geçerli idler girildiğinde bilgiler gözükecek.
            lblpublisher.Visible = true;
            lblpages.Visible = true;
            lblauthor.Visible = true;
            bookImage.Visible = true;
            btnaddtocart.Visible = true;
            displayshoppingcart.Visible = true;
            if (book1.BookID == Convert.ToInt32(Request.QueryString["id"]))
            {
                lbltitle.Text = book1.Title;
                lblauthor.Text = "Author: " + book1.Title;
                lblpublisher.Text = "Publisher: " + book1.Publisher;
                lblpages.Text = "Pages: " + book1.PageNumber.ToString();
                bookImage.ImageUrl = book1.ImageUrl;
            }
            else if (book2.BookID == Convert.ToInt32(Request.QueryString["id"]))
            {
                lbltitle.Text = book2.Title;
                lblauthor.Text = "Author: " + book2.Title;
                lblpublisher.Text = "Publisher: " + book2.Publisher;
                lblpages.Text = "Pages: " + book2.PageNumber.ToString();
                bookImage.ImageUrl = book2.ImageUrl;
            }
            else if (book3.BookID == Convert.ToInt32(Request.QueryString["id"]))
            {
                lbltitle.Text = book3.Title;
                lblauthor.Text = "Author: " + book3.Title;
                lblpublisher.Text = "Publisher: " + book3.Publisher;
                lblpages.Text = "Pages: " + book3.PageNumber.ToString();
                bookImage.ImageUrl = book3.ImageUrl;
            }
            else if (book4.BookID == Convert.ToInt32(Request.QueryString["id"]))
            {
                lbltitle.Text = book4.Title;
                lblauthor.Text = "Author: " + book4.Title;
                lblpublisher.Text = "Publisher: " + book4.Publisher;
                lblpages.Text = "Pages: " + book4.PageNumber.ToString();
                bookImage.ImageUrl = book4.ImageUrl;
            }
            else if (book5.BookID == Convert.ToInt32(Request.QueryString["id"]))
            {
                lbltitle.Text = book5.Title;
                lblauthor.Text = "Author: " + book5.Title;
                lblpublisher.Text = "Publisher: " + book5.Publisher;
                lblpages.Text = "Pages: " + book5.PageNumber.ToString();
                bookImage.ImageUrl = book5.ImageUrl;
            }
            else
            {
                // Null değilse, geçersiz bir id girildiğinde "Invalid book ID!." hatası verecek.
                lblpublisher.Visible = false;
                lblpages.Visible = false;
                lblauthor.Visible = false;
                bookImage.Visible = false;
                btnaddtocart.Visible = false;
                displayshoppingcart.Visible = false;
                lblbookaddedinfo.Visible = false;
                lbltitle.Text = "Invalid book ID!";
            }
        }

    }

    protected void btnaddtocart_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(Request.QueryString["id"]);

        cartt1 = new List<int>();
        cartt1 = (List<int>)Session["Cartt"];
        cartt2 = new List<int>();

        if (Session["Cartt"] == null)
        {
            /*Session null ise kitabın Idsini oluşturduğumuz cartt1 listesine ekliyoruz.Oluşturduğumuz listenin silinmemesi için sessiona atıyoruz
            ve bu sessionu cartt2 listesine ekliyoruz. */
            cartt1.Add(id);
            lblbookaddedinfo.Text = "Book is added to the shopping cart.";
            Session["Cartt"] = cartt1;
            cartt2 = (List<int>)Session["Cartt"];
        }
        else if (cartt1.Contains(id))
        {
            //Cartt1 de ıd kontrolü yapıyoruz.eğer ıd listede varsa "Book is already in the list!" bilgisini verecek ve tekrar ekleme yapmayacak.
            lblbookaddedinfo.Text = "Book is already in the list!";
        }
        else
        {
            //Cartt1 listesi boş değil ve eklenecek olan ıd listede yoksa yeni ıd yi ekliyoruz.
            cartt1.Add(id);
            lblbookaddedinfo.Text = "Book is added to the shopping cart.";
            Session["Cartt"] = cartt1;
            cartt2 = (List<int>)Session["Cartt"];
        }
    }
}


