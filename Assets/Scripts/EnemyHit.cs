using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.EyeTracking;

public class EnemyHit : MonoBehaviour
{

    public float EnemyHp = 10;
    private GazeAware m_GazeAware;
    public  bool isAlive;
    public delegate void OnDeath();
    public OnDeath OnDeath_H;

    // Use this for initialization
    void Start()
    {
        m_GazeAware = GetComponent<GazeAware>();
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_GazeAware.HasGazeFocus)
        {
            EnemyHp--;
        }

        //此処から先はHPがなくなったとき
        if (EnemyHp > 0) return;
        if (isAlive)
        {
            isAlive = false;

            GetComponent<Renderer>().material.color = Color.red;

            if (OnDeath_H != null)
            {
                Debug.Log("Death");
                OnDeath_H();
            }
        }

    }

}
