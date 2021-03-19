using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public Text clock;
    private float timeInSeconds = 0f;
    private int inicialTime;
    private float timeSpeed; 
    DTimer hour = new DTimer();
    DTimer minute = new DTimer();
    DTimer second = new DTimer();

    // Start is called before the first frame update
    void Start()
    {
        clock = GetComponent<Text>();
        timeSpeed = 1;
        timeInSeconds = inicialTime;
    }

    // Update is called once per frame
    void Update()
    {
        TheClock(timeInSeconds);
    }

    public void TheClock(float timeInSeconds)
    {
        int hour = 0;
        int minute = 0;
        int second = 0;

        if (timeInSeconds < 0) timeInSeconds = 0;

        hour = (int)timeInSeconds / 3600;
        minute = (int)timeInSeconds / 60;
        second = (int)timeInSeconds % 60;
        clock.text =
        hour.ToString("00") + ":" +
        minute.ToString("00") + ":" +
        second.ToString("00");
    }
}
