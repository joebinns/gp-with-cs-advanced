using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Temperature))]
public class Cooling : MonoBehaviour
{
    private float _roomTemp = 25f;
    
    private Temperature _temperature;
    
    private void Awake()
    {
        _temperature = GetComponent<Temperature>();
    }
    
    private void TendToRoom()
    {
        var tempDiff = (_temperature.Temp - _roomTemp);
        _temperature.Temp -= tempDiff * Time.deltaTime * 0.5f;
    }

    private void Update()
    {
        // TODO: If temperature is NOT room temperature...
        TendToRoom();
    }
}
