using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 50;
    public float speedLimit = 5;
    private Vector3 playerInput;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        GroundCheck();
        if (Input.GetKeyDown(KeyCode.Space)) Jump();
    }

    private void FixedUpdate()
    {
        //WASD to move
        if (playerInput.magnitude < 0.01f) return;

        if (rb.velocity.magnitude > speedLimit) return;
        rb.AddForce(playerInput * moveSpeed,ForceMode.Force);
    }
    private void GroundCheck()
    {
        isGrounded = Physics.Raycast(transform.position + Vector3.up * 0.1f, Vector3.down, 0.2f);
        
        if (isGrounded) return;
        rb.AddForce(Vector3.down * 10, ForceMode.Force);
    }
    private void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(transform.up * moveSpeed / 2, ForceMode.Impulse);
        }
    }
}
