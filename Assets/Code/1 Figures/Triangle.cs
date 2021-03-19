using UnityEngine;

public class Triangle : MonoBehaviour
{
    private int side1, side2, side3;
    private int a, b, c;
    public int x1, x2, x3;
    public int y1, y2, y3;
    private float height, theBase, perimeter, area;
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
        a = x1 + y1;
        b = x2 + y2;
        side1 = a + b;
    }

    public void Side2()
    {
        c = x3 + y3;
        side2 = b + c;
    }

    public void Side3()
    {
        side3 = c + a;
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
        height = y1;
        Debug.Log("El lado 2 y 4 de tu triangulo mide" + height);
    }

    public void GetPerimeter()
    {
        perimeter = (theBase * 2) + (height * 2);
        Debug.Log("El perimetro de tu triangulo es" + perimeter);
    }

    public void GetArea()
    {
        area = theBase * height;
        Debug.Log("El area de tu triangulo es" + area);
    }
}
