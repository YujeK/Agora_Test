using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private Transform _groundCheck;

    private CharacterController _controller;

    private bool _isGrounded;
    // Update is called once per frame

    [Header("Character Movement Settings")]
    public float _speed = 5f;
    public float _gravity = -10f;
    private float _groundDistance = 0.4f;
    public LayerMask _groundMask;
    private Vector3 _velocity;

    [Header("Jump")]
    [SerializeField] private KeyCode _jumpKey;
    public float _jumpHeight;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        GroundCheck();
        SetMovement();
        JumpHandler();
        ApplyGravity();
    }

    private void JumpHandler()
    {
        if (Input.GetKeyDown(_jumpKey) && _isGrounded)
        {
            _velocity.y = Mathf.Sqrt(_jumpHeight * -2f * _gravity);
        }
    }

    private void GroundCheck()
    {
        _isGrounded = Physics.CheckSphere(_groundCheck.position, _groundDistance, _groundMask);
        if (_isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }
    }

    private void ApplyGravity()
    {
        _velocity.y += _gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);
    }

    private void SetMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 direction = transform.right * x + transform.forward * z;
        _controller.Move(direction * _speed * Time.deltaTime);


        // Animation
        float velocityZ = Vector3.Dot(direction.normalized, transform.forward);
        float velocityX = Vector3.Dot(direction.normalized, transform.right);
        _animator.SetFloat("VelocityZ", velocityZ, 0.1f, Time.deltaTime);
        _animator.SetFloat("VelocityX", velocityX, 0.1f, Time.deltaTime);
    }
}
