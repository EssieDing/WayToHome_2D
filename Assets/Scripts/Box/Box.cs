using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

    private RaycastHit2D[] raycast;
    private int hitNumbers = 0;

    public bool Move(string dir)
    {
        if(dir == "Up")
        {
            ClearRayCast();
            RayHit("Up");
            if(CanMove())
            {
                transform.Translate(new Vector2(0, 1));
                return true;
            }
            
        }
        else if(dir == "Down")
        {
            ClearRayCast();
            RayHit("Down");
            if (CanMove())
            {
                transform.Translate(new Vector2(0, -1));
                return true;
            }
        }
        else if(dir == "Left")
        {
            ClearRayCast();
            RayHit("Left");
            if (CanMove())
            {
                transform.Translate(new Vector2(-1, 0));
                return true;
            }
        }
        else if(dir == "Right")
        {
            ClearRayCast();
            RayHit("Right");
            if (CanMove())
            {
                transform.Translate(new Vector2(1, 0));
                return true;
            }
        }
        
        return false;
    }

    private void RayHit(string dir)
    {
        Vector2 rayRightPos = new Vector2(transform.position.x + 0.6f, transform.position.y);
        Vector2 rayLeftPos = new Vector2(transform.position.x - 0.6f, transform.position.y);
        Vector2 rayUpPos = new Vector2(transform.position.x, transform.position.y + 0.6f);
        Vector2 rayDownPos = new Vector2(transform.position.x, transform.position.y - 0.6f);
        hitNumbers = 0;
        if (dir == "Right")
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
            hitNumbers = Physics2D.RaycastNonAlloc(rayDownPos, new Vector2(0, -1), raycast, 0.5f);
        }


    }
    private bool CanMove()
    {

        if (hitNumbers == 0)
        {
            return true;
        }
       else if(hitNumbers == 1)
        {
            if (raycast[0].transform.gameObject.tag == "End")
                return true;
            else if (raycast[0].transform.gameObject.tag == "Box")
                return false;
            else if (raycast[0].transform.gameObject.tag == "Wall")
                return false;
        }
        return true;

    }
    private void ClearRayCast()
    {
        
        raycast = new RaycastHit2D[4];
    }
}
