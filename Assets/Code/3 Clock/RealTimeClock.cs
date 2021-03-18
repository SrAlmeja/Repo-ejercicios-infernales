using UnityEngine.UI;
using UnityEngine;

public class RealTimeClock : MonoBehaviour
{
    public Text RealClock;

    void Update()
    {
        RealClock.text =
            System.DateTime.Now.Hour.ToString("00") + ":" +
            System.DateTime.Now.Minute.ToString("00") + ":" +
            System.DateTime.Now.Second.ToString("00");
    }
}
