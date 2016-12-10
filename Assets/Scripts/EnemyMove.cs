using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour {

    NavMeshAgent m_Agent;

	// Use this for initialization
	void Start ()
    {
        m_Agent = GetComponent<NavMeshAgent>();
        m_Agent.SetDestination(Vector3.zero);
        GetComponent<EnemyHit>().OnDeath_H += ()=> { m_Agent.Stop();Debug.Log("Stop"); };
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    void Stop()
    {
        m_Agent.Stop();
    }
}
