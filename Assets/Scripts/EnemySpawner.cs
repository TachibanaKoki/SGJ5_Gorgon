﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public static int SpawnEnemyCount;
    public const int MaxSpawnEnemy=15;
    const int stageMaxEnemys = 4;

    [SerializeField]
    float TimeSpan= 5.0f;

    [SerializeField]
    float Randomness = 1.0f;

    [SerializeField]
    GameObject Enemy;

    [SerializeField]
    Vector2 SpawnRange = new Vector2(1, 1);


    void Awake()
    {
        SpawnEnemyCount = 0;
    }
    // Use this for initialization
    void Start ()
    {
        StartCoroutine("EnemyCoroutine");

	}

    IEnumerator EnemyCoroutine()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(TimeSpan+Random.Range(-Randomness,Randomness));
        }
    }

    void SpawnEnemy()
    {
        if ((SpawnEnemyCount - GameManager.EnemyDestroyCount)>=stageMaxEnemys) return;
        SpawnEnemyCount++;
        if (SpawnEnemyCount > MaxSpawnEnemy) return;
        GameObject go = GameObject.Instantiate(Enemy, transform.position + transform.forward+ new Vector3(Random.Range(-SpawnRange.x, SpawnRange.x),0.0f,Random.Range(-SpawnRange.y,SpawnRange.y)), transform.rotation);

    }
}
