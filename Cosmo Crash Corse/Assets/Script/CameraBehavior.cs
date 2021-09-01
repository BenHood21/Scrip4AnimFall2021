﻿
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public float cameraSpeed;

    void Update()
    {
        transform.position += new Vector3( 0 ,cameraSpeed * Time.deltaTime, 0);
    }
}
