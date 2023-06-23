using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField] float speed = 2f;

    RawImage rawImage;

    void Start()
    {       
        rawImage = GetComponent<RawImage>();        
    }

    void Update()
    {
        float move = rawImage.uvRect.x + speed * Time.deltaTime;
        rawImage.uvRect = new Rect(move, rawImage.uvRect.y, rawImage.uvRect.width, rawImage.uvRect.height);


    }
}
