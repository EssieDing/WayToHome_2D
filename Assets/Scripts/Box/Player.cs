using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private RaycastHit2D[] raycast;
    private int hitNumbers = 0;
    public bool allReached = false;
    void Start () {

        raycast = new RaycastHit2D[4];
	}


    void Update () {
        if(allReached == false)
            Move();

	}
    private void Move()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            ClearRayCast();
            RayHit("Up");
            if(CanMove("Up"))
                transform.Translate(new Vector3(0, 1, 0));
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ClearRayCast();
            RayHit("Down");
            if (CanMove("Down"))
                transform.Translate(new Vector3(0, -1, 0));
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ClearRayCast();
            RayHit("Left");
            if (CanMove("Left"))
                transform.Translate(new Vector3(-1, 0, 0));
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ClearRayCast();
            RayHit("Right");
            if (CanMove("Right"))
                transform.Translate(new Vector3(1, 0, 0));
        }
    }

    private void RayHit(string dir)
    {
        Vector2 rayRightPos = new Vector2(transform.position.x + 0.6f, transform.position.y);
        Vector2 rayLeftPos = new Vector2(transform.position.x - 0.6f, transform.position.y);
        Vector2 rayUpPos = new Vector2(transform.position.x , transform.position.y + 0.6f);
        Vector2 rayDownPos = new Vector2(transform.position.x, transform.position.y - 0.6f);
        hitNumbers = 0;

        if(dir == "Right")
        {
            hitNumbers = Physics2D.RaycastNonAlloc(rayRightPos, new Vector2(1, 0), raycast, 0.5f);
        }
        else if (dir == "Left")
        {
            hitNumbers = Physics2D.RaycastNonAlloc(rayLeftPos, new Vector2(-1, 0), raycast, 0.5f);
        }
        else if (dir == "Up")
        {
            hitNumbers = Physics2D.RaycastNonAlloc(rayUpPos, new Vector2(0, 1), raycast, 0.5f);
        }
        else if (dir == "Down")
        {
            hitNumbers = Physics2D.RaycastNonAlloc(rayDownPos, new Vector2(0, -1), raycast, 0.5f );
        }

        
    }

    private bool CanMove(string dir)
    {

        if (hitNumbers == 1)
        {

            if (raycast[0].transform.gameObject.tag == "Wall")
            {
                return false;
            }
            else if (raycast[0].transform.gameObject.tag == "Box")
            {

                if (raycast[0].transform.GetComponent<Box>().Move(dir))
                    return true;
                else
                    return false;
            }
        }
        else if (hitNumbers == 0)
        {
            return true;
        }

        return true;
        
    }

    private void ClearRayCast()
    {
        
        raycast = new RaycastHit2D[4];
    }

}
