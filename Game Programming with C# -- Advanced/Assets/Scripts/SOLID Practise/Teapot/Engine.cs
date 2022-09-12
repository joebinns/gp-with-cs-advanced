using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private float _forwardInput;

    void Awake()
    {
        _rigidbody = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        _forwardInput = 0;
        if (Input.GetKey("w"))
        {
            _forwardInput = 1;
        }
    }

    void FixedUpdate()
    {
        _rigidbody.AddForce(Vector3.forward * _forwardInput * 10);
    }
}
