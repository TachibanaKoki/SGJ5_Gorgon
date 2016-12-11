using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sean_move_script : MonoBehaviour {
    public Image seanBlack;
    private float colorCntMax, colorCnt;
    private bool seanM;


    // Use this for initialization
    void Start () {
        colorCntMax = 20;
        colorCnt = 0;
        seanM = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (seanM == true)
        {
            seanBlack.color = new Color(seanBlack.color.r, seanBlack.color.g, seanBlack.color.b, colorCnt);
            colorCnt+=1/ colorCntMax;
            if (colorCnt > 1)
            {
                SceneManager.LoadScene("Main");
            }
        }
    }
    public void endSean()
    {
        seanM = true;
    }
}
