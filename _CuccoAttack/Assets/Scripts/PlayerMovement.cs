using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private Vector2 velocity;
    private float inputAxis;

    public float lastInput;
    public float moveSpeed = 20f;
    public float maxJumpHeight = 5f;
    public float maxJumpTime = 1f;
    public float jumpForce => (2f * maxJumpHeight) / (maxJumpTime / 2f);
    public float gravity => (-2f * maxJumpHeight) / Mathf.Pow((maxJumpTime / 2f), 2);
    public bool grounded {get; private set;}
    public bool jumping {get; private set;}


        private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        HorizontalMovement();
        grounded = rb.Raycast(Vector2.down);
        if (grounded) {
            GroundedMovement();
        }
        
        ApplyGravity();
    }

    private void HorizontalMovement()
    {

        inputAxis = Input.GetAxis("Horizontal");

        velocity.x = Mathf.MoveTowards(velocity.x, inputAxis * moveSpeed, moveSpeed * Time.deltaTime);



        if (velocity.x > 0f)
        {
            transform.eulerAngles = Vector3.zero;
        } else if (velocity.x < 0f)
        {
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }


    }

    private void GroundedMovement()
    {
        velocity.y = Mathf.Max(velocity.y, 0f);
        jumping = velocity.y > 0f;
        if (Input.GetButtonDown("Jump"))
        {
            velocity.y = jumpForce;
            jumping = true;
        }
        if (inputAxis == 0) // permet de "braker" si la direction change
        {
             velocity.x /= 1.03f;
        }
        if (Math.Sign(inputAxis) != Math.Sign(lastInput))
        {
            velocity.x /= 3f;
        }
        lastInput = inputAxis;
    }

    private void ApplyGravity()
    {
        bool falling = velocity.y < 0f || !Input.GetButton("Jump");
        float multiplier = falling ? 2f : 1f;
        velocity.y += gravity * multiplier * Time.deltaTime;
        velocity.y = Mathf.Max(velocity.y, gravity / 2f);
    }

    private void CheckWallCollision()
    {
        if (rb.Raycast(Vector2.right))
        {
            if (velocity.x > 0)
            {
                velocity.x = 0;
            }
        }
        if (rb.Raycast(Vector2.left))
        {
            if (velocity.x < 0)
            {
                velocity.x = 0;
            }
        }
    }



    private void FixedUpdate()
    {
        Vector2 position = rb.position;
        position += velocity * Time.fixedDeltaTime;

        rb.MovePosition(position);
    }
}
