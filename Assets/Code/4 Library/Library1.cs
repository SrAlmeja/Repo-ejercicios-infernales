using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Library1 : MonoBehaviour
{
    public Galery theGalery = new Galery(0, 0, 0, 0, 0, 0, 0);
    private int libraryCapacity;

    [SerializeField] private GameObject DestroyButton;
        [SerializeField] private GameObject Destroy1;
        [SerializeField] private GameObject Destroy2;
        [SerializeField] private GameObject Destroy3;
    [SerializeField] private GameObject CreateButton;
    [SerializeField] private GameObject ShowButton;

    public int LibraryCapacity
    {
        get { return libraryCapacity; }
        set { libraryCapacity = value; }
    }

    List<Galery> theList = new List<Galery>();

    void Awake()
    {
        LibraryCapacity = 6;
        Debug.Log("Libreria casi llena, espacio disponible:" + LibraryCapacity);
        DestroyButton.SetActive(false);
            Destroy1.SetActive(false);
            Destroy2.SetActive(false);
            Destroy3.SetActive(false);
    }
    public Galery GenerateBook()
    {
        if (LibraryCapacity > 0)
        {
            //books.Add(extrabook);
            theGalery.Title = Random.Range(1, 10);
            theGalery.Author = Random.Range(1, 10);
            theGalery.PageNumber = Random.Range(196, 1200);
            theGalery.Genre = Random.Range(1, 10);
            theGalery.PublishedYear = Random.Range(1760, 2019);
            theGalery.Status = Random.Range(1, 3);
            theGalery.Color = Random.Range(1, 10);
        }
        return theGalery;
    }
    public void ButtonReplace()
    {
        Destroy1.SetActive(true);
        Destroy2.SetActive(true);
        Destroy3.SetActive(true);
    }
    void GetInfo(int index)
    {
        Galery temporal = theList[index];
        theList.RemoveAt(index);
    }
    public void RemoveBookOne()
    {
        theList.RemoveAt(1);
    }
    public void RemoveBookTwo()
    {
        theList.RemoveAt(2);
    }
    public void RemoveBookThree()
    {
        theList.RemoveAt(3);
    }
    public void AddBook(Galery bookTest)
    {
        if (theList.Count < 3)
        {
            Print(bookTest);
            theList.Add(bookTest);
        }
        else
        {
            DestroyButton.SetActive(true);
            Debug.Log("Libreria llena, proceder a la suicidación si no se libera espacio.");
        }
    }
    public void AddBookButton()
    {
        AddBook(GenerateBook());
    }
    public void Print(Galery bookOne)
    {
        switch (bookOne.Title)
        {
            case 1:
                {
                    Debug.Log("Libro: Depredator300");
                    break;
                }
            case 2:
                {
                    Debug.Log("Libro: El Impostor");
                    break;
                }
            case 3:
                {
                    Debug.Log("Libro: Gumba Kingdom");
                    break;
                }
            case 4:
                {
                    Debug.Log("Libro: Jurassic Age");
                    break;
                }
            case 5:
                {
                    Debug.Log("Libro: Ellos y Derry");
                    break;
                }
            case 6:
                {
                    Debug.Log("Libro: La Torre");
                    break;
                }
            case 7:
                {
                    Debug.Log("Libro: Newgate");
                    break;
                }
            case 8:
                {
                    Debug.Log("Libro: Space Pirates vs Zombie-plants");
                    break;
                }
            case 9:
                {
                    Debug.Log("Libro The World");
                    break;
                }
        }

        switch (bookOne.Author)
        {
            case 1:
                {
                    Debug.Log("Autor: Arnold S.R.");
                    break;
                }
            case 2:
                {
                    Debug.Log("Autor: Uss Among");
                    break;
                }
            case 3:
                {
                    Debug.Log("Autor: Los hermanos Bros");
                    break;
                }
            case 4:
                {
                    Debug.Log("Autor: John Hammon");
                    break;
                }
            case 5:
                {
                    Debug.Log("Autor: Pen It. Wise");
                    break;
                }
            case 6:
                {
                    Debug.Log("Autor: Roland Gilead");
                    break;
                }
            case 7:
                {
                    Debug.Log("Autor: Edward D. Marshall");
                    break;
                }
            case 8:
                {
                    Debug.Log("Autor: Dave");
                    break;
                }
            case 9:
                {
                    Debug.Log("Autor:  D. Brando Jostar");
                    break;
                }

        }
        if (bookOne.PageNumber > 0)
        {
            Debug.Log("Número de páginas: " + bookOne.PageNumber);
        }

        switch (bookOne.Genre)
        {
            case 1:
                {
                    Debug.Log("Género: Acción");
                    break;
                }
            case 2:
                {
                    Debug.Log("Género: Sespenso");
                    break;
                }
            case 3:
                {
                    Debug.Log("Género: Ciencia Ficción & Fantasía");
                    break;
                }
            case 4:
                {
                    Debug.Log("Género: Acción");
                    break;
                }
            case 5:
                {
                    Debug.Log("Género: Terror");
                    break;
                }
            case 6:
                {
                    Debug.Log("Género: Fantasía");
                    break;
                }
            case 7:
                {
                    Debug.Log("Género: Aventura");
                    break;
                }
            case 8:
                {
                    Debug.Log("Género: Ciencia Ficción y Fantasía");
                    break;
                }
            case 9:
                {
                    Debug.Log("Género: Acción, aventura, drama, comedia, suspenso");
                    break;
                }

        }
        if (bookOne.PublishedYear > 0)
        {
            Debug.Log("Año de publicación: " + bookOne.PublishedYear);
        }
        switch (bookOne.Status)
        {
            case 1:
                {
                    Debug.Log("Estado: Usado");
                    break;
                }
            case 2:
                {
                    Debug.Log("Estado: Nuevo");
                    break;
                }
        }

        switch (bookOne.Color)
        {
            case 1:
                {
                    Debug.Log("Color de Portada: Azul & rojo");
                    break;
                }
            case 2:
                {
                    Debug.Log("Color de Portada: Negro & gris");
                    break;
                }
            case 3:
                {
                    Debug.Log("Color de Portada: NegroMarrón & rojo");
                    break;
                }
            case 4:
                {
                    Debug.Log("Color de Portada: Rojo & azul");
                    break;
                }
            case 5:
                {
                    Debug.Log("Color de Portada: Rojo");
                    break;
                }
            case 6:
                {
                    Debug.Log("Color de Portada: Cépia");
                    break;
                }
            case 7:
                {
                    Debug.Log("Color de Portada: Rojo");
                    break;
                }
            case 8:
                {
                    Debug.Log("Color de Portada: Verde");
                    break;
                }
            case 9:
                {
                    Debug.Log("Color de Portada: Amarillo");
                    break;
                }
        }

    }
}


