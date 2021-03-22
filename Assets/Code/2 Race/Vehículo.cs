using UnityEngine;

public class Vehículo
{
    private float weight, height;
    private int surface;
    private string color;

    public Vehículo()
    {

    }

    public Vehículo(float aweight)
    {
        weight = aweight;
    }


    public Vehículo(int asurface)
    {
        surface = asurface;
    }

    public Vehículo(string acolor, float aweight, float aheight, int asurface)
    {
        color = acolor;
        weight = aweight;
        height = aheight;
        surface = asurface;
    }

    public float Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public float Height
    {
        get { return height; }
        set { height = value; }
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
