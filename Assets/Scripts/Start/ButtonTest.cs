using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour
{
    public static int a = 1;

    // Start is called before the first frame update
    public void Restart()
    { 
       
        target.restart(a);
    }
}
