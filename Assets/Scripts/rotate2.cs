﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate2 : MonoBehaviour
{
   // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, -100) * Time.deltaTime);
    }
}