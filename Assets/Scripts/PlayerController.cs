using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.1f;
    public float jumpForce = 300;
    public float jumpSpin = 2;
    public float turnLeftNRight;
    public float horizontalSpeed = 10;
    public float fallGravity = -1;
    public float fallTolerance = -.01f;

    private void FixedUpdate()
    {
        Rigidbody rigidbody =gameObject.GetComponent<Rigidbody>();
        if (rigidbody.velocity.y < fallTolerance)
        {
            rigidbody.AddForce(0,fallGravity,0);
        }
        Vector3 velocity = rigidbody.velocity;
        velocity.x = speed;
        rigidbody.velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        bool whenKeyIsPressed = Input.GetButtonDown("Jump");
        turnLeftNRight = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*turnLeftNRight*Time.deltaTime*horizontalSpeed);
        if (whenKeyIsPressed&& isTouchingGround())
        {
            Rigidbody playerRb = GetComponent<Rigidbody>();
            Vector3 velocity = playerRb.velocity;
            velocity.y = jumpForce;
            playerRb.velocity = velocity;
        }
    }
    bool isTouchingGround()
    {
        int layermask = LayerMask.GetMask("Ground");
        return Physics.CheckBox(transform.position, transform.lossyScale / 2,
            transform.rotation,layermask);
    }
    
    void LeftNRight()
    {
    
    }

    void Jump()
    {
        
    }
}