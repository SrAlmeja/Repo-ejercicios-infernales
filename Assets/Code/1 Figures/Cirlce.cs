using UnityEngine;

public class Circle
{
    private int pi;
    private float x1, x2;
    private float radious, diameter, perimeter, area;

    void Update()
    {
        GetRadious();
        GetDiameter();
        GetPerimeter();
        GetArea();
    }

    public void GetRadious()
    {
        radious = x1 - x2;
        Debug.Log("El radio de tu circulo mide [0]" + radious);
    }

    public void GetDiameter()
    {
        diameter = radious *2;
        Debug.Log("El diametro de tu circulo mide [0]" + diameter);
    }

    public void GetPerimeter()
    {
        perimeter = 3.1416f * diameter;
        Debug.Log("El perimetro de tu rectangulo es [0]" + perimeter);
    }

    public void GetArea()
    {
        area = 3.1416f * (radious * radious);
        Debug.Log("El area de tu circulo es [0]" + area);
    }
}
