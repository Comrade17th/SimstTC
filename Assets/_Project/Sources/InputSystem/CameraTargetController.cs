using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraTargetController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _deathZone = 0.1f;
    
    private CameraTarget _input;

    private Vector2 _moveDirection;
    private Vector2 _rotateDirection;
    
    private void Awake()
    {
        _input = new CameraTarget();
    }

    private void Update()
    {
        _moveDirection = _input.Camera.Move.ReadValue<Vector2>();
        _rotateDirection = _input.Camera.Rotate.ReadValue<Vector2>();
        
        Move();
        Rotate();
    }

    private void OnEnable()
    {
        _input.Enable();

        //_input.Camera.Move.performed += OnMove;
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    private void Rotate()
    {
        
    }

    private void Move()
    {
        if (_moveDirection.sqrMagnitude < _deathZone)
            return;

        float scaledMoveSpeed = _moveSpeed * Time.deltaTime;
        Vector3 offset = new Vector3(_moveDirection.x, 0f, _moveDirection.y) * scaledMoveSpeed;
        
        transform.Translate(offset);
    }

    private void OnRotate(InputAction.CallbackContext context)
    {
        _rotateDirection = context.action.ReadValue<Vector2>();
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        _moveDirection = context.action.ReadValue<Vector2>();
    }
}
