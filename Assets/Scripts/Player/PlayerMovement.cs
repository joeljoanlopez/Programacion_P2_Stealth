using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _playerInput;
    private float _stepTimer;
    private Vector2 _lastPosition;
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private StepController _stepController;

    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _lastPosition = transform.position;
    }

    private void Update()
    {
        Vector2 direction = new Vector2(_playerInput._movementHorizontal, _playerInput._movementVertical).normalized * _speed * Time.deltaTime;
        if (Input.GetKey("a") || Input.GetKey("d") || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey("s") || Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            _stepTimer = _stepTimer + Time.deltaTime;
        }
        //if(_stepTimer >= 0.2)
        //{
          //  _stepController.IncreaseSteps();
        //    _stepTimer = 0;
       // }
        float distanciaRecorrida = Vector2.Distance(_lastPosition, transform.position);

        if (distanciaRecorrida > 0.5f)
        {
            _stepController.IncreaseSteps();

            _lastPosition = transform.position;

        }
            transform.Translate(direction);
    }
}