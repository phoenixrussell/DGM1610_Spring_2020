﻿
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    void LateUpdate()
    {
        transfrom.position = target.position;
    }
}