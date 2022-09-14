using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : MonoBehaviour
{
    public bool IsOn { get; private set; } = false;
    public bool Toggle { get; private set; } = false;

    public event Action Light = delegate { };
    public event Action Extinguish = delegate { };

    void Update()
    {
        Toggle = Input.GetKeyDown("space") | Input.GetKeyUp("space");

        if (Toggle)
        {
            IsOn = !IsOn;
            if (IsOn)
            {
                Extinguish();
            }
            else
            {
                Light();
            }
        }
    }
}