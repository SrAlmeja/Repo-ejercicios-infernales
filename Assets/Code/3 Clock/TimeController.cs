using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    TheTime timeController = new TheTime(0, 0, 0);

    private const float realSecondsDay = 86400f;
    private float day;
    public float newHour, newMinute, newSecond;

    public int changeTime;
    public float scaleTime = 1;

    public Text textTime;

    private void Awake()
    {
        if (textTime == null) textTime = GetComponent<Text>();
    }
    void Update()
    {
        CountTime();
    }
    public void CountTime()
    {
        day += Time.deltaTime / realSecondsDay;

        float dayNormalized = day % 1f;

        float hoursInDay = 24f;

        timeController.GetHour = Mathf.Floor(dayNormalized * hoursInDay);

        float minutesInHour = 60f;
        timeController.GetMinute = Mathf.Floor(((dayNormalized * hoursInDay) % 1f) * minutesInHour);

        float secondsInMinute = 60f;
        timeController.GetSecond = Mathf.Floor(((((dayNormalized * hoursInDay) % 1f) * minutesInHour) % 1f) * secondsInMinute);

        textTime.text = timeController.GetHour + ":" + timeController.GetMinute + " : " + timeController.GetSecond;
    }
    public void ChangeTime()
    {
        timeController.GetSecond = newSecond;
        timeController.GetMinute = newMinute;
        timeController.GetHour = newHour;

        Debug.Log(timeController.GetHour + ":" + timeController.GetMinute + " : " + timeController.GetSecond);
        textTime.text = timeController.GetHour + ":" + timeController.GetMinute + " : " + timeController.GetSecond;
    }
}
