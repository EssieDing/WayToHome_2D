using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rigdbody;
    // Start is called before the first frame update
    private float inputX, inputY;
    Vector2 moveDir;
    public LayerMask detectLayer;
    void Start()
    {

        rigdbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveDir = Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            moveDir = Vector2.down;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveDir = Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveDir = Vector2.right;
        }

    }
    void Run()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");
        Vector2 input = new Vector2(inputX, inputY).normalized;
        rigdbody.velocity = input * speed;



    }

}
