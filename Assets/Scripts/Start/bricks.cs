using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bricks : MonoBehaviour
{
    public static int a = 1;


    void OnTriggerEnter2D(Collider2D other)
    {
        player pc = other.GetComponent<player>();
        if (pc != null && a == 1)
        {
            if (pc.tag == "player")
            {
                a = 0;
                pc.speed = 0;
                pc.transform.position = new Vector3(2.5f, 0.5f, 0.0f);
                Debug.Log("yes");
                bricks2.a = 0;
                bricks1.a = 0;
            }
            else
            {
                pc.transform.position = new Vector3(1.5f, -0.5f, 0.0f);

            }
        }
    }
    


}
