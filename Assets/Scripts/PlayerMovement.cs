using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Transform _transform;
    public float Speed;
    private Vector2 _movementVector;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
        
    }

  
    private void Update()
    {

      
        if (Input.GetKey(KeyCode.D))
        {
            _rb.velocity = new Vector2(Speed , _rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _rb.velocity = new Vector2(-Speed , _rb.velocity.y);
          

        }
       
    }
}
