﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransVida : MonoBehaviour
{
    public float hız;
    void Update()
    {
        transform.Translate(0, -1 * hız * Time.deltaTime, 0);
    }
}