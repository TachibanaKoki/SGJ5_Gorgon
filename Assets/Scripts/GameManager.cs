using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager I;
    static int EnemyDestroyCount;
    [SerializeField]
    Text text;

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
        text.text = (EnemySpawner.MaxSpawnEnemy - EnemyDestroyCount).ToString();
        if (IsGameEnd) return;
        if(EnemyDestroyCount>=EnemySpawner.MaxSpawnEnemy)
        {
            IsGameEnd = true;
            SceneManager.LoadSceneAsync("Result");
        }
    }
	
    static public void DestoryEnemy()
    {
        EnemyDestroyCount++;
    }
}
