using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;

    private bool isOnFloor = false;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(input * speed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isOnFloor)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isOnFloor = false;
        }
    }

    void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.name == "Floor")
        {
            isOnFloor = true;
        }
    }
}
