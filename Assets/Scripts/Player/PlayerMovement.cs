using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _playerInput;
    [SerializeField] private float _speed = 5.0f;
    public Animator _animator;

    // Start is called before the first frame update
    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 direction = new Vector2(_playerInput._movementHorizontal, _playerInput._movementVertical).normalized;

        if (direction.magnitude == 0)
        {
            _animator.SetBool("IsMoving", false);
        }
        else
        {
            transform.Translate(direction * _speed * Time.deltaTime);
            _animator.SetBool("IsMoving", true);
            _animator.SetFloat("HorizontalMove", _playerInput._movementHorizontal);
            _animator.SetFloat("VerticalMove", _playerInput._movementVertical);
        }
    }
}