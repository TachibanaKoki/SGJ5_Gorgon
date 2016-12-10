using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     
	void Start ()
    {
        Destroy(gameObject,10.0f);
	}
	
	void Update ()
    {
	    
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
