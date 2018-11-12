using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Book
/// </summary>

public class Book
{

    private int bookID;
    public int BookID
    {
        get { return bookID; }
        set { bookID = value; }
    }

    private string title;
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    private string author;
    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    private string publisher;
    public string Publisher
    {
        get { return publisher; }
        set { publisher = value; }
    }

    private int pagenumber;
    public int PageNumber
    {
        get { return pagenumber; }
        set { pagenumber = value; }
    }

    private string imageurl;
    public string ImageUrl
    {
        get { return imageurl; }
        set { imageurl = value; }
    }

    public Book(int bookID, string title, string author, string publisher, int pagenumber, string imageurl)
    {
        BookID = bookID;
        Title = title;
        Author = author;
        Publisher = publisher;
        PageNumber = pagenumber;
        ImageUrl = imageurl;
    }
}