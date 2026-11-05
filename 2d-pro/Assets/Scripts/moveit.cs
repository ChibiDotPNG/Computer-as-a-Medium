using UnityEngine;
using UnityEngine.InputSystem;

public class moveit : MonoBehaviour
{
    public float moveSpeed;
    private float speedX = 0f;
    private float speedY = 0f;
    public Rigidbody2D rb;

    void Start()
    {

    }

    void Update()
    {
        Movement();
    }
    void Movement()
    {
        //X
        if (Keyboard.current.aKey.isPressed)
        {
            speedX = -moveSpeed;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed;
        }
        else
        {
            speedX = 0;
        }
        //Y
        if (Keyboard.current.wKey.isPressed)
        {
            speedY = moveSpeed;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speedY = -moveSpeed;
        }
        else
        {
            speedY = 0;
        }
    

        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}
