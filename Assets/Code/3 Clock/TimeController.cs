using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    TheTime timeController = new TheTime(00, 00, 00);

    private const float secondsOnADay = 86400f;
    private float day;
    public float theHour, theMinute, theSecond;

    public int changeTime;
    public float TimeScale = 1;

    public Text InfernalClock;

    private void Awake()
    {
        if (InfernalClock == null) InfernalClock = GetComponent<Text>();
    }
    void FixedUpdate()
    {
        GiveMeTime();
    }
    public void GiveMeTime()
    {
        day += Time.deltaTime / secondsOnADay;

        float normalizedDay = day % 1;
        float hoursInADay = 24;

        timeController.GetHour = Mathf.Floor(normalizedDay * hoursInADay);

        float minutesInHour = 60;
        timeController.GetMinute = Mathf.Floor(((normalizedDay * hoursInADay) % 1) * minutesInHour);
        float secondsInMinute = 60;
        timeController.GetSecond = Mathf.Floor(((((normalizedDay * hoursInADay) % 1) * minutesInHour) % 1) * secondsInMinute);

        InfernalClock.text = timeController.GetHour + ":" + timeController.GetMinute + " : " + timeController.GetSecond;
    }

    public void ChangeTime()
    {
        timeController.GetSecond = theSecond;
        timeController.GetMinute = theMinute;
        timeController.GetHour = theHour;
        Debug.Log(timeController.GetHour + ":" + timeController.GetMinute + " : " + timeController.GetSecond);
        InfernalClock.text = timeController.GetHour + ":" + timeController.GetMinute + " : " + timeController.GetSecond;
    }
}
