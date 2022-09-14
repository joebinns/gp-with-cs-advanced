using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Temperature))]
public class Heatmap : MonoBehaviour
{
    [SerializeField] private Texture2D _heatmap;

    private Temperature _temperature;
    
    private void Awake()
    {
        _temperature = GetComponent<Temperature>();
    }
    
    private void UpdateColour()
    {
        var tempPercent = Mathf.Clamp01(_temperature.Temp / 150f); // Divide by whatever the max temp is approximately... (Should max temp be a hard limit?)
        var pixelPos = tempPercent * (_heatmap.width - 1);
        var colour = _heatmap.GetPixel((int)pixelPos, 0);
        GetComponent<Renderer>().material.color = colour;
    }

    private void Update()
    {
        // TODO: If temperature is changing...
        UpdateColour();
    }
}
