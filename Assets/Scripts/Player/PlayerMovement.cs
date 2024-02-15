using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _playerInput;
    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private StepController _stepController;
    private Vector2 posicionAnterior;
    // Start is called before the first frame update
    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        posicionAnterior = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        float distanciaRecorrida = Vector2.Distance(posicionAnterior, transform.position);

        if (distanciaRecorrida > 0.5f)
        {
            _stepController.IncreaseSteps();

            posicionAnterior = transform.position;
        }
            Vector2 direction = new Vector2(_playerInput._movementHorizontal, _playerInput._movementVertical).normalized * _speed * Time.deltaTime;
            transform.Translate(direction);
    }
}