using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    TheTime timeController = new TheTime(0, 0, 0);

    private const float secondsOnADay = 86400f;
    private float day;
    public float theHour, theMinute, theSecond;

    public int changeTime;
    public float TimeScale = 1;

    public Text textTime;

    private void Awake()
    {
        if (textTime == null) textTime = GetComponent<Text>();
    }
    void FixedUpdate()
    {
        GiveMeTime();
    }
    public void GiveMeTime()
    {
        day += Time.deltaTime / secondsOnADay;

        float normalizedDay = day % 1f;
        float hoursInADay = 24f;

        timeController.GetHour = Mathf.Floor(normalizedDay * hoursInADay);

        float minutesInHour = 60f;
        timeController.GetMinute = Mathf.Floor(((normalizedDay * hoursInADay) % 1f) * minutesInHour);
        float secondsInMinute = 60f;
        timeController.GetSecond = Mathf.Floor(((((normalizedDay * hoursInADay) % 1f) * minutesInHour) % 1f) * secondsInMinute);

        textTime.text = timeController.GetHour + ":" + timeController.GetMinute + " : " + timeController.GetSecond;
    }

    public void ChangeTime()
    {
        timeController.GetSecond = theSecond;
        timeController.GetMinute = theMinute;
        timeController.GetHour = theHour;
        Debug.Log(timeController.GetHour + ":" + timeController.GetMinute + " : " + timeController.GetSecond);
        textTime.text = timeController.GetHour + ":" + timeController.GetMinute + " : " + timeController.GetSecond;
    }
}
