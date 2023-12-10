using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
Rigidbody2D rigidBody;
    Animator animator;
    SpriteRenderer spriteRenderer;
    
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateWalking();
        UpdateJump();
        
    }

    private void UpdateWalking() {
        bool isWalking = rigidBody.velocity.magnitude > 0.01f;
        animator.SetBool("isWalking", isWalking);

        if (rigidBody.velocity.x < -0.1) {
            spriteRenderer.flipX = true;
        } else if (rigidBody.velocity.x > 0.1) {
            spriteRenderer.flipX = false;
        }
    }

    private void UpdateJump() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            animator.SetTrigger("jump");
        }
    }
}
