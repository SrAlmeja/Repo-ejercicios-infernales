using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DTimer
{
    private int hours;
    private int minutes;
    private int seconds;

    public DTimer(int ahours, int aminutes, int aseconds)
    {
        hours = ahours;
        minutes = aminutes;
        seconds = aseconds;
    }
    
    //getTime & getTime
    public int Hours
    {
        get { return hours; }
        set { hours = value; }

    }

    public int Minutes
    {
        get { return minutes; }
        set { minutes = value; }
    }

    public int Seconds
    {
        get { return seconds; }
        set
        { seconds = value; }
    }




// Start is called before the first frame update
void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetTime(float secondsTime)
    {
        if (secondsTime < 0) secondsTime = 0;

        hours = (int)secondsTime / 3600;
        minutes = (int)secondsTime / 60;
        seconds = (int)secondsTime % 60;
    }
}

