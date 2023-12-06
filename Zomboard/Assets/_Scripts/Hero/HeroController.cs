using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 50;
    private Vector3 playerInput;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
    }

    private void FixedUpdate()
    {
        //WASD to move
        if (playerInput.magnitude < 0.01f) return;

        Debug.Log("Moving");
        rb.AddForce(playerInput * moveSpeed,ForceMode.Force);
    }
}
