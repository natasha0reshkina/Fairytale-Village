using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWeapon : MonoBehaviour
{
    public static ActiveWeapon Instance { get; private set; }

    [SerializeField] private Sword sword;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        FollowPlayerDirection();
    }

    public Sword GetActiveWeapon()
    {
        return sword;
    }

    private void FollowPlayerDirection()
    {
        Vector2 moveDir = Player.instance.GetMoveDirection();

     
        if (moveDir.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0); 
        }
        else if (moveDir.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0); 
        }

        
    }
}