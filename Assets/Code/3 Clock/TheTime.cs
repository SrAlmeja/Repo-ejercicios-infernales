using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TheTime : MonoBehaviour
{
    private int inicialTime;
    private int hour, minute, second;
    public Text clock;
    private float timeSpeed = 1;
    private float hoursTime = 0f;
    private float minutesTime = 0f;
    private float secondsTime = 0f;
    private float scaleInicialTime;
    private float realFrameTime = 0f;

    public TheTime(int ahour, int aminute, int asecond, int atimeUnit)
    {
        hour = ahour;
        minute = aminute;
        second = asecond;
    }

    void Star()
    {
        timeSpeed = scaleInicialTime;

        clock = GetComponent<Text>();

        secondsTime = inicialTime;

        //GetTime(showmeTime);

        
    }

    private void Update()
    {
        realFrameTime = Time.deltaTime * timeSpeed;

        secondsTime += realFrameTime;

        //GetTime(showmeTime);

    }

    public void GetTime(float showmeTime)
    {


        if (showmeTime < 0) showmeTime = 0;

        hour = (int)minutesTime / 3600;
        minute = (int)secondsTime / 60;
        second = (int)secondsTime % 60;

        clock.text = hour + ":" + minute + ":" + second;
    }

}