using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    [SerializeField] private Shape[] shapes;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BeginTest();
        }
    }
    

    public async void BeginTest()
    {
        var tasks = new Task[shapes.Length];
        for (int i = 0; i < shapes.Length; i++)
        {
            tasks[i]=shapes[i].RotateForSeconds(1 + 1 * i);
        }

        await Task.WhenAll(tasks);
        
        Debug.Log("Finished");
    }
}
