using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    private GameObject player;
    private GameObject[] boxs;
    private GameObject[] ends;
    private GameObject[] floors;
    public List<Vector2> boxList;
    public List<Vector2> endList;
    private Color ori;
    private bool isContain = false;
    private bool isConflict = false;
    public GameObject nextBtn;
    public GameObject gameoverText;
    
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        boxs = GameObject.FindGameObjectsWithTag("Box");
        boxs[0] = GameObject.Find("RedBox");
        boxs[1] = GameObject.Find("GreenBox");
        boxs[2] = GameObject.Find("OrangeBox");
        boxs[3] = GameObject.Find("PurpleBox");
        boxs[4] = GameObject.Find("BlueBox");
        boxs[5] = GameObject.Find("PinkBox");

        ends = GameObject.FindGameObjectsWithTag("End");
        ends[0] = GameObject.Find("RedEnd");
        ends[1] = GameObject.Find("GreenEnd");
        ends[2] = GameObject.Find("OrangeEnd");
        ends[3] = GameObject.Find("PurpleEnd");
        ends[4] = GameObject.Find("BlueEnd");
        ends[5] = GameObject.Find("PinkEnd");

        floors = GameObject.FindGameObjectsWithTag("Floor");
        ori = floors[0].GetComponent<SpriteRenderer>().color; // original color
        nextBtn = GameObject.Find("Canvas/ControlPanel/NextBtn");
        gameoverText = GameObject.Find("Canvas/ControlPanel/GameOverText");

        gameoverText.SetActive(false);
        nextBtn.GetComponent<Button>().enabled = false;

        for (int i = 0; i < ends.Length; i++)
            endList.Add(ends[i].transform.position);

	}
	
	// Update is called once per frame
	void FixedUpdate () {

        boxList.Clear();
        if(!isContain)
            GetBoxPos();
        FloorColor();
        if (!isContain) {
            Contains();
        } else
        {
            if(player != null)
                player.transform.GetComponent<Player>().allReached = true;
            if (nextBtn.activeSelf == false)
                nextBtn.SetActive(true);
            if (nextBtn.GetComponent<Button>().enabled == false)
                nextBtn.GetComponent<Button>().enabled = true;

        }
        if (isConflict)
        {
            Debug.Log ("You lose!");
            if (gameoverText.activeSelf == false)
                gameoverText.SetActive(true);
            player.transform.GetComponent<Player>().allReached = true;
        }
	}
    public void GetBoxPos()
    {
        for (int i = 0; i < boxs.Length; i++)
            boxList.Add(boxs[i].transform.position);
    }

    private void Contains()
    {
        int j = 0;
        for (int i = 0; i < ends.Length; i++) {
            if (boxList[i] == endList[i]) {
                j ++;
            }
        }
        if (j == endList.Count)
            isContain = true;
        else
            isContain = false;
    }
    //更新地板颜色
    private void FloorColor() {
        foreach (GameObject floor in floors) {
            foreach (GameObject box in boxs) {
                if (floor.transform.position == box.transform.position) {
                    Color co = box.GetComponent<SpriteRenderer>().color;
                    co.a = 255f/255f;
                    if (floor.GetComponent<SpriteRenderer>().color == ori) { //没有改变过颜色
                        floor.GetComponent<SpriteRenderer>().color = co;
                    } else{ //已经改变过
                        if (floor.GetComponent<SpriteRenderer>().color == co) { //箱子地板颜色相同
                        } else {
                            Debug.Log ("You lose!");
                            isConflict = true;
                        }
                    }   
                }
            }
            
        }

    }

        
    
    
}
