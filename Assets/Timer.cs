using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float seconds = 0f;
    public float minutes = 2f;
    [HideInInspector]public float temp = 2f;

    private void Start()
    {
        temp = minutes;
    }
    private void Update()
    {
        seconds -= 1 * Time.deltaTime;
        if(timerText != null )
        {
            timerText.text = minutes.ToString("0") + (":") + seconds.ToString("0");
        }

        if (seconds <= 0) 
        {
            if (minutes > 0)
            {
                minutes -= 1;
                seconds = 60;
            }
            else
            {
                seconds = 0;
                Debug.Log("done");
            }
        }
    }
}
