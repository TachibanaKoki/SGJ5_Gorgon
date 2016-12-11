using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.EyeTracking;

public class EnemyHit : MonoBehaviour
{

    public float EnemyHp = 500;
    private GazeAware m_GazeAware;
    public  bool isAlive;
    public delegate void OnDeath();
    public OnDeath OnDeath_H;
    private Renderer[] Childs;
    private float MaxHp;
    [SerializeField]
    private GameObject ParticleEffect;

    // Use this for initialization
    void Start()
    {
        m_GazeAware = GetComponent<GazeAware>();
        isAlive = true;

        Childs = GetComponentsInChildren<Renderer>();
        MaxHp = EnemyHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_GazeAware.HasGazeFocus)
        {
            EnemyHp--;
        }
        for (int i=0;i< Childs.Length;i++)
        {
            Childs[i].GetComponent<Renderer>().material.SetFloat("_Fill",1-(EnemyHp / MaxHp));
        }
            //此処から先はHPがなくなったとき
            if (EnemyHp > 0) return;
        if (isAlive)
        {
            isAlive = false;

            if (OnDeath_H != null)
            {
                Debug.Log("Death");
                OnDeath_H();
            }

            GameObject.Instantiate(ParticleEffect,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }

    }

}
