using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Galery : Book
{
    private int genre, publishedYear, status, color;
    public Book theBooks = new Book(0,0,0); 

    public Galery(int atitle, int aauthor, int apageNumber,  int agenre, int apublishedYear, int astatus, int acolor)
    {
        Title = atitle;
        Author = aauthor;
        PageNumber = apageNumber;
        genre = agenre;
        publishedYear = apublishedYear;
        status = astatus;
        color = acolor;
    }

    public int Genre
    {
        get { return genre; }
        set { genre = value; }
    }

    public int PublishedYear
    {
        get { return publishedYear; }
        set { publishedYear = value; }
    }

    public int Status
    {
        get { return status; }
        set { status = value; }
    }

    public int Color
    {
        get { return color; }
        set { color = value; }
    }

    public string BookData()
    {
        string info;
            info = Title.ToString() + Author.ToString() + PageNumber.ToString() + Genre.ToString() + PublishedYear.ToString() + Status.ToString() + Color.ToString();
        return info;
    }

    public Galery ()
    {

    }


}

    

