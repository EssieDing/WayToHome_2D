using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCMananger : MonoBehaviour
{
    public GameObject dialogImage;
    // Start is called before the first frame update
    void Start()
    {
        dialogImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowDialog()
    {
        dialogImage.SetActive(true);
    }
    public void CloseDialog()
    {
        dialogImage.SetActive(false);
    }
}
