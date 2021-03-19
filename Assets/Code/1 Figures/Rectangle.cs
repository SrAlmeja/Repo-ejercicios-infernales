using UnityEngine;

public class Rectangle : MonoBehaviour
{
    private int wedhtSide;
    private float a, b, c;
    public float x1, x2, x3;
    public float y1, y2, y3;
    private float height, theBase, perimeter, area;


    void Start()
    {
        GetBase();
        GetHeight();
        GetPerimeter();
        GetArea();
    }


    public void GetBase()
    {
        a = x1 + y1;
        b = x2 + y2;
        theBase = a + b;
        Debug.Log("El lado 1 y 3 de tu rectangulo mide" + theBase);
    }

    public void GetHeight()
    {
        a = x1 + y1;
        c = x3 + y3;
        height = a + c;
        Debug.Log("El lado 2 y 4 de tu rectangulo mide" + height);
    }

    public void GetPerimeter()
    {
        perimeter = (theBase * 2) + (height * 2);
        Debug.Log("El perimetro de tu rectangulo es" + perimeter);
    }

    public void GetArea()
    {
        area = theBase * height;
        Debug.Log("El area de tu rectangulo es" + area);
    }
}
