using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.PackageManager;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private const string CheckRun = "CheckRun";

    private void Awake()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        animator.SetBool(CheckRun, Player.instance.IsRunning());
        AdjustPlayerFacingDirection();
    }

    private void AdjustPlayerFacingDirection()
    {
  
        Vector2 moveDir = Player.instance.GetMoveDirection();

 
        if (moveDir.x < 0)
        {
            spriteRenderer.flipX = true;  
        }
        else if (moveDir.x > 0)
        {
            spriteRenderer.flipX = false; 
        }
 
    }
}