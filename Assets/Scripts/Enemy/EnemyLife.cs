using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public Sprite enemy;
    public GameObject money;
    public static SpriteRenderer spriteRenderer;
    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;
    private BoxCollider2D _boxCollider2D;
    private void Awake()
    {
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void Start()
    {
        
            currentHealth = maxHealth;
            spriteRenderer = GetComponent<SpriteRenderer>();
      
      
    }

    public void TakeDamage(int damage)
    {
        
            currentHealth -= damage;
            if (currentHealth <= 0)
            {
                Death();
            }
        
    }
    /*public void Change()
    {
        StartCoroutine(ChangeWithDelay());
    }

    private IEnumerator ChangeWithDelay()
    {
        spriteRenderer.sprite = money;
        Money.money += 100;

        yield return new WaitForSeconds(3f); 

        Destroy(gameObject);
    }*/
    

    public void Death()
    {
        /*Change();*/
        Instantiate(money, transform.position, Quaternion.identity);

        Destroy(gameObject);
        Debug.Log("помер");
    }

   


}