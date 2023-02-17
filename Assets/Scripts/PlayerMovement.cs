using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Vector2 _movementVector;
    [SerializeField] private float Speed;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_rb.velocity.x > 0)
                _movementVector = new Vector2(Speed, _rb.velocity.y);
            else
                _movementVector = new Vector2(-Speed, _rb.velocity.y);

            _rb.AddForce(_movementVector, ForceMode2D.Impulse);
        }
    }
}
