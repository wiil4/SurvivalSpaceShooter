using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float _speed;

    [Header("Time Till Destroy")]
    [SerializeField] float _destroyTime = 2f;

    float _currentDestroyTime = 0;
    bool _isVisible = true;

    Transform _target;

    Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        try
        {
            _target = GameObject.FindGameObjectWithTag("Player").transform;
        }
        catch
        {
            _target = this.transform;
        }

        Vector2 targetDirection = _target.position - transform.position;
        _rb.velocity = targetDirection.normalized * _speed;
    }

    private void Update()
    {
        _currentDestroyTime -= Time.deltaTime;
        if (_currentDestroyTime < 0 && !_isVisible)
        {
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        _isVisible = false;
    }
    private void OnBecameVisible()
    {
        _currentDestroyTime = _destroyTime;
        _isVisible = true;
    }
}
