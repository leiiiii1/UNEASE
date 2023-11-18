using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb; 
    public float speed; // For movement
    public float jumpingPower; // For jump
    public float horizontal;
    public float vertical;

    private bool isGrounded; // For jump
    private bool isFacingRight; // For flip
    private bool isFacingDown;

    public Transform groundCheck; // For jump
    public LayerMask groundLayer; // For jump

    private Animator animator;
    private bool isWalkin;
    private bool isupo;
    private bool isdown;

    private bool stop = true;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        TestingEvents testingEvents = GetComponent<TestingEvents>();
        testingEvents.onClickStart += TestingEvents_onClickStart;
    }

    // Update is called once per frame
    void Update()
    {
        if (stop == false)
        {
            PlayerMovement();
            HandleAnimation();
            Flip();
        }
    }

    private void TestingEvents_onClickStart(object sender, EventArgs e)
    {
        stop = false;
    }

    void PlayerMovement()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        isWalkin = horizontal != 0 ? true : false;
        isupo = vertical > 0 && horizontal == 0 ? true : false;
        isdown = vertical < 0 && horizontal == 0 ? true : false;
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
    }

    void HandleAnimation ()
    {
        animator.SetBool("isWalkin", isWalkin);
        animator.SetBool("isupo", isupo);
        animator.SetBool("isdown", isdown);
    }
    void Flip()
    {
        if(isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector2 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
