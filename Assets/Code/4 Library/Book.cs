using UnityEngine;

public class Book
{
    //atributes
    private int title, author, pageNumber;

    //Constructors
    //Book information
    public Book(int atitle, int aautor, int apageNumber)
    {
        title = atitle;
        author = aautor;
        pageNumber = apageNumber;
    }

    public int Title
    {
        get { return title; }
        set { title = value; }
    }

    public int Author
    {
        get { return author; }
        set { author = value; }
    }

    public int PageNumber
    {
        get { return pageNumber; }
        set { pageNumber = value; }
    }

    public Book()
    {

    }
}