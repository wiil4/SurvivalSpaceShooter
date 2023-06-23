using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporarySpawn : MonoBehaviour
{
    [SerializeField] float _timeTillDestroy = 2f;
    bool _isDestroyed = false;


    Animator _animator;
    
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        _timeTillDestroy -= Time.deltaTime;
        if( _timeTillDestroy < 0 && !_isDestroyed )
        {
            _isDestroyed = true;
            _animator.SetBool("Close", _isDestroyed);
        }
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
