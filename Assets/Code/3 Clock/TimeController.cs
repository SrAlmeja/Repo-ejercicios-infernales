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

    public float changeHour;
    public float changeMinute;
    public float changeSecond;

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

        if (timeController.GetHour >= 10)
        {
            InfernalClock.text = timeController.GetHour + ":" + timeController.GetMinute + ":" + timeController.GetSecond;

            if (timeController.GetMinute >= 10)
            {
                InfernalClock.text = timeController.GetHour + ":" + timeController.GetMinute + ":" + timeController.GetSecond;

                if (timeController.GetSecond >= 10)
                {
                    InfernalClock.text = timeController.GetHour + ":" + timeController.GetMinute + ":" + timeController.GetSecond;
                }
                if (timeController.GetSecond <= 9)
                {
                    InfernalClock.text = timeController.GetHour + ":" + timeController.GetMinute + ":" + "0" + timeController.GetSecond;
                }
            }
            if (timeController.GetMinute <= 9)
            {
                InfernalClock.text = timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + timeController.GetSecond;

                if (timeController.GetSecond >= 10)
                {
                    InfernalClock.text = timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + timeController.GetSecond;
                }
                if (timeController.GetSecond <= 9)
                {
                    InfernalClock.text = timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + "0" + timeController.GetSecond;
                }
            }
        }
        if (timeController.GetHour <= 9)
        {
            InfernalClock.text = "0" + timeController.GetHour + ":" + timeController.GetMinute + ":" + timeController.GetSecond;

            if (timeController.GetMinute >= 10)
            {
                InfernalClock.text = "0" + timeController.GetHour + ":" + timeController.GetMinute + ":" + timeController.GetSecond;

                if (timeController.GetSecond >= 10)
                {
                    InfernalClock.text = "0" + timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + timeController.GetSecond;
                }
                if (timeController.GetSecond <= 9)
                {
                    InfernalClock.text = "0" + timeController.GetHour + ":" + timeController.GetMinute + ":" + "0" + timeController.GetSecond;
                }
            }
            if (timeController.GetMinute <= 9)
            {
                InfernalClock.text = "0" + timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + timeController.GetSecond;

                if (timeController.GetSecond >= 10)
                {
                    InfernalClock.text = "0" + timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + timeController.GetSecond;
                }
                if (timeController.GetSecond <= 9)
                {
                    InfernalClock.text = "0" + timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + "0" + timeController.GetSecond;
                }
            }
        }
    }

        public void ChangeTime()
        {
        day += Time.deltaTime / secondsOnADay;

        float normalizedDay = day % 1;
        float hoursInADay = 24;

        changeHour = Mathf.Floor(normalizedDay * hoursInADay);

        float minutesInHour = 60;
        changeMinute = Mathf.Floor(((normalizedDay * hoursInADay) % 1) * minutesInHour);
        float secondsInMinute = 60;
        changeSecond = Mathf.Floor(((((normalizedDay * hoursInADay) % 1) * minutesInHour) % 1) * secondsInMinute);

        if (changeHour >= 10)
        {
            InfernalClock.text = timeController.GetHour + ":" + timeController.GetMinute + ":" + timeController.GetSecond;

            if (timeController.GetMinute >= 10)
            {
                InfernalClock.text = timeController.GetHour + ":" + timeController.GetMinute + ":" + timeController.GetSecond;

                if (timeController.GetSecond >= 10)
                {
                    InfernalClock.text = timeController.GetHour + ":" + timeController.GetMinute + ":" + timeController.GetSecond;
                }
                if (timeController.GetSecond <= 9)
                {
                    InfernalClock.text = timeController.GetHour + ":" + timeController.GetMinute + ":" + "0" + timeController.GetSecond;
                }
            }
            if (timeController.GetMinute <= 9)
            {
                InfernalClock.text = timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + timeController.GetSecond;

                if (timeController.GetSecond >= 10)
                {
                    InfernalClock.text = timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + timeController.GetSecond;
                }
                if (timeController.GetSecond <= 9)
                {
                    InfernalClock.text = timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + "0" + timeController.GetSecond;
                }
            }
        }
        if (timeController.GetHour <= 9)
        {
            InfernalClock.text = "0" + timeController.GetHour + ":" + timeController.GetMinute + ":" + timeController.GetSecond;

            if (timeController.GetMinute >= 10)
            {
                InfernalClock.text = "0" + timeController.GetHour + ":" + timeController.GetMinute + ":" + timeController.GetSecond;

                if (timeController.GetSecond >= 10)
                {
                    InfernalClock.text = "0" + timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + timeController.GetSecond;
                }
                if (timeController.GetSecond <= 9)
                {
                    InfernalClock.text = "0" + timeController.GetHour + ":" + timeController.GetMinute + ":" + "0" + timeController.GetSecond;
                }
            }
            if (timeController.GetMinute <= 9)
            {
                InfernalClock.text = "0" + timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + timeController.GetSecond;

                if (timeController.GetSecond >= 10)
                {
                    InfernalClock.text = "0" + timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + timeController.GetSecond;
                }
                if (timeController.GetSecond <= 9)
                {
                    InfernalClock.text = "0" + timeController.GetHour + ":" + "0" + timeController.GetMinute + ":" + "0" + timeController.GetSecond;
                }
            }
        }
    }
            
    }
    