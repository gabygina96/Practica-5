using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Vector2 spawnRange;
    public Transform posEnemy;

    public Transform posEnemy2;
    private GameObject tmpEnemy;

    private GameObject tmpEnemy2;

    void Start()
    {
        // InvokeRepeating("SpawnEnemy",0f,3f);
        StartCoroutine("spawnEnemies");
    }

    // void SpawnEnemy()
    // {
    //     Instantiate(enemyPrefab, 
    //      new Vector3(Random.Range(
    //                  -spawnRange.x, spawnRange.x),
    //                 0,
    //                 Random.Range(
    //                  -spawnRange.y, spawnRange.y)),
    //                 Quaternion.identity);
    // }

    IEnumerator spawnEnemies()
    {
        tmpEnemy = Instantiate(enemyPrefab, posEnemy.position, Quaternion.identity);
        tmpEnemy2 = Instantiate(enemyPrefab, posEnemy2.position, Quaternion.identity);
        yield return new WaitForSeconds(15f);
        StartCoroutine("spawnEnemies");
    }
}
