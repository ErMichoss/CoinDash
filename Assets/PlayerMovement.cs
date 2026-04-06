using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;

    private bool isOnFloor = false;
    private Rigidbody2D rb;
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(input * speed, rb.linearVelocity.y);

        anim.SetFloat("Speed", Mathf.Abs(input));

        if (input > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (input < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isOnFloor)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isOnFloor = false;
            anim.SetBool("IsJumping", true);
        }
    }

    void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.name == "Floor")
        {
            isOnFloor = true;
            anim.SetBool("IsJumping", false);
        }
    }
}
