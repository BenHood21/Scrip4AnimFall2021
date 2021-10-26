
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float playerSpeed;
    public Joystick joystick;
    private float horizontalMove = 5f;
    
    private Rigidbody rb;
   private Vector2 playerDirection;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    { // Youtube Tutorial: TOUCH CONTROLS in Unity! by Brackeys
        if (joystick.Horizontal >= .2f)
        {
            horizontalMove = playerSpeed;
        }
        else if (joystick.Horizontal <= -.2f)
        {
            horizontalMove = -playerSpeed;
        }
        else
        {
            horizontalMove = 0f;
        }
       
        playerDirection = new Vector3(horizontalMove,0,0).normalized;
    }

    private void FixedUpdate()
    {
       
        rb.velocity = new Vector3(playerDirection.x * playerSpeed, 0, 0);
    }
}
