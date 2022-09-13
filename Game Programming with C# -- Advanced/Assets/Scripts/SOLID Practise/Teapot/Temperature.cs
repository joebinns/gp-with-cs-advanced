using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Temperature : MonoBehaviour
{

    [SerializeField] private float _temp;
    
    public float Temp
    {
        get => this._temp;
        set => this._temp = value;
    }
}
