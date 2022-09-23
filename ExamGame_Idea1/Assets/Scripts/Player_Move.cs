using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rb;
    public float strength = 6f;
    public float jumpSpeed = 10f;

    public Transform groundCheck;

    public float groundCheckRadius;

    public LayerMask groundLayer;

    private bool isTouchingGround;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // rb.AddForce(new Vector3(1, 0, 0)); // just an example.

        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        if(Input.GetKey(KeyCode.W)&& isTouchingGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }

        rb.velocity = new Vector2(4f, rb.velocity.y);
        //Vector3 targetVelocity = new Vector3(2, 0, 0);
        //Vector3 currentVelocity = rb.velocity;
        //rb.AddForce((targetVelocity - currentVelocity) * strength);

    }

    private void FixedUpdate()
    {
        
    }
}
