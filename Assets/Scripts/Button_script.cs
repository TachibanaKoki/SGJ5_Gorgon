using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.EyeTracking;
using Tobii.EyeX;

public class Button_script : MonoBehaviour {
    public GameObject gauge;
     GazeAware eyes;
    private EyePositionDataProvider eyePosition_data;
    ButtonGauge_script buttonG;

    void Start()
    {
        eyes = GetComponent<GazeAware>();
        buttonG = gauge.GetComponent<ButtonGauge_script>();
    }
	void Update () {
        if (eyes.HasGazeFocus)
        {
            buttonG.GaugeCnt();
            Debug.Log("aaa");
        }
        else
        {
            buttonG.GaugeMax();
        }
       
      
    }
}
