using UnityEngine;

public class Triangle
{
    private int side1, side2, side3;
    private int x1, x2, y1;
    private float height, theBase, perimeter, area;
    private string triangleType;
    private bool equilateral, isosceles, scalene;

    void Update()
    {
        GetTriangle();
        GetHeight();
        GetPerimeter();
        GetArea();
    }

    public void Side1()
    {
        side1 = x1 - x2;
    }

    public void Side2()
    {
        side2 = x1 - y1;
    }

    public void Side3()
    {
        side3 = x2 - y1;
    }

    public void GetTriangle()
    {

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
