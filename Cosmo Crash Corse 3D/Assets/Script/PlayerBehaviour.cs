
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody rb;
    private Vector2 playerDirection;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    { 
        float directionX = Input.GetAxisRaw("Horizontal"); 
        playerDirection = new Vector3(directionX,0,0).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(playerDirection.x * playerSpeed, 0, 0);
    }
}
