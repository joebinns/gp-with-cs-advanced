using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private Transform _pointOfRotation;

    [SerializeField] private bool _invert;

    private bool _isShooting;
    
    private void Awake()
    {
        var paddleInput = FindObjectOfType<PaddleInput>().GetComponent<PaddleInput>();
        if (paddleInput != null)
        {
            paddleInput.Shoot += Shoot;
            paddleInput.Return += Shoot;
        }
    }
    
    private void Shoot()
    {
        _isShooting = !_isShooting;
        transform.RotateAround(_pointOfRotation.position, Vector3.up, (_invert ? -1 : 1) * 45f * (_isShooting ? -1 : 1));
    }
}
