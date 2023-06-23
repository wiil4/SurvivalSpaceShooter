using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILivesContainer : MonoBehaviour
{
    [SerializeField] GameObject _uiLifeIndicator;

    GameObject _playerRef;
    int _currentLives;

    void Start()
    {
        _playerRef = GameObject.FindGameObjectWithTag("Player");
        SetLives();
    }

    private void Update()
    {
    }

    private void SetLives()
    {
        _currentLives = _playerRef.GetComponent<Health>().currentLives;
        for (int i = 0; i < _currentLives; i++)
        {
            AddLife();
        }
    }
    public void AddLife()
    {
        GameObject uiLife = Instantiate(_uiLifeIndicator);
        uiLife.transform.SetParent(transform, false);
    }

    public void TakeLife()
    {
        GameObject lastChild = transform.GetChild(transform.childCount - 1).gameObject;
        Destroy(lastChild);
        
    }

}
