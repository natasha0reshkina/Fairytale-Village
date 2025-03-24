using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordVisual : MonoBehaviour
{   [SerializeField] private int damageamount = 2;
    [SerializeField] private Sword sword;
    private Animator animator;
    public event EventHandler SwordSwing;
    private const string attack = "Attack";
    public PolygonCollider2D polygonCollider2D;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        polygonCollider2D = GetComponent<PolygonCollider2D>();
    }

    private void Start()
    {
        sword.SwordSwing += Sword_Swordswing;
    }

    private void Sword_Swordswing(object sender, System.EventArgs e)
    {
        animator.SetTrigger(attack);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ударились");
        if (collision.transform.TryGetComponent(out EnemyLife enemyLife))
        {
            enemyLife.TakeDamage(damageamount);
        }
        if (collision.transform.TryGetComponent(out House house))
        {
            house.Fix();
        }
    }

    public void Attack()
    {
        SwordSwing?.Invoke(this, EventArgs.Empty);
    }
    public void StartAttack()
    {
        sword.ColliderOn();
    }

    public void EndAttack()
    {
        sword.ColliderOff();
    }
}
