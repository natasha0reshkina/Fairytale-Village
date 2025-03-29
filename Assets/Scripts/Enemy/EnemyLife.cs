using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public Sprite enemy;
    public GameObject money;
    private SpriteRenderer spriteRenderer; // убрали static
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

    public void Death()
    {
        // Создаём объект money и уничтожаем врага
        Instantiate(money, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Debug.Log("Enemy destroyed");
    }
}