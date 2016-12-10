using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour {

    [SerializeField]
    GameObject Bullet;

    [SerializeField]
    float ShotRange = 15.0f;
    [SerializeField]
    float ShotTime = 0.5f;

    GameObject Player;

    bool isShot;

	// Use this for initialization
	void Start ()
    {
        isShot = false;
        StartCoroutine("ShotCoroutine");
        Player = Camera.main.gameObject;
        GetComponent<EnemyHit>().OnDeath_H += () => 
        {
            StopCoroutine("ShotCoroutine");
        };
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
        Vector3 ShotPos = transform.position + transform.forward*0.3f + Vector3.up;
        GameObject go = GameObject.Instantiate(Bullet,ShotPos,Quaternion.identity);
        Vector3 vec = Player.transform.position- ShotPos-Vector3.up;
        Vector3 v = new Vector3(Random.Range(-1.0f,1.0f),Random.Range(-1.0f,1.0f),Random.Range(-1.0f,1.0f));
        vec = vec + v;
        vec.Normalize();
        go.GetComponent<Rigidbody>().AddForce(vec*10.0f,ForceMode.Impulse);
    }
}
