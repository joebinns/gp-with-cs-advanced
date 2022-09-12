using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    private float _roomTemp = 25f;

    [SerializeField] private float _temp;
    public float Temp
    {
        get
        {
            return this._temp;
        }
        private set
        {
            this._temp = value;
        } 
    }

    private void Awake()
    {
        _temp = _roomTemp;
    }

    public Collider[] nearbyColliders;

    private void EmitHeat()
    {
        nearbyColliders = Physics.OverlapSphere(transform.position, transform.lossyScale.magnitude * 10f);

        foreach (Collider nearbyCollider in nearbyColliders)
        {
            /*
            var thisCollider = this.GetComponent<Collider>();
            if (nearbyCollider == thisCollider)
            {
                continue; // Why is this not working?
            }
            */

            var nearbyTemperature = nearbyCollider.GetComponent<Temperature>();
            if (nearbyTemperature != null)
            {
                if (nearbyTemperature.Temp == Temp)
                {
                    continue;
                }
                
                if (nearbyTemperature.Temp > Temp)
                {
                    nearbyTemperature.Temp = (nearbyTemperature.Temp + Temp) / 2f;
                }
            }
        }
    }

    private void FixedUpdate()
    {
        EmitHeat();

        var tempDiff = (Temp - _roomTemp);
        Temp -= tempDiff * Time.fixedDeltaTime;
    }
}
