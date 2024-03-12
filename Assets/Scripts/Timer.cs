using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float t;
    private Action OnTimerCompleted;
    public delegate void TimerCallBack();

    private TimerCallBack timerCallBack;
    public void SetT(float t, TimerCallBack timerCallBack)
    {
        this.t = t;
        this.timerCallBack += timerCallBack;
    }

    private void Update()
    {
        if (t > 0)
        {
            t -= Time.deltaTime;
            if (isTimerCompleted())
            {
                timerCallBack();
            }
        }
        
        
    }

    public bool isTimerCompleted()
    {
        return t < 0;
    }
}
