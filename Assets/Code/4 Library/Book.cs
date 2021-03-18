using UnityEngine;

public class Book
{
    //atributes
    private string title, autor, pageNumber;

    //Constructors
    //Book information
    public Book(string atitle, string aautor, string apageNumber)
    {
        title = atitle;
        autor = aautor;
        pageNumber = apageNumber;
    }
}