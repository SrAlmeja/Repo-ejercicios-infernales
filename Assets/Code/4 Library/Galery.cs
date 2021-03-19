using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Galery : Book
{
    private string genre, publishedYear, status, color;
    public Book theBooks = new Book("","",""); 

    public Galery(string atitle, string aauthor, string apageNumber,  string agenre, string apublishedYear, string astatus, string acolor)
    {
        Title = atitle;
        Author = aauthor;
        PageNumber = apageNumber;
        genre = agenre;
        publishedYear = apublishedYear;
        status = astatus;
        color = acolor;
    }

    public string Genre
    {
        get { return genre; }
        set { genre = value; }
    }

    public string PublishedYear
    {
        get { return publishedYear; }
        set { publishedYear = value; }
    }

    public string Status
    {
        get { return status; }
        set { status = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public string BookData()
    {
        string info;
            info = Title + Author + PageNumber + Genre + PublishedYear + Status + Color;
        return info;
    }

    public Galery ()
    {

    }
    
public void Book1()
    {
        Galery BookA = new Galery("Depredator300", "Arnold S.R.", "200 p", "Acción", "1994", "Usado", "Azul y rojo");
    }
    public void Book2()
    {
        Galery BookA = new Galery("El Impostor", "Uss Among", "196 p", "Suspenso", "2019", "Nuevo", "Negro y gris");
    }
    public void Book3()
    {
        Galery BookA = new Galery("Depredator300", "Arnold S.R.", "200 p", "Acción", "1994", "Usado", "Azul y rojo");
    }
    public void Book4()
    {
        Galery BookA = new Galery("Gumba Kingdom", "Los hermanos Bros", "560 p", "Ciencia ficción y fantasía", "1810", "Nuevo", "Marron y rojo");
    }
    public void Book5()
    {
        Galery BookA = new Galery("Jurassic Age", "John Hammon", "232 p","Acción", "1994", "Usado", "Azul y rojo");
    }
    public void Book6()
    {
        Galery BookA = new Galery("Ellos y Derry", "Pen It. Wise", "1200 p", "Terror", "1986", "Nuevo", "Rojo");
    }
    public void Book7()
    {
        Galery BookA = new Galery("La Torre", "Roland Gilead", "340 p", "Fantasía", "1982", "Nuevo", "Cepia");
    }
    public void Book8()
    {
        Galery BookA = new Galery("Newgate", "Edward D. Marshal", "1007 p", "Aventura", "1760", "Usado", "Rojo");
    }
    public void Book9()
    {
        Galery BookA = new Galery("Space Pirates vs Zombie-plants", "Dave", "700 p", "Ciencia Ficción y Fantasía", "2007", "Nuevo", "Verde");
    }
    public void Book10()
    {
        Galery BookA = new Galery("The World", "D. Brando Jostar", "1000 p", "Acción, aventura, comedia, suspenso", "1987", "Nuevo", "Amarillo");
    }
    

}

    

