using UnityEngine;

public class playerMovementNew : MonoBehaviour
{
    float horizontalInput;
    float moveSpeed = 10f

    RigidBody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<RigidBody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal")
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y)
    }
}
