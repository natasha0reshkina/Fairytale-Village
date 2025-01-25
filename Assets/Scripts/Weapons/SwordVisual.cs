using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordVisual : MonoBehaviour
{
    [SerializeField] private Sword sword;
    private Animator animator;
    private const string attack = "Attack";
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        sword.OnSwordSwing += Sword_Swordswing;
    }

    private void Sword_Swordswing(object sender, EventArgs e)
    {
        animator.SetTrigger(attack);
        
    }
}
