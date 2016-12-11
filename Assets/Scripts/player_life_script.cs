using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_life_script : MonoBehaviour {
    public Image bar_image;
    public GameObject player;
    player_camera_script play;
    
   
    // Use this for initialization
    void Start () {
        bar_image.fillAmount = 1;
        play = player.GetComponent<player_camera_script>();
    }
	
	// Update is called once per frame
	void Update () {
       bar_image.fillAmount = (play._life / play._lifeMax);
    }

}
