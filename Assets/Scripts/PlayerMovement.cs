using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D)),
RequireComponent(typeof(SpriteRenderer)),
RequireComponent(typeof(BoxCollider2D)),
RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public Animator animatorComponent;
    SpriteRenderer spriteRendererComponent;
    public Rigidbody2D body;

    public bool facingRight;

    Vector2 movement;
    void Awake()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        animatorComponent = GetComponent<Animator>();
        spriteRendererComponent = GetComponent<SpriteRenderer>();

        facingRight = true;
    }
    void FixedUpdate() //Movement that allows player to walk up, down, left, or right & Player Inputs.
    {
        movement.x = Input.GetAxisRaw("Horizontal"); // Input Detection
        
        animatorComponent.SetFloat("Speed", Mathf.Abs(movement.x)); // Tells animator when to player the running animation

        body.velocity = new Vector2(movement.x * moveSpeed, body.velocity.y);

        
    if (movement.x < 0 && facingRight)  // Switch the way the player is labelled as facing
        {  
        
        transform.Rotate(0,180,0);  // Transform rotate player sprite
        facingRight = false;
        } 
    else if (movement.x > 0 && !facingRight)
        {
        transform.Rotate(0,0,0);  // Transform rotate player sprite
        facingRight = true;
        }
    }
}