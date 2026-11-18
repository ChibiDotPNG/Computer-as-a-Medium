using UnityEngine;
using UnityEngine.InputSystem;

public class moveit : MonoBehaviour
{
    public float moveSpeed;
    private float speedX = 0f;
    private float speedY = 0f;
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Sprite kLeft;
    public Sprite kRight;
    public Sprite kFront;
    public Sprite kBack;
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
            spriteRenderer.sprite = kLeft;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed;
            spriteRenderer.sprite = kRight;
        }
        else
        {
            speedX = 0;
        }
        //Y
        if (Keyboard.current.wKey.isPressed)
        {
            speedY = moveSpeed;
            spriteRenderer.sprite = kBack;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speedY = -moveSpeed;
            spriteRenderer.sprite = kFront;
        }
        else
        {
            speedY = 0;
        }
    

        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}
