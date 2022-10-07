using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourTick : MonoBehaviour
{
    public GameObject Hour;
    // Start is called before the first frame update
    void Start()
    {
       var time =  DateTime.Now;
        var hour = time.Hour;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
