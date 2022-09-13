using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Temperature))]
public class TemperatureController : MonoBehaviour
{
    
    private Temperature _temperature;
    
    private void Awake()
    {
        _temperature = GetComponent<Temperature>();
        
        var Stove = GetComponent<Stove>();
        if (Stove != null)
        {
            Stove.Light += ToggleHeating;
            Stove.Extinguish += ToggleHeating;
        }
    }

    private bool _isHeating = false;
    
    private void ToggleHeating()
    {
        _isHeating = !_isHeating;
    }

    private void Update()
    {
        _temperature.Temp = 0f;
        if (_isHeating)
        {
            _temperature.Temp = 200f;
        }
    }
}
