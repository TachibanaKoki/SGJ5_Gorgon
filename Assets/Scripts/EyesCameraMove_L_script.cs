using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.EyeTracking;
using Tobii.EyeX;


public class EyesCameraMove_L_script : MonoBehaviour {
    public GameObject camera_L;
    GazeAware eyesL;
    player_camera_script camel;
    // Use this for initialization
    void Start () {
        eyesL = GetComponent<GazeAware>();
        camel = camera_L.GetComponent<player_camera_script>();
    }
	
	// Update is called once per frame
	void Update () {
        if (eyesL.HasGazeFocus)
        {
            camel.LeftRot();
        }
    }
}
