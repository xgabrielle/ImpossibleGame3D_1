using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.1f;
    public Rigidbody rb;
    public float jumpForce = 300;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed,0,0);
        bool whenKeyIsPressed = Input.GetKeyDown(KeyCode.Space);
        if (whenKeyIsPressed)
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(0, jumpForce, 0);
        }
    }
}
