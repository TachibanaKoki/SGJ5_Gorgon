using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour {

    public NavMeshAgent m_Agent;
    private GameObject m_player;
    private float timer;
    private bool isStop;

	// Use this for initialization
	void Start ()
    {
        m_Agent = GetComponent<NavMeshAgent>();
        m_Agent.SetDestination(Vector3.zero);
        m_player = Camera.main.gameObject;
        isStop = false;
        timer = 0.0f;
        GetComponent<EnemyHit>().OnDeath_H += Stop;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isStop) return;
        timer += Time.deltaTime;

        if(timer > 1.0f)
        {
            timer = 0.0f;
            m_Agent.SetDestination(m_player.transform.position);
        }
	}

    void Stop()
    {
        m_Agent.Stop();
        GameManager.DestoryEnemy();
        isStop = true;
    }
}
