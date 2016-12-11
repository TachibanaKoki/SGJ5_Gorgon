using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonGauge_script : MonoBehaviour {
    public Image gauge_image;
  　private float _gauge,_gaugeMax;
    // Use this for initialization
    void Start () {
        _gauge = 60;
        _gaugeMax = _gauge;
        gauge_image.fillAmount = 1;
        gauge_image.fillAmount = (_gauge / _gaugeMax);
    }
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(_gauge);
        
        if (_gauge<=0)
        {
            //---------------------------------------------
        }
    }
    public void GaugeCnt()
    {
        _gauge -= 1;
    }
    public void GaugeMax()
    {
        _gauge = _gaugeMax;
    }
}
