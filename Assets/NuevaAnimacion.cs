using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevaAnimacion : MonoBehaviour
{
    private Rigidbody2D rb;

    private Animator animato;

    private float moveSpeed;

    private float dirX;
    private bool facingRight = true;
    private Vector3 localScale;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animato = GetComponent<Animator>();
        localScale = transform.localScale;
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        if (Input.GetButtonDown("Jump") && rb.velocity.y == 0)
        {
            rb.AddForce(Vector2.up * 700f);

        }
        if (Mathf.Abs(dirX) > 0 && rb.velocity.y == 0)
        {
            animato.SetBool("isRunning", true);
        }
        else
        {
            animato.SetBool("isRunning", false);
        }

        if (rb.velocity.y == 0)
        {
            animato.SetBool("isJumping", false);
            animato.SetBool("isFalling", false);
        }

        if (rb.velocity.y > 0)
        {
            animato.SetBool("isJumping", true);

        }

        if (rb.velocity.y < 0)
        {
            animato.SetBool("isJumping", false);
            animato.SetBool("isFalling", true);

        }
    }

    private void fixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);

    }
    private void lateUpdate()
    {
        if (dirX > 0)
            facingRight = true;
        else if (dirX < 0)
            facingRight = false;

        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;
        transform.localScale = localScale;
    }
}
