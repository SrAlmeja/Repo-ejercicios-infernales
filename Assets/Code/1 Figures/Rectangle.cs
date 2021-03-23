using UnityEngine;

public class Rectangle : MonoBehaviour
{
    private float AB;
    public float x1, x2;
    public float y1, y2;
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
        theBase = x2 - x1;
        Debug.Log("la base de tu rectangulo (lado 1 y 3) miden: " + theBase);
    }

    public void GetHeight()
    {
        height = y2 - y1;
        Debug.Log("La altura de tu rectangulo (lado 2 y 4) mide: " + height);
    }

    public void GetPerimeter()
    {
        perimeter = (theBase * 2) + (height * 2);
        Debug.Log("El perimetro de tu rectangulo es de: " + perimeter);
    }

    public void GetArea()
    {
        area = theBase * height;
        Debug.Log("El area de tu rectangulo es de: " + area);
    }
}
