using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpavn : MonoBehaviour
{
    public GameObject enemyPref;
    public Transform SpawnPoint;
    public float spawnInterval = 1.0f;

    private float _timeSinceLastSpawn = 0.0f;

    void Update()
    {
        _timeSinceLastSpawn += Time.deltaTime;

        if (_timeSinceLastSpawn >= spawnInterval)
        {
            _timeSinceLastSpawn = 0.0f;
            Instantiate(enemyPref, SpawnPoint.position, SpawnPoint.rotation);
        }
    }
}
