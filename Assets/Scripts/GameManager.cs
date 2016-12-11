using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager I;
    static int EnemyDestroyCount;
    private bool IsGameEnd;

	// Use this for initialization
	void Start ()
    {
        I = this;
        EnemyDestroyCount = 0;
        IsGameEnd = false;
	}

    void Update()
    {
        if (IsGameEnd) return;
        if(EnemyDestroyCount>=EnemySpawner.MaxSpawnEnemy)
        {
            IsGameEnd = true;
        }
    }
	
    static public void DestoryEnemy()
    {
        EnemyDestroyCount++;
    }
}
