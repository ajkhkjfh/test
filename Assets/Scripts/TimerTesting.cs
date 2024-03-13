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
        timer.SetT(1f,()=>
        {
            Debug.Log(222);
        });
    }

    void ff()
    {
        Debug.Log(222);
    }
}
