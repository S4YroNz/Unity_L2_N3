using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionWithRopes : MonoBehaviour
{
    private HingeJoint2D _joint;
    private Transform _transform;

    void Start()
    {
        _joint = GetComponent<HingeJoint2D>();
        _transform = GetComponent<Transform>();
    }

    
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.name == "Segment8")
        { 

        _joint.enabled = true;
            Debug.Log(collision.contacts[0].point);
            _joint.connectedBody = collision.gameObject.GetComponent<Rigidbody2D>();
            _joint.anchor = _transform.InverseTransformPoint(collision.contacts[0].point);
            //_joint.connectedAnchor = new Vector2(collision.contacts[0].point.x, collision.contacts[0].point.y);
        }
    }
}
