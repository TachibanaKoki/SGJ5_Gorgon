using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayTime : MonoBehaviour {

    public Text playTimeText;
	// Use this for initialization
	void Start () {
        playTimeText.text = "PlayTime: " + PlayerPrefs.GetFloat("PlayTime") + "seconds.";
	}
	
}
