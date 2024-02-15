using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _playerInput;
    [SerializeField] private float _speed = 5.0f;

    // Start is called before the first frame update
    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 direction = new Vector2(_playerInput._movementHorizontal, _playerInput._movementVertical).normalized * _speed * Time.deltaTime;
        transform.Translate(direction);
    }
}