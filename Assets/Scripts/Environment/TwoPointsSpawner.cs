using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPointsSpawner : MonoBehaviour
{
    [Header("Spawn Points")]
    [SerializeField] private Transform _minPoint = null;
    [SerializeField] private Transform _maxPoint = null;

    [Header("WhatToSpawn")]
    [SerializeField] private GameObject _spawn = null;

    [Header("Time Between Spawn")]
    [SerializeField] private float _timeBtwnSpawn = 2f;
    float _spawnTime;

    void Start()
    {
        _spawnTime = _timeBtwnSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        _spawnTime -= Time.deltaTime;
        if (_spawnTime < 0)
        {
            Instantiate(_spawn, NewRandomPosition(_minPoint, _maxPoint), Quaternion.identity, null);
            _spawnTime = _timeBtwnSpawn;
        }
    }

    Vector2 NewRandomPosition(Transform minTransform, Transform maxTransform)
    {
        float xPos = Random.Range(minTransform.position.x, maxTransform.position.x);
        float yPos = Random.Range(minTransform.position.y, maxTransform.position.y);
        return new Vector2(xPos, yPos);       
    }
}
