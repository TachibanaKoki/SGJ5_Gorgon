using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBreakSe_script : MonoBehaviour {
    private AudioSource ESe;
    private bool _breakEnemySe;
    // Use this for initialization
    void Start () {
        _breakEnemySe = false;
        ESe = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (_breakEnemySe == true)
        {
            ESe.PlayOneShot(ESe.clip);
            _breakEnemySe = false;
        }
    }
    public void EbreakSe()
    {
        _breakEnemySe=true;
    }
}
