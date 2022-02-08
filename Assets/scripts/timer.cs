using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float time;
    private float timeRemain;
    public static int display_number;
    public Text timerText;

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            timeRemain = time -= Time.deltaTime;
            display_number = (int)timeRemain;
        }
        timerText.text = "Seconds : " + display_number.ToString();
    }
}
