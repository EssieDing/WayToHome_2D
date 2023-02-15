using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class AppManager : MonoBehaviour {

    private GameObject startPanel;
    private GameObject controlPanel;
    private int levelCount;
    private GameObject levelObj;
    private GameObject levelPrefab;
    private GameObject currentLevel;
    public Text levelTxt;
    public Button nextBtn;
    public Button restBtn;
    public GameObject nextBtnObj;

    void Start()
    {
        levelCount = 0;

        levelObj = GameObject.Find("LevelPanel").gameObject;

        startPanel = GameObject.Find("InstructionPanel");

        controlPanel = GameObject.Find("ControlPanel");

        nextBtnObj = GameObject.Find("Canvas/ControlPanel/NextBtn");

        if (controlPanel.activeSelf == true)
            controlPanel.SetActive(false);


        nextBtn.onClick.AddListener(delegate () {
            //SceneManager.LoadScene("StartScene");
            SceneManager.LoadScene("Corridor_1");
        });

        restBtn.onClick.AddListener(delegate () {
            levelCount--;
            this.LoadLevel();
        });
    }
	
    public void StartGame()
    {
        levelCount++;
        if (startPanel.activeSelf == true)
            startPanel.SetActive(false);
        if (controlPanel.activeSelf == false)
            controlPanel.SetActive(true);
        LoadLevel();
        
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void LoadLevel()
    {
        if (levelCount >= 1)
            levelCount = 1;

        if (currentLevel != null)
            DestroyImmediate(currentLevel);
        string path = "Box/Level" + levelCount.ToString();
        levelPrefab = Resources.Load(path) as GameObject;
        currentLevel = Instantiate(levelPrefab, new Vector2(0, 0.5f), Quaternion.identity, levelObj.transform);
        if (nextBtnObj.activeSelf == true)
            nextBtnObj.SetActive(false);
        levelCount++;
    }

}
