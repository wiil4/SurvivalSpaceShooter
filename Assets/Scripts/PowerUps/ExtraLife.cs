using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    [SerializeField] float _timeTillDestroy = 2f;

    void Update()
    {
        _timeTillDestroy -= Time.deltaTime;
        if (_timeTillDestroy < 0)
            Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Health>().ReceiveLife();      
            Destroy(gameObject);
        }
    }
}
