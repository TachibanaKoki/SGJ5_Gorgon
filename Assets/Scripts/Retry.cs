﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.EyeTracking;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour {

    public float FlameCount = 10;
    private const string MAIN_SCENE_NAME = "Tachibana";
    private GazeAware m_GazeAware;
    
    // Use this for initialization
    void Start () {
        m_GazeAware = GetComponent<GazeAware>();

    }

    // Update is called once per frame
    void Update () {
        if (m_GazeAware.HasGazeFocus)
        {
            FlameCount--;
            if (FlameCount <= 0)
            {
                SceneManager.LoadScene(MAIN_SCENE_NAME);
            }
        }

    }
}