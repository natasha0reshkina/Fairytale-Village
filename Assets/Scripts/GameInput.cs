 using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    public static GameInput instance { get; private set; }
    private PlayerInputActions playerInputActions;
    private void Awake()
    {
        instance = this;
        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();
    }
    public Vector2 GetMovementVector()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        return inputVector;
    }
    public Vector3 GetMousePosition()
    {
        Vector3 mousePos= Mouse.current.position.ReadValue();
        return mousePos;
    }
}
