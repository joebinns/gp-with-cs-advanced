using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public enum TransitionPoint : int
    {
        FreezingPoint = 0,
        BoilingPoint = 100
    };

    private TransitionPoint _transitionPoint;

    private void Awake()
    {
        //var _freezingPoint = new TransitionPoint();
        var freezingPoint = TransitionPoint.FreezingPoint;

        var freezingTemp = (int)freezingPoint; // Access the freezing point value
    }
}
