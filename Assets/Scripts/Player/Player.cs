using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[SelectionBase]
public class Player : MonoBehaviour
{
    public static Player instance { get; private set; }

    [SerializeField] private float movingSpeed = 10f;

    private Vector2 inputVector;
    private Vector2 lastMoveDirection;

    private Rigidbody2D rb;
    private float minMovingSpeed = 0.1f;
    private bool isRunning = false;

    private void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        GameInput.instance.OnPlayerAttack += GameInput_OnPlayerAttack;
    }

    private void GameInput_OnPlayerAttack(object sender, EventArgs e)
    {
        ActiveWeapon.Instance.GetActiveWeapon().Attack();
    }

    private void Update()
    {
        inputVector = GameInput.instance.GetMovementVector();

        // Обновляем последнее направление, только если есть ввод
        if (inputVector != Vector2.zero)
        {
            lastMoveDirection = inputVector;
        }
    }

    private void FixedUpdate()
    {
        HandleMovement();
    }
    

    private void HandleMovement()
    {
        rb.MovePosition(rb.position + inputVector * (movingSpeed * Time.fixedDeltaTime));

        if (Mathf.Abs(inputVector.x) > minMovingSpeed || Mathf.Abs(inputVector.y) > minMovingSpeed)
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }
    }

    public bool IsRunning()
    {
        return isRunning;
    }

    public Vector3 GetPlayerScreenPosition()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    public Vector2 GetMoveDirection()
    {
        return lastMoveDirection;
    }
}