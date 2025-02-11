using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordVisual : MonoBehaviour
{   [SerializeField] private int damageamount = 2;
    [SerializeField] private Sword sword;
    private Animator animator;
    private const string attack = "Attack";
    public PolygonCollider2D polygonCollider2D;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        polygonCollider2D = GetComponent<PolygonCollider2D>();
    }

    private void Start()
    {
        sword.OnSwordSwing += Sword_Swordswing;
    }

    private void Sword_Swordswing(object sender, System.EventArgs e)
    {
        animator.SetTrigger(attack);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.TryGetComponent(out EnemyLife enemyLife))
        {
            enemyLife.TakeDamage(damageamount);
        }
    }
}
