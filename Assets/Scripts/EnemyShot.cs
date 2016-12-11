using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyShot : MonoBehaviour {

    [SerializeField]
    GameObject Bullet;

    float ShotRange = 20.0f;
    [SerializeField]
    float ShotTime = 0.5f;

    GameObject Player;
    EnemyMove e_move;

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
        e_move = GetComponent<EnemyMove>();
	}

    // Update is called once per frame
    void Update()
    {
        isShot = false;
        if (!(Vector3.Distance(transform.position, Player.transform.position) < ShotRange)) return;
        Vector3 vec = Player.transform.position - transform.position;
        float d =Vector3.Dot(vec,transform.forward);
        if (d < 0) return;

        NavMeshHit hit;
        if (!e_move.m_Agent.Raycast(Player.transform.position, out hit))
        {
            isShot = true;
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
