using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    public float jumpForce = 10f;
    public float runningSpeed = 1.5f;
    private Rigidbody2D rigidBody;
    public static PlayerControler instance;
    public Vector3 startingPosition;
    // Start is called before the first frame update

    private void Awake()
    {
        this.transform.position = startingPosition;
    }
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Jump");
            Jump();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (rigidBody.velocity.x < runningSpeed)
            {
                rigidBody.velocity = new Vector2(-runningSpeed, rigidBody.velocity.y);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (rigidBody.velocity.x < runningSpeed)
            {
                rigidBody.velocity = new Vector2(runningSpeed, rigidBody.velocity.y);
            }
        }

    }

    private void Jump()
    {
        if (IsGrounded())
        {
            Debug.Log("Jump B");
            rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }    
    }

    public LayerMask groundLayer;
    private bool IsGrounded()
    {
        if (Physics2D.Raycast(this.transform.position, Vector2.down, 2.0f, groundLayer.value))
        {
            //Debug.Log("t");
            return true;
        }
        else
        {
            //Debug.Log("f");
            return false;
        }    
    }

    public void Kill()
    {
        this.transform.position = startingPosition;
    }

}
