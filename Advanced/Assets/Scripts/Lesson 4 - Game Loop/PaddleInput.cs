using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleInput : MonoBehaviour
{
    private bool _shootInput;
    
    public bool IsOn { get; private set; } = false;
    public bool Toggle { get; private set; } = false;
    
    public event Action Shoot = delegate { };
    public event Action Return = delegate { };
    
    private void Update()
    {
        Toggle = Input.GetKeyDown("space") | Input.GetKeyUp("space");

        if (Toggle)
        {
            IsOn = !IsOn;
            if (IsOn)
            {
                Shoot();
            }
            else
            {
                Return();
            }
        }
    }
}
