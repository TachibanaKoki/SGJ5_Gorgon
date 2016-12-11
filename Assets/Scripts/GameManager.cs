using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager I;
    public static int EnemyDestroyCount;

    public int DeathCount
    {
        get
        {
            return EnemyDestroyCount;
        }
    }
    [SerializeField]
    Text text;
    [SerializeField]
    Text timer;

    private float m_timer;
    private bool IsGameEnd;

	// Use this for initialization
	void Start ()
    {
        I = this;
        EnemyDestroyCount = 0;
        IsGameEnd = false;
        m_timer=0;
	}

    void Update()
    {
        text.text = (EnemySpawner.MaxSpawnEnemy - EnemyDestroyCount).ToString();
        m_timer += Time.deltaTime;
        timer.text = ((int)m_timer).ToString();

        if (IsGameEnd) return;
        if(EnemyDestroyCount>=EnemySpawner.MaxSpawnEnemy)
        {
            IsGameEnd = true;
            PlayerPrefs.SetFloat("PlayTime",m_timer);
            PlayerPrefs.Save();
            SceneManager.LoadSceneAsync("Result");
        }
    }
	
    static public void DestoryEnemy()
    {
        EnemyDestroyCount++;
    }
}
