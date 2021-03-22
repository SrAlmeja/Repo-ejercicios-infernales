using UnityEngine;

public class Vehículo
{
    private int weight, hight, surface;
    private string color;

    public Vehículo()
    {

    }

    public Vehículo(int aweight)
    {
        weight = aweight;
    }

    public Vehículo(string acolor, int aweight, int ahight, int asurface)
    {
        color = acolor;
        weight = aweight;
        hight = ahight;
        surface = asurface;
    }

    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public int Hight
    {
        get { return hight; }
        set { hight = value; }
    }

    public int Surface
    {
        get { return surface; }
        set { surface = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }
}
