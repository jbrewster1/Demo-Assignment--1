using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    [HideInInspector]
    public bool isFacingRight = true;
    [HideInInspector]
    public bool isJumping = false;
    [HideInInspector]
    public bool isGrounded = false;

    public Rigidbody2D rb;

    public float jumpForce = 250.0f;
    public float maxSpeed = 4.0f;

    public Transform groundCheck;
    public LayerMask groundLayers;

    private float groundCheckRadius = 0.2f;

	void Start ()
    {
	
	}
	
	void Update ()
    {
	    if(Input.GetButtonDown("Jump"))
        {
            if(isGrounded == true)
            {
                rb.velocity = new Vector2(rb.velocity.x, 0);
                rb.AddForce(new Vector2(0, jumpForce));
            }
        }
	}

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayers);

        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);
        
        

        if((move > 0.0f && isFacingRight == false) || (move < 0.0f && isFacingRight == true))
        {
            Flip();
        }

    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 playerScale = transform.localScale;
        playerScale.x = playerScale.x * -1;
        transform.localScale = playerScale;
    }
}
