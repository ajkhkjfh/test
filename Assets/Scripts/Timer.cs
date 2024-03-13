using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float t;
    private Action onTimerCompleted;
    public delegate void TimerCallBack();

    private TimerCallBack timerCallBack;
    public void SetT(float t, Action onTimerCompleted)
    {
        this.t = t;
        this.onTimerCompleted = onTimerCompleted;
    }

    private void Update()
    {
        if (t > 0)
        {
            t -= Time.deltaTime;
            if (isTimerCompleted())
            {
                onTimerCompleted();
            }
        }
        
        
    }

    public bool isTimerCompleted()
    {
        return t < 0;
    }
}
