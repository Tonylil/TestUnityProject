﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVar : MonoBehaviour
{
    // Start is called before the first frame update
    public static float num = 0;

    void Update()
    {
        num += Time.deltaTime;
    }
}
