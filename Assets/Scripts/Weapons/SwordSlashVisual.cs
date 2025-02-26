using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSlashVisual : MonoBehaviour
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
        sword.SwordSwing += Sword_Swordswing;
    }
    private void Sword_Swordswing(object sender, System.EventArgs e)
    {
        Debug.Log("SwordSwing event received!");
        animator.SetTrigger(attack);
        
    }
    
}
