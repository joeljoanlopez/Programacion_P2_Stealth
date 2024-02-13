using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float _movementHorizontal { get; private set; }
    public float _movementVertical { get; private set; }

    // Update is called once per frame
    private void Update()
    {
        _movementHorizontal = Input.GetAxis("Horizontal");
        _movementVertical = Input.GetAxis("Vertical");
    }
}