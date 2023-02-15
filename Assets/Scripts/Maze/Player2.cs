using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player2 : MonoBehaviour
{
    public float speed = 5f;//�ƶ��ٶ�
    private Vector2 LookDirection = new Vector2(1, 0);
    Rigidbody2D rbody;
    public GameObject Dialog;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 movVector = new Vector2(moveX, moveY);
        if (movVector.x != 0 || movVector.y != 0)
        {
            LookDirection = movVector;
            Debug.Log(LookDirection);

        }

        Vector2 position = transform.position;
        position.x += moveX * speed * Time.deltaTime;
        position.y += moveY * speed * Time.deltaTime;

        transform.position = position;

        //����F����NPC�����ش�����
        if (Input.GetKeyDown(KeyCode.F))
        {
            RaycastHit2D hit = Physics2D.Raycast(rbody.position, LookDirection, 2f, LayerMask.GetMask("NPC"));
            if (hit.collider != null)
            {
                NPCMananger npc = hit.collider.GetComponent<NPCMananger>();
                if (npc != null)
                {
                    npc.ShowDialog();

                }

            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Dialog.SetActive(false);
        }

    }

    private void OnTriggerEnter2D(Collider2D Exit)
    {
        if (Exit.tag == "True")
        {
            Debug.Log("�����Ϣ����Ҫ��ҹ");
            SceneManager.LoadScene("Corridor_3");
        }

        if (Exit.tag == "False")
        {
            Debug.Log("Wrong");
            //Vector2 wrong_position = new Vector2(0, 0);
            //transform.position = wrong_position;
            SceneManager.LoadScene("Corridor_1");


        }
    }
}
