using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
      rb.linearVelocityX = 0;
      if (Input.GetKey(KeyCode.RightArrow))
      {
        rb.linearVelocityX = 5;
      }
    }
}

