using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatePowerUp : MonoBehaviour
{
    [Header("Fire Rate")]
    [SerializeField] float _rateAdder = .05f;
    [SerializeField] float _minRate = 0.05f;
    [SerializeField] float _timeTillDestroy = 2f;
    [Header("Projectile Spread")]
    [SerializeField] float _spreadIncrease = 3;

    void Update()
    {
        _timeTillDestroy -= Time.deltaTime;
        if( _timeTillDestroy < 0 )
            Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            float currentRate = collision.GetComponent<ShootingController>().fireRate;
            if(currentRate - _rateAdder > _minRate)
            {
                collision.GetComponent<ShootingController>().fireRate -= _rateAdder;
                collision.GetComponent <ShootingController>().projectileSpread+=_spreadIncrease;
            }
            Destroy(gameObject);
        }
    }
}
