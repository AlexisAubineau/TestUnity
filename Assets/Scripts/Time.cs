using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Time : MonoBehaviour {

    public Text clockText;
    public Text DateText;
    public bool showSeconds;

    private int minutes;
    private int seconds;
    private DateTime time;

    private void Start()
    {
        minutes = -1;
        seconds = -1;

    }

    void FixedUpdate () {
        time = DateTime.Now;

        if (showSeconds)
        {
            if (seconds != time.Second)
            {
                UpdateText();
                seconds = time.Second;
            }
        }

        else
        {
            if (minutes != time.Minute)
            {
                UpdateText();
                minutes = time.Minute;
            }
        }
	}

    void UpdateText()
    {
        clockText.text = time.Hour.ToString("D2") + ":" + time.Minute.ToString("D2");

        DateText.text = time.Date.ToString() + " " + time.Month.ToString() + " " + time.DayOfYear.ToString();
    }
}
