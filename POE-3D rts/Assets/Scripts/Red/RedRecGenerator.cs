﻿using System.Collections;
using UnityEngine;

public class RedRecGenerator : MonoBehaviour
{
    public MainUIScript resourcer;

    private float nextActionTime = 0.0f;
    public float period = 1f;
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime = Time.time + period;
            resourcer.redRCGenerator(20);
        }
    }



}