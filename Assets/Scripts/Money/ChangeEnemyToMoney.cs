/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEnemyToMoney : MonoBehaviour
{
    public Sprite money;
    public Sprite enemy;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            spriteRenderer.sprite = enemy;
        }
    }

    public void Change()
    {
        if (spriteRenderer.sprite == enemy)
        {
            spriteRenderer.sprite = money;
        }
    }
}
*/
