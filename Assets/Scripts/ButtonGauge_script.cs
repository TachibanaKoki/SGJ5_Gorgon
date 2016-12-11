﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonGauge_script : MonoBehaviour {
    public Image gauge_image;
  　private float _gauge,_gaugeMax;
    // Use this for initialization
    void Start () {
        _gauge = 0;
        _gaugeMax = 40;
        gauge_image.fillAmount = 1;
       
    }
	
	// Update is called once per frame
	void Update () {
        gauge_image.fillAmount = (_gauge / _gaugeMax);
        if (_gauge<=0)
        {
           Application.LoadLevel("Main");
        }
    }
    public void GaugeCnt()
    {
        _gauge += 1;
    }
    public void GaugeMax()
    {
        _gauge = 0;
    }
}
