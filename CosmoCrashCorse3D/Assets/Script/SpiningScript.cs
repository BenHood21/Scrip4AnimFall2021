using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiningScript : MonoBehaviour
{
    public float yRotationSpeed;
    void Update()
    {
        transform.Rotate(new Vector3(0,yRotationSpeed,0) *Time.deltaTime);       
    }
}
