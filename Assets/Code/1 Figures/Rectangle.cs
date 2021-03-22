﻿using UnityEngine;

public class Rectangle : MonoBehaviour
{
    private float ab, ac;
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

    public void GetSide()
    {
        ab = Mathf.Sqrt(((y2 - y1) * (y2 - y1)) + ((x2 - x1) * (x2 - x1)));
        ac = Mathf.Sqrt(((y3 - y1) * (y3 - y1)) + ((x3 - x1) * (x3 - x1)));
    }

    public void GetBase()
    {
        theBase = ab;
        Debug.Log("El lado 1 y 3 de tu rectangulo mide" + theBase);
    }

    public void GetHeight()
    {
        height = ac;
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
