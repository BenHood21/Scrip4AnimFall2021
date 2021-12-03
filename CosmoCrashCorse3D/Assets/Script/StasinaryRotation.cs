using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StasinaryRotation : MonoBehaviour
{
  // Animations Basics! How to Rotate Objects [Unity 2018 tutorial for beginners] by OXMOND Tutorials on YouTube
    void Update()
    {
        transform.Rotate(new Vector3(0f,50f,0f)*Time.deltaTime);
    }
}
