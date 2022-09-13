using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private float _horizontalInput;
    private float _verticalInput;

    private float _rotationForceMaxMagnitude = 10000f;

    private Rigidbody _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        _rb.AddRelativeTorque(new Vector3(_verticalInput, 0f, -_horizontalInput * 2f) * Time.fixedDeltaTime * _rotationForceMaxMagnitude);
        
        //var angularDisplacement = transform.rotation.eulerAngles - Vector3.zero;

        //_rb.AddRelativeTorque(-angularDisplacement * Time.fixedDeltaTime * _rotationForceMaxMagnitude * 0.1f);
    }
}
