public class Galery
{
    private string genre, publishedYear, status, color;


    //Book Number: 1
public Galery(string agenre, string apublishedYear, string astatus, string acolor)
{
        genre = agenre;
        publishedYear = apublishedYear;
        status = astatus;
        color = acolor;
}

public void Book1()
    {
        Book Book1 = new Book("Depredator300", "Arnold S.R.", "200 p");
        Galery BookA = new Galery("Acción", "1994", "Usado", "Azul y rojo");
    }
    public void Book2()
    {
        Book Book2 = new Book("El Impostor", "Uss Among", "196 p");
        Galery BookA = new Galery("Suspenso", "2019", "Nuevo", "Negro y gris");
    }
    public void Book3()
    {
        Book Book3 = new Book("Depredator300", "Arnold S.R.", "200 p");
        Galery BookA = new Galery("Acción", "1994", "Usado", "Azul y rojo");
    }
    public void Book4()
    {
        Book Book4 = new Book("Gumba Kingdom", "Los hermanos Bros", "560 p");
        Galery BookA = new Galery("Ciencia ficción y fantasía", "1810", "Nuevo", "Marron y rojo");
    }
    public void Book5()
    {
        Book Book5 = new Book("Jurassic Age", "John Hammon", "232 p");
        Galery BookA = new Galery("Acción", "1994", "Usado", "Azul y rojo");
    }
    public void Book6()
    {
        Book Book6 = new Book("Ellos y Derry", "Pen It. Wise", "1200 p");
        Galery BookA = new Galery("Terror", "1986", "Nuevo", "Rojo");
    }
    public void Book7()
    {
        Book Book7 = new Book("La Torre", "Roland Gilead", "340 p");
        Galery BookA = new Galery("Fantasía", "1982", "Nuevo", "Cepia");
    }
    public void Book8()
    {
        Book Book8 = new Book("Newgate", "Edward D. Marshal", "1007 p");
        Galery BookA = new Galery("Aventura", "1760", "Usado", "Rojo");
    }
    public void Book9()
    {
        Book Book9 = new Book("Space Pirates vs Zombie-plants", "Dave", "700 p");
        Galery BookA = new Galery("Ciencia Ficción y Fantasía", "2007", "Nuevo", "Verde");
    }
    public void Book10()
    {
        Book Book10 = new Book("The World", "D. Brando Jostar", "1000 p");
        Galery BookA = new Galery("Acción, aventura, comedia, suspenso", "1987", "Nuevo", "Amarillo");
    }


}

    

