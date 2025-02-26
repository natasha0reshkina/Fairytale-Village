using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWeapon : MonoBehaviour
{
    public static ActiveWeapon Instance{ get; private set; }
    [SerializeField] private Sword sword;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        MouseFollowing();
    }
    public Sword GetActiveWeapon()
    {
        return sword;
    }
    private void MouseFollowing()
    {
        Vector3 mousePos = GameInput.instance.GetMousePosition();
        Vector3 playerPosition = Player.instance.GetPlayerScreenPosition();
        if(mousePos.x < playerPosition.x)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}