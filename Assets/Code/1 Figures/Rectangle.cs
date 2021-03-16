using UnityEngine;

public class Rectangle
{
    private int wedhtSide;
    private float x1, x2, y1, y2;
    private float height, theBase, perimeter, area;


    void Update()
    {
        GetBase();
        GetHeight();
        GetPerimeter();
        GetArea();
    }

    public void GetBase()
    {
        theBase = x1 - x2;
        Debug.Log("El lado 1 y 3 de tu rectangulo mide [0]" + theBase);
    }

    public void GetHeight()
    {
        height = y1 - y2;
        Debug.Log("El lado 2 y 4 de tu rectangulo mide [0]" + height);
    }

    public void GetPerimeter()
    {
        perimeter = (theBase * 2) + (height * 2);
        Debug.Log("El perimetro de tu rectangulo es [0]" + perimeter);
    }

    public void GetArea()
    {
        area = theBase * height;
        Debug.Log("El area de tu rectangulo es [0]" + area);
    }
}
