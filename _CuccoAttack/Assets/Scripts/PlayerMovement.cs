using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private Vector2 velocity;
    private float inputAxis;
    public float moveSpeed = 8f;
        private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        HorizontalMovement();
        VerticalMovement(); // Temporaire, à enlever lorsque le saut sera implémenté
    }

    private void HorizontalMovement()
    {
        inputAxis = Input.GetAxis("Horizontal");
        velocity.x = Mathf.MoveTowards(velocity.x, inputAxis * moveSpeed, (moveSpeed + 20f) * Time.deltaTime);

        if (velocity.x > 0f)
        {
            transform.eulerAngles = Vector3.zero;
        } else if (velocity.x < 0f)
        {
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
    }

    private void VerticalMovement() // Temporaire, à enlever lorsque le saut sera implémenté
    {
        inputAxis = Input.GetAxis("Vertical");
        velocity.y = Mathf.MoveTowards(velocity.y, inputAxis * moveSpeed, (moveSpeed + 20f) * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Vector2 position = rb.position;
        position += velocity * Time.fixedDeltaTime;

        rb.MovePosition(position);
    }
}
