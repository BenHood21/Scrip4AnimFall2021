
using System;
using UnityEngine;

public class BackgroundBehaviour : MonoBehaviour
{
  public float backgroundSpeed;
  public Renderer backgroundRenderer;

  private void Update()
  {
    backgroundRenderer.material.mainTextureOffset += new Vector2(0f, backgroundSpeed * Time.deltaTime);
  }
}
