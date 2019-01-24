using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;
    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
    public float runSpeed = 3f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.LeftShift)) //Shift to run
        runSpeed = 5f;
        else
        runSpeed = 3f;
    }

    private void FixedUpdate()
    {        
        if (horizontal != 0 && vertical != 0)
           body.velocity = new Vector2((horizontal * runSpeed) * moveLimiter, (vertical * runSpeed) * moveLimiter);
        else
           body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);                
    }
}
