using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeGenerator : MonoBehaviour
{

    public Transform centraltPoint;
    public BridgePiece bridge;
    // Start is called before the first frame update
    //public bool isDrawing = false;
    //public Transform leftUp;
    //public Transform RightDown;
    //private Vector3 startingPosition;
    private void Awake()
    {
        //this.transform.position = startingPosition;
    }
    void Start()
    {
        Vector3 dirA = new Vector2(1,0);

        Vector3 dirB = new Vector2(1,-1);
        float angle = Vector3.Angle(dirA, dirB);
        Debug.Log(angle);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouse = Input.mousePosition;
        Vector2 worldmouse = Camera.main.ScreenToWorldPoint(mouse);
        //Debug.Log("position");
        if (Input.GetMouseButtonDown(0))
        {
            
            //Vector2 mouse = Input.mousePosition;
            //Vector2 worldmouse = Camera.main.ScreenToWorldPoint(mouse);
            //leftUp.position = worldmouse;
            //Debug.Log("a");
            //Debug.Log(leftUp.position);
            //GameObject a = GameObject.CreatePrimitive(PrimitiveType.Quad);

            BridgePiece piece = (BridgePiece)Instantiate(bridge);
            piece.transform.SetParent(this.transform, false);

            piece.transform.position = worldmouse;
            //Debug.Log("b");
            //isDrawing = true;

        }
        //if (Input.GetMouseButtonUp(0) && isDrawing == true)
        //{
            
        //    Vector2 mouse = Input.mousePosition;
        //    Vector2 worldmouse2 = Camera.main.ScreenToWorldPoint(mouse);
        //    RightDown.position = worldmouse2;

        //    Debug.Log(leftUp.position);
        //    Debug.Log(RightDown.position);

        //    BridgePiece piece = (BridgePiece)Instantiate(bridge);
        //    piece.transform.SetParent(this.transform, false);
        //    //piece.transform.position = (leftUp.position + RightDown.position)/2;
            
        //    piece.transform.position = leftUp.position;
        //    isDrawing = false;
        //}


    }
}
