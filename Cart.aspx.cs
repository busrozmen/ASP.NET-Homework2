using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<int> booklist = new List<int>();
        booklist = (List<int>)Session["Cartt"];//BookInfo da oluşturduğumz session kitap listini, bookliste attık.

        Book book1 = (Book)Session["Book1"];
        Book book2 = (Book)Session["Book2"];
        Book book3 = (Book)Session["Book3"];
        Book book4 = (Book)Session["Book4"];
        Book book5 = (Book)Session["Book5"];


        if (booklist == null)
        {
            //booklist boş ise "Your shopping cart is empty." bilgisini gösteriyoruz.
            lblinfocart.Text = "Your shopping cart is empty.";
        }

        if (booklist != null)
        {
            /*Booklist null değil ise her booklist item i için foreach döngüsü içinde gerekli label,image
             ve panelleri oluşturduk.*/ 
            foreach (var item in booklist)
            {
                Label lblauthor = new Label();
                Label lblpublisher = new Label();
                Label lblpages = new Label();
                Label lblbosluk = new Label();
                Image bookImage = new Image();
                Panel pnl = new Panel();


                //Book classından oluşturduğumuz nesnelerin ıd si ve booklistin içindeki idler eşitse gerekli alanları doldurduk.
                if (book1.BookID == Convert.ToInt32(item.ToString()))
                {                    
                    lblauthor.Text = "Author: " + book1.Author;
                    lblpublisher.Text = "Publisher: " + book1.Publisher;
                    lblpages.Text = "Pages: " + book1.PageNumber.ToString();
                    bookImage.ImageUrl = book1.ImageUrl;
                }
                if (book2.BookID == Convert.ToInt32(item.ToString()))
                {
                    lblauthor.Text = "Author: " + book2.Author;
                    lblpublisher.Text = "Publisher: " + book2.Publisher;
                    lblpages.Text = "Pages: " + book2.PageNumber.ToString();
                    bookImage.ImageUrl = book2.ImageUrl;
                }
                if (book3.BookID == Convert.ToInt32(item.ToString()))
                {
                    lblauthor.Text = "Author: " + book3.Author;
                    lblpublisher.Text = "Publisher: " + book3.Publisher;
                    lblpages.Text = "Pages: " + book3.PageNumber.ToString();
                    bookImage.ImageUrl = book3.ImageUrl;
                }
                if (book4.BookID == Convert.ToInt32(item.ToString()))
                {
                    lblauthor.Text = "Author: " + book4.Author;
                    lblpublisher.Text = "Publisher: " + book4.Author;
                    lblpages.Text = "Pages: " + book4.PageNumber.ToString();
                    bookImage.ImageUrl = book4.ImageUrl;
                }
                if (book5.BookID == Convert.ToInt32(item.ToString()))
                {
                    lblauthor.Text = "Author: " + book5.Author;
                    lblpublisher.Text = "Publisher: " + book5.Publisher;
                    lblpages.Text = "Pages: " + book5.PageNumber.ToString();
                    bookImage.ImageUrl = book5.ImageUrl;
                }

                bookImage.Width = 350;
                bookImage.Height = 500;

                //Arayüz için Cart.aspx de oluşturduğumuz divlere css verdik.
                sol.Attributes["class"] = "divSol";
                sol.Controls.Add(bookImage);//Sol div de sadece fotoğraflar bulunuyor.

                sag.Attributes["class"] = "divSag";
                //Sağ divde labellar bulunuyor.
                sag.Controls.Add(lblpublisher);
                sag.Controls.Add(new LiteralControl("<br /><br />"));
                sag.Controls.Add(lblauthor);
                sag.Controls.Add(new LiteralControl("<br /><br />"));
                sag.Controls.Add(lblpages);
                sag.Controls.Add(new LiteralControl("<br /><br />"));

                sag.Controls.Add(lblbosluk);
                lblbosluk.Height = 410;

                tum.Controls.Add(sol);
                tum.Controls.Add(sag);
                tum.Controls.Add(pnl);
                tum.Attributes["class"] = "tum";

            }
        }
        //Default.aspx e geri dönmek için gerekli link i yerleştirdik.
        son.Attributes["class"] = "son";
        HyperLink returnmain = new HyperLink();
        returnmain.Text = "Return to Main Page";
        returnmain.NavigateUrl = "Default.aspx";
        returnmain.Height = 90;
        tum.Controls.Add(returnmain);
    }
}