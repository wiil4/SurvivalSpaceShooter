using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyIncreaser : MonoBehaviour
{
    [Header("Difficulty Increaser")]
    [SerializeField] float _timeBtwIncrease = 20f;

    [Header("EnemySpawner")]
    [SerializeField] EnemySpawner[] _enemySpawner = null;
    [SerializeField] float _enemySpawnDelay = 0f;
    float _currentTimer = 0f;

    void Start()
    {
        _currentTimer = _timeBtwIncrease;        
    }

    // Update is called once per frame
    void Update()
    {
        _currentTimer -= Time.deltaTime;
        if( _currentTimer < 0)
        {
            _currentTimer = _timeBtwIncrease;
            foreach(EnemySpawner spawner in _enemySpawner)
            {
                if (spawner.spawnDelay - _enemySpawnDelay > 0f)
                    spawner.spawnDelay -= _enemySpawnDelay;
            }
            
        }
    }
}
