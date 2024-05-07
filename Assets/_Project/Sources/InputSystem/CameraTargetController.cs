using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.InputSystem;

public class CameraTargetController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _zoomSpeed = 1 / 120;
    [SerializeField] private float _zoomMin = 6f;
    [SerializeField] private float _zoomMax = 25f;
    [SerializeField] private float _deathZone = 0.1f;
    [SerializeField] private CinemachineVirtualCamera _virtualCamera;

    private CinemachineTransposer _transposer;
    private CameraTarget _input;

    private Vector2 _moveDirection;
    private Vector2 _rotateDirection;
    private float _zoomDirection;
    
    private void Awake()
    {
        _input = new CameraTarget();
        
        Assert.IsNotNull(_virtualCamera);
        _transposer = _virtualCamera.GetCinemachineComponent<CinemachineTransposer>();
        Assert.IsNotNull(_transposer);
    }

    private void Start()
    {
        //_transposer.m_FollowOffset = new Vector3(0, 25, 0);
    }

    private void Update()
    {
        _moveDirection = _input.Camera.Move.ReadValue<Vector2>();
        _rotateDirection = _input.Camera.Rotate.ReadValue<Vector2>();
        _zoomDirection = _input.Camera.Zoom.ReadValue<float>();
        //Debug.Log(_zoomDirection);
        
        Move();
        Rotate();
        Zoom();
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

    private void Zoom()
    {
        //if (_zoomDirection.sqrMagnitude < _deathZone)
        //    return;
        
        float scaledZoomSpeed = _zoomSpeed * Time.deltaTime;
        float offset = _zoomDirection * scaledZoomSpeed;
        float followOffsetY = _transposer.m_FollowOffset.y + offset;
        
        followOffsetY = Mathf.Clamp(followOffsetY, _zoomMin, _zoomMax);
        _transposer.m_FollowOffset = new Vector3(_transposer.m_FollowOffset.x,
            followOffsetY,
            _transposer.m_FollowOffset.z);
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
