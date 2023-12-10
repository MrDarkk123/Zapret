using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidBody;
    float movementForce = 2;
    float jumpForce = 5;
    public float maxSpeed = 5;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        UpdateHorozintalMovement();
        UpdateJumpMovement();
       
    }

    private void UpdateHorozintalMovement() {
        rigidBody.AddForce(transform.right * movementForce * Input.GetAxis("Horizontal"), ForceMode2D.Force);
        if (System.Math.Abs(rigidBody.velocity.x) > maxSpeed) {
            int sign = 1;
            if (rigidBody.velocity.x < 0) {
                sign = -1;
            }
            rigidBody.velocity = new Vector3(maxSpeed * sign, rigidBody.velocity.y, 0);
        }

    }

    private void UpdateJumpMovement() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            rigidBody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
