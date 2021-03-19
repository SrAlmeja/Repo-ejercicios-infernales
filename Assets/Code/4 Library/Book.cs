using UnityEngine;

public class Book
{
    //atributes
    private string title, author, pageNumber;

    //Constructors
    //Book information
    public Book(string atitle, string aautor, string apageNumber)
    {
        title = atitle;
        author = aautor;
        pageNumber = apageNumber;
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public string PageNumber
    {
        get { return pageNumber; }
        set { pageNumber = value; }
    }

    public Book()
    {

    }
}