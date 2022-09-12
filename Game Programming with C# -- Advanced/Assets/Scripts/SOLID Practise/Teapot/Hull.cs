using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hull : MonoBehaviour
{
    [SerializeField] private int _maxIntegrity = 100;

    private int _integrity;
    public int Integrity
    {
        get
        {
            return this._integrity;
        }
        private set
        {
            Debug.Log(value);
            this._integrity = value;
        } 
    }

    private const float collisionImpulseDamageThreshold = 3.5f;

    public event Action OnBreak = delegate { };

    private void Awake()
    {
        _integrity = _maxIntegrity;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.impulse.magnitude > collisionImpulseDamageThreshold)
        {
            Integrity -= (int) other.impulse.magnitude;
        }
    }

    
}
