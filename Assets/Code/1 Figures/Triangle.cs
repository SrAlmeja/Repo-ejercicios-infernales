using UnityEngine;

public class Triangle : MonoBehaviour
{
    private float side1, side2, side3;
    private float AB, AC, BC;
    public Vector3 a;
    public Vector3 b;
    public Vector3 c;
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
        AB = (b.x - a.x) * (b.x - a.x);
        side1 = AB;
    }

    public void Side2()
    {
        AC = Mathf.Sqrt(Mathf.Pow((c.x - a.x),2) + Mathf.Pow((c.y - a.y),2));
        side2 = AC;
    }

    public void Side3()
    {
        BC = Mathf.Sqrt(Mathf.Pow((c.x - b.x), 2) + Mathf.Pow((c.y - b.y), 2));
        side3 = BC;
    }


    public void GetTriangle()
    {
        if (side1 == side2 && side2 == side3)
        {
            triangleType = "Equilatero";
            Debug.Log("Yo soy un triangulo equilatero, mirame soy perfecto ;D");
        }

        if (side1 != side2 && side2 == side3)
        {
            triangleType = "Isosceles";
            Debug.Log("Yo soy un triangulo isosceles :D");
        }

        if (side1 != side2 && side2 != side3 && side1 != side3)
        {
            triangleType = "Escaleno";
            Debug.Log("Yo soy un triamgulo escalemno, admmira pojque soi umnico °U°");
        }
    }

    public void GetHeight()
    {
        height = a.y + c.y;
    }

    public void GetPerimeter()
    {
        perimeter = (AB + AC + BC);
        Debug.Log("El perimetro de tu triangulo es" + perimeter);
    }

    public void GetArea()
    {
        area = (side1 * height) / 2;
        Debug.Log("El area de tu triangulo es" + area);
    }
}
