using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    //Instanzio le variabili con gli oggetti
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;
    bool isGrounded;

    //[SerializeField] //Rende la variabile utilizzabile nell'editor di unity
    //Transform groundCheck;
    private float runSpeed = 3;



    // Start is called before the first frame update
    void Start()
    {
        //Inizializzo le variabili con il componente associato
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        /*if (Physics2D.Linecast(transform.position, groundCheck.position, 0 << LayerMask.NameToLayer("Grounds")))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }*/

        //Mappatura dei tasti della tastiera ai movimenti del PG

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);

           
               animator.Play("Run");

            spriteRenderer.flipX = false;
        }

        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);

            
                animator.Play("Run");

            spriteRenderer.flipX = true;
        }

        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);

           
                animator.Play("Idle_Hero");

        }

        if (Input.GetKey("space") || Input.GetKey("w"))
        { 
            rb2d.velocity = new Vector2(rb2d.velocity.x, 3);
            animator.Play("Jump");
        }
    }
}
