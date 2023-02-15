using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow2 : MonoBehaviour
{
    public static int a = 1;

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        player pc = other.GetComponent<player>();
        if (pc != null && a == 1)
        {
            if (pc.tag == "player1")
            {
                a = 0;
                pc.speed = 0;
                pc.transform.position = new Vector3(-5.5f, -3.5f, 0.0f);
                yellow.a = 0;
                yellow1.a = 0;
            }
            else
            {
                pc.transform.position = new Vector3(-0.5f, -0.5f, 0.0f);
            }
        }
    }
}
