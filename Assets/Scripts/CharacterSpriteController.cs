using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpriteController : MonoBehaviour
{
    public Sprite[] characterSprites;
    private int currentSprite;

    private void Start()
    {
        currentSprite = 0;
        GetComponent<SpriteRenderer>().sprite = characterSprites[currentSprite];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            currentSprite = (currentSprite + 1) % characterSprites.Length;
            GetComponent<SpriteRenderer>().sprite = characterSprites[currentSprite];
        }
    }
}
