using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class target : MonoBehaviour
{
    public static int a = 1;

    // Update is called once per frame
   public void Update()
    {
        

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        player pc = other.GetComponent<player>();
        Debug.Log("yes");
        if (pc != null && a == 1)
        {
            this.transform.position = new Vector3(5.5f, 6.5f, 0.0f);
            a=2;
            ButtonTest.a = 2;
            GameObject.Find("player").transform.position = new Vector3(0.5f, 0.5f, 0.0f);
            GameObject.Find("player").GetComponent<player>().speed =3;
            GameObject.Find("player1").transform.position = new Vector3(-0.5f, -0.5f, 0.0f);
            GameObject.Find("player1").GetComponent<player>().speed = 3;
            GameObject.Find("player2").transform.position = new Vector3(1.5f, -0.5f, 0.0f);
            GameObject.Find("player2").GetComponent<player>().speed = 3;
            yellow.a = 1;
            yellow1.a = 1;
            yellow2.a = 1;
            blue.a = 1;
            blue1.a = 1;
            blue2.a = 1;
            bricks.a = 1;
            bricks1.a = 1;
            bricks2.a = 1;
            Debug.Log("First arrive");

        } else if (pc != null &&a==2)
                {

            this.transform.position = new Vector3(8.5f, 3.5f, 0.0f);

            a=3;
            ButtonTest.a = 3;
            GameObject.Find("player").transform.position = new Vector3(-0.5f, -0.5f, 0.0f);
            GameObject.Find("player").GetComponent<player>().speed = 3;
            GameObject.Find("player1").transform.position = new Vector3(1.5f, -0.5f, 0.0f);
            GameObject.Find("player1").GetComponent<player>().speed = 3;
            GameObject.Find("player2").transform.position = new Vector3(0.5f, 1.5f, 0.0f);
            GameObject.Find("player2").GetComponent<player>().speed = 3;
            yellow.a = 1;
            yellow1.a = 1;
            yellow2.a = 1;
            blue.a = 1;
            blue1.a = 1;
            blue2.a = 1;
            bricks.a = 1;
            bricks1.a = 1;
            bricks2.a = 1;
            Debug.Log("Second arrive");
        }
       else if (pc != null &&a == 3)
{

            this.transform.position = new Vector3(0.5f, -0.5f, 0.0f);

            a++;
            ButtonTest.a = 4;
            GameObject.Find("player").transform.position = new Vector3(0.5f, 1.5f, 0.0f);
            GameObject.Find("player").GetComponent<player>().speed = 3;
            GameObject.Find("player1").transform.position = new Vector3(1.5f, -0.5f, 0.0f);
            GameObject.Find("player1").GetComponent<player>().speed = 3;
            GameObject.Find("player2").transform.position = new Vector3(-0.5f, -0.5f, 0.0f);
            GameObject.Find("player2").GetComponent<player>().speed = 3; ;
            yellow.a = 1;
            yellow1.a = 1;
            yellow2.a = 1;
            blue.a = 1;
            blue1.a = 1;
            blue2.a = 1;
            bricks.a = 1;
            bricks1.a = 1;
            bricks2.a = 1;
            Debug.Log("Third arrive");
            SceneManager.LoadScene("Bridge");
        }
   }
   public static void restart(int a)
    {
        if (a == 1)
        {
            GameObject.Find("target").transform.position = new Vector3(-7.5f, -1.5f, 0.0f);


            GameObject.Find("player").transform.position = new Vector3(0.5f, 0.5f, 0.0f);
            GameObject.Find("player").GetComponent<player>().speed = 3;
            GameObject.Find("player1").transform.position = new Vector3(1.5f, -0.5f, 0.0f);
            GameObject.Find("player1").GetComponent<player>().speed = 3;
            GameObject.Find("player2").transform.position = new Vector3(-0.5f, -0.5f, 0.0f);
            GameObject.Find("player2").GetComponent<player>().speed = 3;
            yellow.a = 1;
            yellow1.a = 1;
            yellow2.a = 1;
            blue.a = 1;
            blue1.a = 1;
            blue2.a = 1;
            bricks.a = 1;
            bricks1.a = 1;
            bricks2.a = 1;

        }

    
       else if (a == 2)
        {


            GameObject.Find("target").transform.position = new Vector3(5.5f, 6.5f, 0.0f);
       
            
            GameObject.Find("player").transform.position = new Vector3(0.5f, 0.5f, 0.0f);
            GameObject.Find("player").GetComponent<player>().speed = 3;
            GameObject.Find("player1").transform.position = new Vector3(-0.5f, -0.5f, 0.0f);
            GameObject.Find("player1").GetComponent<player>().speed = 3;
            GameObject.Find("player2").transform.position = new Vector3(1.5f, -0.5f, 0.0f);
            GameObject.Find("player2").GetComponent<player>().speed = 3;
            yellow.a = 1;
            yellow1.a = 1;
            yellow2.a = 1;
            blue.a = 1;
            blue1.a = 1;
            blue2.a = 1;
            bricks.a = 1;
            bricks1.a = 1;
            bricks2.a = 1;

        }
        else if (a == 3)
        {

            GameObject.Find("target").transform.position = new Vector3(8.5f, 3.5f, 0.0f);

       
     
            GameObject.Find("player").transform.position = new Vector3(-0.5f, -0.5f, 0.0f);
            GameObject.Find("player").GetComponent<player>().speed = 3;
            GameObject.Find("player1").transform.position = new Vector3(1.5f, -0.5f, 0.0f);
            GameObject.Find("player1").GetComponent<player>().speed = 3;
            GameObject.Find("player2").transform.position = new Vector3(0.5f, 1.5f, 0.0f);
            GameObject.Find("player2").GetComponent<player>().speed = 3;
            yellow.a = 1;
            yellow1.a = 1;
            yellow2.a = 1;
            blue.a = 1;
            blue1.a = 1;
            blue2.a = 1;
            bricks.a = 1;
            bricks1.a = 1;
            bricks2.a = 1;
        }
        else if (a == 4)
        {

            GameObject.Find("target").transform.position = new Vector3(0.5f, -0.5f, 0.0f);

           
         
            GameObject.Find("player").transform.position = new Vector3(0.5f, 1.5f, 0.0f);
            GameObject.Find("player").GetComponent<player>().speed = 3;
            GameObject.Find("player1").transform.position = new Vector3(1.5f, -0.5f, 0.0f);
            GameObject.Find("player1").GetComponent<player>().speed = 3;
            GameObject.Find("player2").transform.position = new Vector3(-0.5f, -0.5f, 0.0f);
            GameObject.Find("player2").GetComponent<player>().speed = 3; ;
            yellow.a = 1;
            yellow1.a = 1;
            yellow2.a = 1;
            blue.a = 1;
            blue1.a = 1;
            blue2.a = 1;
            bricks.a = 1;
            bricks1.a = 1;
            bricks2.a = 1;

        }
    }
}
