using System;
using UnityEngine;

public class House : MonoBehaviour
{
    public Sprite brokenHouse;
    public Sprite fixedHouse;
    public static int unfixed = 5; 

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Fix()
    {
        if (spriteRenderer.sprite == brokenHouse && Money.money >= 100)
        {
            Money.money -= 100;
            spriteRenderer.sprite = fixedHouse; 
            Debug.Log("Дом починен!");
            HealthBar.HP = HealthBar.MaxHealth;
            unfixed -= 1;
        }
        else
        {
            Debug.Log("Дом уже починен или недостаточно денег.");
        }
    }

    public bool IsBroken()
    {
        return spriteRenderer.sprite == brokenHouse;
    }
}