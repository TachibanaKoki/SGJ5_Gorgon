using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour {

    [SerializeField]
    GameObject Bullet;

    [SerializeField]
    float ShotRange = 5.0f;
    [SerializeField]
    float ShotTime = 0.5f;

    [SerializeField]
    GameObject Player;

    bool isShot;

	// Use this for initialization
	void Start ()
    {
        isShot = false;
        StartCoroutine("ShotCoroutine");
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Vector3.Distance(transform.position,Player.transform.position)<ShotRange)
        {
            isShot = true;
        }
        else
        {
            isShot = false;
        }
	}

    IEnumerator ShotCoroutine()
    {
        while(true)
        {
            if(isShot)
            {
                Shot();
            }

            yield return new WaitForSeconds(ShotTime);
        }
    }

    void Shot()
    {
        GameObject go = GameObject.Instantiate(Bullet,transform.position+transform.forward,Quaternion.identity);
        Vector3 vec = Player.transform.position-transform.position;
        go.GetComponent<Rigidbody>().AddForce(vec*0.5f);
    }
}
