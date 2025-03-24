using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
     public Sprite brokenHouse;
     public Sprite house;
     public static SpriteRenderer spriteRenderer;
     private CapsuleCollider2D _capsuleCollider2D;
     private void Awake()
     {
         _capsuleCollider2D = GetComponent<CapsuleCollider2D>();
     }
   
     private void Start()
     {
        
         spriteRenderer = GetComponent<SpriteRenderer>();
      
      
     }

     public void Fix()
     {
        Debug.Log(spriteRenderer);
        Debug.Log(Money.money);
        spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Log(spriteRenderer.name ?? "spriteRenderer");
        Debug.Log(brokenHouse.name ?? "brokenHouse");
         if(spriteRenderer.sprite == brokenHouse && Money.money >= 100)
         {
             Debug.Log("пупупупупупупу");
             Money.money -= 100;
             spriteRenderer.sprite = house;

         }
        
     }
}
