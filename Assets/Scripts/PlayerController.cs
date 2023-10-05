using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.1f;
    public Rigidbody playerRb;
    public float jumpForce = 300;

    public bool playerOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed,0,0);
        bool whenKeyIsPressed = Input.GetButtonDown("Jump");
        if (whenKeyIsPressed&& playerOnGround)
        {
            playerRb = GetComponent<Rigidbody>();
            playerRb.AddForce(0, jumpForce, 0);
        }
    }
}
