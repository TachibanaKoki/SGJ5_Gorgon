using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.EyeTracking;
using Tobii.EyeX;

public class EyesCameraMove_script : MonoBehaviour {
    public GameObject camera;
    GazeAware eyesR;
    player_camera_script came;

    // Use this for initialization
    void Start () {
        eyesR = GetComponent<GazeAware>();
        came = camera.GetComponent<player_camera_script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (eyesR.HasGazeFocus)
        {
            came.RightRot();
        }
    }
}
