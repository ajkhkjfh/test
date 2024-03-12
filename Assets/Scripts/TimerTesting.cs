using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTesting : MonoBehaviour
{
    [SerializeField] private Timer timer;

    private bool hasTimerCompleted;
    
    private void Start()
    {
        timer.SetT(1f,ff);
    }

    void ff()
    {
        Debug.Log(222);
    }
}
