using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceStationDestroy : MonoBehaviour
{
    [SerializeField] GameObject[] _itemsToSpawn = null;
    int _itemIndex;
    private void Start()
    {
        _itemIndex = Random.Range(0, _itemsToSpawn.Length);        
    }


    public void InstancePowerUp()
    {
        Instantiate(_itemsToSpawn[_itemIndex], transform.position, Quaternion.identity);
    }
}
