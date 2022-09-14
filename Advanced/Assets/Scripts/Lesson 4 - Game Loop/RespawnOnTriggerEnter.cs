using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOnTriggerEnter : MonoBehaviour
{
    [SerializeField] private Transform _respawnPoint;

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        transform.position = _respawnPoint.position;
        _rb.ResetInertiaTensor();
    }
}
