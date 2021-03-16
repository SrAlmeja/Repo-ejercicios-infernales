using UnityEngine;

public class Rectangle
{
    //Atributes
    private int widthSideLenght, longSideLeight, baseResult, perimeter, area;
    private int x1, x2, x3, x4, y1, y2, y3, y4;



    public int WidthSide
    {
        get { return widthSideLenght;  }
        set
        {
            if (value == 0)
            {
                widthSideLenght = value;
            }
            else
            {
                widthSideLenght = 0;
            }
        }
    }

    public int LongSide
    {
        get { return widthSideLenght; }
        set
        {
            if (value == 0)
            {
                widthSideLenght = value;
            }
            else
            {
                widthSideLenght = 0;
            }
        }
    }
}
