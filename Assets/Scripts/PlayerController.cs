using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int speed = 2;
    private float horizontal;
    private SpriteRenderer spriteRen;
    private Rigidbody2D rb;
    private int force = 8;
    private bool onPlatform;
    void Start()
    {
        spriteRen=GetComponent<SpriteRenderer>();
       rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right*Time.deltaTime*speed*horizontal);
        spriteRen.flipX = horizontal < 0;
        if (Input.GetKeyDown(KeyCode.Space)&& onPlatform == true)
        {
         rb.AddForce(Vector2.up*force,ForceMode2D.Impulse);   
            onPlatform = false;
        }
    }
    private void OnCollisionEnter2D (Collision2D collision)
        
    {
     if (collision.gameObject.CompareTag("platform"))
        {

       onPlatform = true;

        }


    }
}
