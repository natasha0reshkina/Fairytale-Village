using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Sword : MonoBehaviour
{
    [SerializeField] private int damageAmount = 2;
    public event EventHandler SwordSwing;
    private PolygonCollider2D _collider;

    private void Start()
    {
        ColliderOff();
    }
    private void Awake()
    {
        _collider = GetComponent<PolygonCollider2D>();
    }
    public void Attack()
    {
        Debug.Log("Attack called!");
        ColliderOn();
        SwordSwing?.Invoke(this, EventArgs.Empty);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"Collision with: {collision.name}"); 
        if (collision.transform.TryGetComponent(out EnemyLife enemyLife))
        {
            Debug.Log("Damage applied!");
            enemyLife.TakeDamage(damageAmount);
        }
    }

    public void ColliderOff()
    {
        _collider.enabled = false;
    }
    public void ColliderOn()
    {
        _collider.enabled = true;
    }
    
}