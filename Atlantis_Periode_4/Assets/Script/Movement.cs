using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private float walkingSpeed;
    [SerializeField] private float jumpSpeed;

    [SerializeField] private Rigidbody2D player_rgd;
    [SerializeField] private bool grounded;

    [SerializeField] private Animator player_anim;

    [SerializeField] private float hor;

    [SerializeField] private bool movement;

    void Update()
    {
        player_anim.SetBool("IsGrounded", grounded);
        player_anim.SetBool("IsWalking", movement);

        hor = Input.GetAxis("Horizontal");

        player_rgd.velocity = new Vector2(hor * walkingSpeed, player_rgd.velocity.y);

        if (Input.GetButtonDown("Jump") && grounded)
        {
            player_rgd.velocity = new Vector2(player_rgd.velocity.x, jumpSpeed);
        }

        if (hor != 0)
        {
            movement = true;
        }
        else
        {
            movement = false;
        }

        if (hor > 0)
        {
            this.gameObject.transform.localScale = new Vector2(0.374f, 0.374f);
        }
        else if (hor < 0)
        {
            this.gameObject.transform.localScale = new Vector2(-0.374f, 0.374f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            grounded = false;
        }
    }
}
