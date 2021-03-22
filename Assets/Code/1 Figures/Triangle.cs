﻿using UnityEngine;

public class Triangle : MonoBehaviour
{
    private float side1, side2, side3;
    private float AB, AC, BC, a;
    public float x1, x2, x3;
    public float y1, y2, y3;
    private float height, perimeter, area;
    private string triangleType;
    private bool equilateral, isosceles, scalene;

    void Start()
    {
        GetTriangle();
        GetHeight();
        GetPerimeter();
        GetArea();
    }

    public void Side1()
    {
        AB = Mathf.Sqrt(((y2 - y1) * (y2 - y1)) + ((x2 - x1) * (x2 - x1)));
        side1 = AB;
    }

    public void Side2()
    {
        AC = Mathf.Sqrt(((y3 - y1) * (y3 - y1)) + ((x3 - x1) * (x3 - x1)));
        side2 = AC;
    }

    public void Side3()
    {
        BC = Mathf.Sqrt(((y3 - y2) * (y3 - y2)) + ((x3 - x2) * (x3 - x2)));
        side3 = BC;
    }

    public void EquilateralTriangle()
    {
        equilateral = (side1 == side2 && side2 == side3);
        Debug.Log("Yo soy un triangulo equilatero, mirame soy perfecto ;D");
    }

    public void IsoscelesTriangle()
    {
        isosceles = (side1 != side2 && side2 == side3);
        Debug.Log("Yo soy un triangulo isosceles :D");
    }

    public void ScaleneTriangle()
    {
        scalene = (side1 != side2 && side2 != side3 && side1 != side3);
        Debug.Log("Yo soy un triamgulo escalemno, admmira pojque soi umnico °U°");
    }

    public void GetTriangle()
    {
        switch (triangleType)
        {

        }
    }

    public void GetHeight()
    {
        a = AB - AC;
        height = Mathf.Sqrt(((y3 - a) * (y3 - a)) * ((x3 - a) * (x3 - a)));
    }

    public void GetPerimeter()
    {
        perimeter = (side1 + side2 + side3);
        Debug.Log("El perimetro de tu triangulo es" + perimeter);
    }

    public void GetArea()
    {
        area = (side1 * height) / 2;
        Debug.Log("El area de tu triangulo es" + area);
    }
}
