using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ImageTest : MonoBehaviour
{
    public Image image;
    void Start()
    {
        image.sprite.rect.Set(image.sprite.rect.x, image.sprite.rect.y, image.sprite.rect.width, image.sprite.rect.height - 12);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
